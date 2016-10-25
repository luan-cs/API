using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Transactions;

using System.Configuration;

using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using VVPosWS.Common;
//using System.Runtime.InteropServices.ExternalException;


namespace VVPosWS.DAL
{
    public static partial class DataAccess
    {
        private static string sExtend;
        //private ImageHandler ImageHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectString"></param>
        /// <returns></returns>
        public static bool IsDatReady(string pConnectString)
        {
            MySqlConnection connection = new MySqlConnection(pConnectString);
            try
            {
                connection.Open();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// use select queries
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pQueryString"></param>
        /// <param name="pDataset"></param>
        /// <param name="pTableName"></param>
        /// <param name="pError"></param>
        public static void DataQuery(string pConnectionString, string pQueryString, ref DataSet pDataset, string pTableName, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryString, connection);
                command.CommandType = CommandType.Text;

                adapter.SelectCommand = command;
                adapter.Fill(pDataset, pTableName);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                pError = "";
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryString, ex.Message);
            }

            connection.Dispose();
        }

        public static void DataStoreProcQuery(string pConnectionString, string pQueryCmd, ref DataSet pDataset, ref string pError)
        {
            const int DB_TIMEOUT = 60;
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter(pQueryCmd, connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandTimeout = DB_TIMEOUT;
                adapter.Fill(pDataset);
                adapter.Dispose();
                connection.Dispose();
                pError = "";
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryCmd, ex.Message);
            }
            connection.Dispose();
        }

        public static void DataStoreProcQuery_Param(string pConnectionString, string pQueryCmd, ref DataSet pDataset, string[][] param, ref string pError)
        {
            const int DB_TIMEOUT = 60;
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter(pQueryCmd, connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < param.Length; i++)
                {
                    adapter.SelectCommand.Parameters.AddWithValue(param[i][0], param[i][1]);
                }
                adapter.SelectCommand.CommandTimeout = DB_TIMEOUT;
                adapter.Fill(pDataset);
                adapter.Dispose();
                connection.Dispose();
                pError = "";
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryCmd, ex.Message);
            }
            connection.Dispose();
        }

        public static void DataStoreProcExecute(string pConnectionString, string pQueryCmd, ref string pError, string[][] param, ref bool result)
        {
            const int DB_TIMEOUT = 60;
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            MySqlTransaction tx = null;
            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryCmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < param.Length; i++)
                {
                    command.Parameters.AddWithValue(param[i][0], param[i][1]);
                }
                tx = connection.BeginTransaction();
                command.Transaction = tx;
                command.ExecuteNonQuery();
                tx.Commit();
                command.Dispose();
                result = true;
                pError = "";
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                pError = string.Format("{0}:\r\n{1}", pQueryCmd, ex.Message);
                result = false;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public static void DataStoreProceduceAndMultiQuery(string pConnectionString, string pQueryCmd,
            ref string pError, string[][] param, string[] pQueryOrder, ref bool result)
        {
            const int DB_TIMEOUT = 60;
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand commandQuery;
            MySqlCommand command;
            MySqlTransaction tx = null;
            try
            {
                connection.Open();
                //store proc
                command = new MySqlCommand(pQueryCmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < param.Length; i++)
                {
                    command.Parameters.AddWithValue(param[i][0], param[i][1]);
                }
                tx = connection.BeginTransaction();
                command.Transaction = tx;
                command.ExecuteNonQuery();
                //query order.
                if (pQueryOrder.Length != 0)
                {

                    commandQuery = new MySqlCommand();
                    commandQuery.Connection = connection;
                    commandQuery.CommandType = CommandType.Text;
                    commandQuery.CommandTimeout = DB_TIMEOUT;
                    for (int i = 0; i < pQueryOrder.Length; i++)
                    {
                        commandQuery.CommandText = pQueryOrder[i];
                        commandQuery.ExecuteNonQuery();
                    }
                    commandQuery.Dispose();
                }
                tx.Commit();
                command.Dispose();
                result = true;
                pError = "";
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                pError = string.Format("{0}:\r\n{1}", pQueryCmd, ex.Message);
                result = false;
            }
            finally
            {
                connection.Dispose();
            }
        }

        /// <summary>
        /// use insert, delete, update
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pQueryString"></param>
        /// <param name="pError"></param>
        public static void DataExecute(string pConnectionString, string pQueryString, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;

            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryString, connection);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryString, ex.Message);
            }

            connection.Dispose();
        }

        /// <summary>
        /// often used for the insert statement table id is auto-incremented integer
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pQueryString"></param>
        /// <param name="pError"></param>
        public static void DataExecuteId(string pConnectionString, string pQueryString, ref Int64 pId, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;

            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryString, connection);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                if (pQueryString.Trim().Substring(0, 6).ToLower() == "insert")
                {
                    pId = command.LastInsertedId;
                }
                else
                    pId = 0;

                command.Dispose();
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryString, ex.Message);
            }

            connection.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pQueryArrString"></param>
        /// <param name="pError"></param>
        public static void DataMultiExecute(string pConnectionString, string[] pQueryArrString, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                foreach (string pQueryString in pQueryArrString)
                {
                    command.CommandText = pQueryString;
                    command.ExecuteNonQuery();
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                pError = ex.Message;
            }

            connection.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectString"></param>
        /// <param name="pQueryString"></param>
        /// <param name="pObject"></param>
        /// <param name="pError"></param>
        public static void DataScalar(string pConnectString, string pQueryString, ref object pObject, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectString);
            MySqlCommand command;

            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryString, connection);
                command.CommandType = CommandType.Text;

                pObject = command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                pError = "";
            }
            catch (Exception ex)
            {
                pObject = null;
                pError = string.Format("{0}:\r\n{1}", pQueryString, ex.Message);
            }

            connection.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pDataSet"></param>
        /// <param name="pTableName"></param>
        /// <param name="pToTable"></param>
        /// <param name="pError"></param>
        /// <returns></returns>
        public static bool DataCommandBuilder(string pConnectionString, DataSet pDataSet, string pTableName, string pToTable, ref string pError)
        {
            MySqlConnection connect = new MySqlConnection(pConnectionString);
            MySqlDataAdapter adapter;
            MySqlCommandBuilder builder;
            DataSet ds = new DataSet();

            try
            {
                connect.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM " + pToTable, connect);
                builder = new MySqlCommandBuilder(adapter);
                adapter.Fill(ds, "test");
                builder.GetUpdateCommand();
                adapter.Update(pDataSet, pTableName);
                adapter.Dispose();
                connect.Close();
                pError = "";

                return true;
            }
            catch (Exception ex)
            {
                pError = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pImageBuffer"></param>
        /// <param name="pId"></param>
        /// <param name="pColumnIdName"></param>
        /// <param name="pTableName"></param>
        /// <param name="pError"></param>
        public static void DataSaveImage(string pConnectionString, byte[] pImageBuffer, string pId, string pColumnIdName, string pColumnImageName, string pTableName, ref string pError)
        {
            DataSet dataset = new DataSet();
            string strQuery = string.Format("SELECT {0} FROM {1} WHERE {0} = '{2}'", pColumnIdName, pTableName, pId);
            DataAccess.DataQuery(pConnectionString, strQuery, ref dataset, "test", ref pError);

            if (dataset.Tables["test"].Rows.Count == 0)
            {
                pError = "No record";
                return;
            }
            else
            {
                strQuery = string.Format("UPDATE {0} SET {1} = @Image WHERE {2} = @Id", pTableName, pColumnImageName, pColumnIdName);
                MySqlConnection connection = new MySqlConnection(pConnectionString);
                MySqlCommand command = new MySqlCommand(strQuery, connection);
                try
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Id", MySqlDbType.VarChar, 16);
                    command.Parameters["@Id"].Direction = ParameterDirection.Input;
                    command.Parameters["@Id"].Value = pId;

                    command.Parameters.Add("@Image", MySqlDbType.LongBlob, pImageBuffer.Length);
                    command.Parameters["@Image"].Direction = ParameterDirection.Input;
                    command.Parameters["@Image"].Value = pImageBuffer;

                    command.ExecuteNonQuery();
                    pError = "";
                }
                catch (Exception ex)
                {
                    pError = string.Format("{0}:\r\n{1}", strQuery, ex.Message);
                }

                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
        }

             

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pId"></param>
        /// <param name="pColumnIdName"></param>
        /// <param name="pColumnImageName"></param>
        /// <param name="pTableName"></param>
        /// <param name="pError"></param>
        /// <returns></returns>
        public static byte[] DataReadImage(string pConnectionString, string pId, string pColumnIdName, string pColumnImageName, string pTableName, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            connection.Open();
            string strQuery = string.Format("SELECT {0} FROM {1} WHERE {2} = '{3}'", pColumnImageName, pTableName, pColumnIdName, pId);
            MySqlCommand command = new MySqlCommand(strQuery, connection);
            byte[] buffer = new byte[1];
            try
            {
                buffer = (byte[])command.ExecuteScalar();
                command.Clone();
                connection.Close();
                connection.Dispose();
                return buffer;
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", strQuery, ex.Message);
                return null;
            }
        }
        /// <summary>
        /// use insert, delete, update
        /// </summary>
        /// <param name="pConnectionString"></param>
        /// <param name="pQueryString"></param>
        /// <param name="pError"></param>
        public static void DataExecuteForProduct(string pConnectionString, string Name, string Name2, string Name3, string Unit, decimal UnitPrice, int IsNode, int IsPrint, string Notes, int ParentId, string CreateDate, string UpdateDate, byte[] Image, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            string pQueryString;
            if (Unit == "NULL" || string.IsNullOrEmpty(Unit))
            {
                pQueryString = "Insert into Products(Name, Name2, Name3, UnitPrice, IsNode, IsPrint, Notes, ParentId, CreatedDate, UpdatedDate, Image) values('" + Name + "','" + Name2 + "','" + Name3 + "','" + UnitPrice + "','" + IsNode + "','" + IsPrint + "','" + Notes + "','" + ParentId + "','" + CreateDate + "','" + UpdateDate + "', @Image)";
            }
            else
            {
                pQueryString = "Insert into Products(Name, Name2, Name3, Unit, UnitPrice, IsNode, IsPrint, Notes, ParentId, CreatedDate, UpdatedDate, Image) values('" + Name + "','" + Name2 + "','" + Name3 + "','" + Unit + "','" + UnitPrice + "','" + IsNode + "','" + IsPrint + "','" + Notes + "','" + ParentId + "','" + CreateDate + "','" + UpdateDate + "', @Image)";
            }
            try
            {

                connection.Open();
                command = new MySqlCommand(pQueryString, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new MySqlParameter("@Image", Image));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryString, ex.Message);
            }

            connection.Dispose();
        }
        public static void DataExecuteEdit_ForProduct(string pConnectionString, string Name, string Name2, string Name3, string Unit, decimal UnitPrice, int IsNode, int IsPrint, string Notes, int ParentId, string UpdateDate, byte[] Image, string ProductId, ref string pError)
        {
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;

            string pQueryString;
            string pUnit = Unit;
            if (Unit != "NULL")
            {
                pUnit = "'" + Unit + "'";
            }

            if (Image == null)
            {
                pQueryString = "Update Products set Name='" + Name + "', Name2='" + Name2 + "', Name3='" + Name3 + "', Unit=" + pUnit + ", UnitPrice='" + UnitPrice + "', IsNode='" + IsNode + "'";
                pQueryString += ", IsPrint='" + IsPrint + "', Notes='" + Notes + "', ParentId='" + ParentId + "', UpdatedDate='" + UpdateDate + "' Where ProductId ='" + ProductId + "'";

            }
            else
            {
                pQueryString = "Update Products set Name='" + Name + "', Name2='" + Name2 + "', Name3='" + Name3 + "', Unit=" + pUnit + ", UnitPrice='" + UnitPrice + "', IsNode='" + IsNode + "'";
                pQueryString += ", IsPrint='" + IsPrint + "', Notes='" + Notes + "', ParentId='" + ParentId + "', UpdatedDate='" + UpdateDate + "', Image=@Image " + " Where ProductId ='" + ProductId + "'";

            }
            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryString, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(new MySqlParameter("@Image", Image));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                pError = string.Format("{0}:\r\n{1}", pQueryString, ex.Message);
            }
            connection.Dispose();
        }


        public static void Tran_InsertOrder(string pConnectionString, string[][] param, List<string[][]> lstdt, ref string pError)
        {
            bool result = true;
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    // inset thông tin order
                    DataStoreProcExecute1(pConnectionString, "spInsert_Orders", ref pError, param, ref result);
                    if (result )
                    {
                        // Insert Chi tiết order
                        for (int i = 0; i < lstdt.Count; i++)
                        {
                            //string[][] paramdt ={
                            //        for(int j=0; j<lstdt[i].Length;j++){
                            //            new string[] {"order_id",lstdt[i][j].ToString()},
                            //            /*new string[] {"product_id",r["ProductId"].ToString()},
                            //            new string[] {"qty_s", double.Parse(r["Qty"].ToString()).ToString()},
                            //            new string[] {"price_s",double.Parse(r["Price"].ToString()).ToString()},
                            //            new string[] {"create_by",r["CreateBy"].ToString()},
                            //            new string[] {"status_s",r["Status"].ToString()},
                            //            new string[] {"ammount_before_tax",double.Parse(r["AmmountBeforeTax"].ToString()).ToString()},
                            //            new string[] {"tax_ammount",double.Parse(r["TaxAmmount"].ToString()).ToString()},
                            //            new string[] {"total_ammount",double.Parse(r["TotalAmount"].ToString()).ToString()},*/
                            //        }
                            //        };
                            DataStoreProcExecute1(pConnectionString, "spInsert_OrderDetail", ref pError, lstdt[i], ref result);

                        }
                        scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    result = false;
                    pError = string.Format("{0}:\r\n{1}", "spInsert_Orders", ex.Message);
                }

            }

        }

        public static void DataStoreProcExecute1(string pConnectionString, string pQueryCmd, ref string pError, string[][] param, ref bool result)
        {
            const int DB_TIMEOUT = 60;
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            MySqlTransaction tx = null;
            try
            {
                connection.Open();
                command = new MySqlCommand(pQueryCmd, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < param.Length; i++)
                {
                    command.Parameters.AddWithValue(param[i][0], param[i][1]);
                }
                tx = connection.BeginTransaction();
                command.Transaction = tx;
                command.ExecuteNonQuery();

                tx.Commit();
                command.Dispose();
                result = true;
                pError = "";
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                result = false;
                pError = string.Format("{0}:\r\n{1}", pQueryCmd, ex.Message);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public static void Tran_Insert_Order(string pConnectionString, ref string pError, string[][] param, List<string[][]> lstdt, string[][] paramDesk, ref bool result, ref bool IsPrint)
        {
            const int DB_TIMEOUT = 60;

            ////////Tao OrderID o day;
            string OrderId = CreateOrderid(); ////
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            MySqlTransaction tx = null;
            try
            {
                connection.Open();
                command = new MySqlCommand("spInsert_Orders", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < param.Length; i++)
                {
                    if (param[i][0] == "order_id")
                    {
                        command.Parameters.AddWithValue("order_id", OrderId);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(param[i][0], param[i][1]);
                    }
                    //command.Parameters.AddWithValue(param[i][0], param[i][1]);
                }
                tx = connection.BeginTransaction();
                command.Transaction = tx;
                command.ExecuteNonQuery();
                ////Inser Order detail
                for (int i = 0; i < lstdt.Count; i++)
                {
                    command = new MySqlCommand("spInsert_OrderDetail", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = DB_TIMEOUT;
                    for (int j = 0; j < lstdt[i].Length; j++)
                    {
                        string[][] pr = lstdt[i];
                        if (pr[j][0] == "order_id")
                        {
                            command.Parameters.AddWithValue("order_id", OrderId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(pr[j][0], pr[j][1]);
                        }
                        //command.Parameters.AddWithValue(pr[j][0], pr[j][1]);

                    }
                    command.Transaction = tx;
                    command.ExecuteNonQuery();
                }

                //Update IsUsing Desk
                command = new MySqlCommand("spUpdate_Desk_IsUsing", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < paramDesk.Length; i++)
                {
                    command.Parameters.AddWithValue(paramDesk[i][0], paramDesk[i][1]);
                }
                command.Transaction = tx;
                command.ExecuteNonQuery();

                tx.Commit();
                command.Dispose();
                result = true;
                pError = "";

                // goi ham in
                if (IsPrint) {
                    IsPrint = Print_Rabep();
                }
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                result = false;
                pError = string.Format("{0}:\r\n{1}", "transaction_insert_order", ex.Message);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public static void Tran_Insert_Order(string pConnectionString, ref string pError, string[][] param, List<string[][]> lstdt, ref bool result, ref bool IsPrint)
        {
            const int DB_TIMEOUT = 60;

            ////////Tao OrderID o day;
            string OrderId = CreateOrderid(); ////
            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            MySqlTransaction tx = null;
            try
            {
                connection.Open();
                command = new MySqlCommand("spInsert_Orders", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < param.Length; i++)
                {
                    if (param[i][0] == "order_id")
                    {
                        command.Parameters.AddWithValue("order_id", OrderId);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(param[i][0], param[i][1]);
                    }
                    //command.Parameters.AddWithValue(param[i][0], param[i][1]);
                }
                tx = connection.BeginTransaction();
                command.Transaction = tx;
                command.ExecuteNonQuery();
                ////Inser Order detail
                for (int i = 0; i < lstdt.Count; i++)
                {
                    command = new MySqlCommand("spInsert_OrderDetail", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = DB_TIMEOUT;
                    for (int j = 0; j < lstdt[i].Length; j++)
                    {
                        string[][] pr = lstdt[i];
                        if (pr[j][0] == "order_id")
                        {
                            command.Parameters.AddWithValue("order_id", OrderId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(pr[j][0], pr[j][1]);
                        }
                        //command.Parameters.AddWithValue(pr[j][0], pr[j][1]);

                    }
                    command.Transaction = tx;
                    command.ExecuteNonQuery();
                }

                tx.Commit();
                command.Dispose();
                result = true;
                pError = "";

                // goi ham in
                if (IsPrint)
                {
                    IsPrint = Print_Rabep();
                }
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                result = false;
                pError = string.Format("{0}:\r\n{1}", "transaction_insert_order", ex.Message);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public static bool Print_Rabep()
        {
            PrintDocument pd = new PrintDocument();
            //pd.PrinterSettings.PrinterName = @"CutePDF Writer";
            pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A7", 394, 10000);
            pd.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            pd.Print();

            return true;
        }

        private static void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string fname = "lnbjkl hjkbh jkb";
            //var img = imgCapture.Image;
            // cong them 60 cho zo position (margin-top)
            //var imgLogo = AutoCapture.Properties.Resources.logo;
            //Rectangle logo = new Rectangle(10, 75, 45, 26);

            //Rectangle imgToShow = new Rectangle(10, 101, 190, 143);
            //logo
            Rectangle lbOrderId = new Rectangle(10, 75, 45, 26);
            Rectangle OrderId = new Rectangle(10, 75, 45, 26);
            Rectangle lbDesk = new Rectangle(10, 75, 45, 26);
            Rectangle DeskNo = new Rectangle(10, 75, 45, 26);

            Rectangle strRec = new Rectangle(10, 244, 190, 22);
            //float penWidth = 1;
            //using (Pen pen = new Pen(SystemColors.HotTrack, penWidth))
            //{
            //    float shrinkAmount = pen.Width / 2;

            //    e.Graphics.DrawRectangle(
            //        pen,
            //        strRec.X + shrinkAmount,   // move half a pen-width to the right
            //        strRec.Y + shrinkAmount,   // move half a pen-width to the down
            //        strRec.Width - penWidth,   // shrink width with one pen-width
            //        strRec.Height - penWidth); // shrink height with one pen-width
            //}
            //public void DrawImage(Image image, int x, int y, int width, int height);
            //e.Graphics.DrawImage(img, 0, 0, 480, 480);週末
            //e.Graphics.DrawImage(imgLogo, logo);
            //e.Graphics.DrawImage(img, imgToShow);
            string data = String.Format("{0} \n", "ui huih ịkbk");
            //public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format);
            //e.Graphics.DrawString(data, new Font("Arial", 20, FontStyle.Regular), Brushes.Black,30, 455);
            StringFormat strfmt = new StringFormat();
            strfmt.Alignment = StringAlignment.Center;
            strfmt.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(data, new Font("Arial", 11, FontStyle.Regular), Brushes.DarkSlateBlue, strRec, strfmt);

            //Single yPos = 0;
            //Single leftMargin = e.MarginBounds.Left;
            //Single topMargin = e.MarginBounds.Top;
            //Image img = imgCapture.Image;
            //Rectangle logo = new Rectangle(20, 10, 640, 480);
            //using (Font printFont = new Font("Arial", 10.0f))
            //{
            //    e.Graphics.DrawImage(img, logo);
            //    e.Graphics.DrawString(data, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            //}
        }

        public static void Tran_Insert_Receipt(string pConnectionString, ref string pError,
            string[][] Receipt,
            List<string[][]> listReceiptDetail,
            List<string[][]> listReceiptCard,
            string[][] ReceiptMember,
            string[][] ReceiptInfo,
            ref bool result, ref string ReceiptID)
        {
            string spName = "";
            const int DB_TIMEOUT = 60;
            ////////Tao recieptID o day;
            string ReceiptId = Tao_ReceiptID(); ////

            MySqlConnection connection = new MySqlConnection(pConnectionString);
            MySqlCommand command;
            MySqlTransaction tx = null;
            try
            {
                connection.Open();
                command = new MySqlCommand("spInsert_Receipt", connection);
                spName = "spInsert_Receipt";
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = DB_TIMEOUT;
                for (int i = 0; i < Receipt.Length; i++)
                {
                    if (Receipt[i][0] == "ReceiptId")
                    {
                        command.Parameters.AddWithValue("p_" + "ReceiptId", ReceiptId);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("p_" + Receipt[i][0], Receipt[i][1]);
                    }
                }
                tx = connection.BeginTransaction();
                command.Transaction = tx;
                command.ExecuteNonQuery();
                //// detail
                for (int i = 0; i < listReceiptDetail.Count; i++)
                {
                    command = new MySqlCommand("spInsert_ReceiptDetail", connection);
                    spName = "spInsert_ReceiptDetail";
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = DB_TIMEOUT;
                    string OrderId = "";
                    string ProductId = "";
                    for (int j = 0; j < listReceiptDetail[i].Length; j++)
                    {
                        string[][] pr = listReceiptDetail[i];
                        if (pr[j][0] == "ReceiptId")
                        {
                            command.Parameters.AddWithValue("p_" + "ReceiptId", ReceiptId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("p_" + pr[j][0], pr[j][1]);
                        }

                        if (pr[j][0] == "RefOrderId")
                        {
                            OrderId = pr[j][1];
                        }

                        if (pr[j][0] == "ProductId")
                        {
                            ProductId = pr[j][1];
                        }
                    }
                    command.Transaction = tx;
                    command.ExecuteNonQuery();

                    //update Order Details
                    if (!string.IsNullOrEmpty(OrderId) && !string.IsNullOrEmpty(ProductId))
                    {
                        command = new MySqlCommand("spUpdate_Status_OrderDetail", connection);
                        spName = "spUpdate_Status_OrderDetail";
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = DB_TIMEOUT;
                        command.Parameters.AddWithValue("p_" + "OrderId", OrderId);
                        command.Parameters.AddWithValue("p_" + "ProductId", ProductId); command.Transaction = tx;
                        command.ExecuteNonQuery();
                    }

                }
                //////// list the
                if (listReceiptCard != null)
                {
                    for (int i = 0; i < listReceiptCard.Count; i++)
                    {
                        command = new MySqlCommand("spInsert_ReceiptCard", connection);
                        spName = "spInsert_ReceiptCard";
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = DB_TIMEOUT;

                        for (int j = 0; j < listReceiptCard[i].Length; j++)
                        {
                            string[][] pr = listReceiptCard[i];
                            if (pr[j][0] == "ReceiptId")
                            {
                                command.Parameters.AddWithValue("p_" + "ReceiptId", ReceiptId);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("p_" + pr[j][0], pr[j][1]);
                            }



                        }
                        command.Transaction = tx;
                        command.ExecuteNonQuery();

                    }
                }
                //// ReceiptInfo
                if (ReceiptInfo != null)
                {
                    command = new MySqlCommand("spInsert_ReceiptInfo", connection);
                    spName = "spInsert_ReceiptInfo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = DB_TIMEOUT;
                    for (int i = 0; i < ReceiptInfo.Length; i++)
                    {
                        if (ReceiptInfo[i][0] == "ReceiptId")
                        {
                            command.Parameters.AddWithValue("p_" + "ReceiptId", ReceiptId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("p_" + ReceiptInfo[i][0], ReceiptInfo[i][1]);
                        }
                    }
                    command.Transaction = tx;
                    command.ExecuteNonQuery();
                }
                //// RecieptMember
                if (ReceiptMember != null)
                {
                    command = new MySqlCommand("spInsert_ReceiptMember", connection);
                    spName = "spInsert_ReceiptMember";
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = DB_TIMEOUT;
                    for (int i = 0; i < ReceiptMember.Length; i++)
                    {
                        if (ReceiptMember[i][0] == "ReceiptId")
                        {
                            command.Parameters.AddWithValue("p_" + "ReceiptId", ReceiptId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("p_" + ReceiptMember[i][0], ReceiptMember[i][1]);
                        }
                    }
                    command.Transaction = tx;
                    command.ExecuteNonQuery();
                }
                //// Update status cua Order

                tx.Commit();
                command.Dispose();
                result = true;
                pError = "";
                ReceiptID = ReceiptId;

            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                result = false;
                pError = "transaction_insert_Reciept with SP @ wrong is " + spName + " , Error is: "+ ex.Message;
            }
            finally
            {
                connection.Dispose();
            }
        }

        #region Tạo số ReceiptID
        private static string Tao_ReceiptID()
        {
            ///''11 [11] [YYMMDD] [000001]
            ///- [11] : Mã cửa hàng
            ///- [YYMMDD] : Ngày tháng năm tạo 
            ///- [000001]: số chạy
            string s_ngay, s_thang, s_nam;
            string s_stt, so_SoDDH;
            int ngay, thang, nam, stt;
            ngay = DateTime.Now.Day;
            if (ngay < 10)
                s_ngay = "0" + ngay.ToString();
            else
                s_ngay = ngay.ToString();
            thang = DateTime.Now.Month;
            if (thang < 10)
                s_thang = "0" + thang.ToString();
            else
                s_thang = thang.ToString();
            nam = DateTime.Now.Year;
            s_nam = (nam.ToString()).Substring(2);

            so_SoDDH = "11" + "01" + s_nam + s_thang + s_ngay;
            //MessageBox.Show(so_PX);
            // doc STT tu CSDL            
            stt = 0;
            string strErr = "";
            DataSet ds = new DataSet();
            string[][] prm = { new string[] { "p_ID", so_SoDDH } };
            DataStoreProcQuery_Param(GetConnectionString(), "spGet_ReceiptID", ref ds, prm, ref strErr);
            if (ds != null && ds.Tables.Count>0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow d = dt.Rows[i];
                        stt = int.Parse((d["Code"].ToString()).Substring(12));//////////////
                        if (stt != i + 1)
                        {
                            stt = i + 1;
                            break;
                        }
                    }
                    // MessageBox.Show(i.ToString());
                    if (i == dt.Rows.Count)
                    {
                        stt = dt.Rows.Count + 1;
                    }
                }
                else
                {
                    stt = 1;
                }
            }
            else
            {
                stt = 1;
            }
            if (stt < 10)
                s_stt = "00000" + stt.ToString();
            else if ((stt < 100) && (stt >= 10))
                s_stt = "0000" + stt.ToString();
            else if ((stt < 1000) && (stt >= 100))
                s_stt = "000" + stt.ToString();
            else if ((stt < 10000) && (stt >= 1000))
                s_stt = "00" + stt.ToString();
            else if ((stt < 100000) && (stt >= 10000))
                s_stt = "0" + stt.ToString();
            else
                s_stt = stt.ToString();

            so_SoDDH += s_stt;

            return so_SoDDH;
        }

        //Tao OrderId

        private static string CreateOrderid() {
            string _sOrderId = "";

            string strErr = "";
            DataSet ds = new DataSet();
            DataStoreProcQuery(GetConnectionString(), "spSelect_Orders", ref ds, ref strErr);
            if (string.IsNullOrEmpty(strErr) && ds.Tables[0].Rows.Count > 0)
            {
                _sOrderId = ds.Tables[0].Rows[0][0].ToString();
                Int64 iOrderId = Int64.Parse(_sOrderId) + 1;
                _sOrderId = iOrderId.ToString();
            }
            else _sOrderId = "10" + DateTime.Today.ToString("yyyyMMdd") + "00001";
            return _sOrderId;
        }

        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
                connectionString = "server=192.168.1.99;User Id=root;password=1234;database=pos_spa;Allow Zero Datetime=True;Convert Zero Datetime=True";

            return connectionString;
        }
        #endregion

        #region Image
        public static void SaveImage_IntoObject(string pConnectionString, byte[] pImageBuffer, string ObjectId, string OldImageName, ref string pError)
        {
            //sExtend = Extend;
            string path = HttpContext.Current.Server.MapPath("/") + "Image\\Users\\";
            if(OldImageName != null && OldImageName != ""){
                if (DeleteOldImage(path, OldImageName))
                {
                    ByteArrayToImageFilebyMemoryStream(pConnectionString, pImageBuffer, ObjectId, ref pError);
                }
                else
                    pError = "Can't delete old image ! ";
            }
            else ByteArrayToImageFilebyMemoryStream(pConnectionString, pImageBuffer, ObjectId, ref pError);
        }


        public static void SaveImage_IntoProduct(string pConnectionString, byte[] pImageBuffer, string ObjectId, string OldImageName, ref string pError)
        {
            string path = HttpContext.Current.Server.MapPath("/") + "Image\\Products\\";
            if (OldImageName != null && OldImageName != "")
            {
                if (DeleteOldImage(path, OldImageName))
                {
                    ByteArrayToImageFilebyMemoryStream_Product(pConnectionString, pImageBuffer, ObjectId, ref pError);
                }
                else
                    pError = "Can't delete old image ! ";
            }
            else ByteArrayToImageFilebyMemoryStream_Product(pConnectionString, pImageBuffer, ObjectId, ref pError);
        }
        public static void SaveImage_IntoEmployee(string pConnectionString, byte[] pImageBuffer, string EmployeeId, ref string pError)
        {
            ByteArrayToImageFilebyMemoryStreamEmployee(pConnectionString, pImageBuffer, EmployeeId, ref pError);
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static void ByteArrayToImageFilebyMemoryStream(string pConnectionString, byte[] imageByte, string ObjectId, ref string err)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageByte);
                Image image = Image.FromStream(ms);
                string imagName = ObjectId + "_" + DateTime.Now.ToString("yyMMddHHmmss") + ".jpg";
                string path = HttpContext.Current.Server.MapPath("/") + "Image\\Users\\" + imagName;

                ImageHandler.ResizeImg(image, 181, 220, 100, path);
                //image.Save(path, System.Drawing.Imaging.ImageFormat.Png);

                //// update vao DB
                string strQuery = "UPDATE `objects` SET `Image`='" + imagName + "' where `ObjectId`='" + ObjectId + "'";
                MySqlConnection connection = new MySqlConnection(pConnectionString);
                MySqlCommand command;
                connection.Open();
                command = new MySqlCommand(strQuery, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                err = e.Message.ToString();
            }
        }


        public static void ByteArrayToImageFilebyMemoryStream_Product(string pConnectionString, byte[] imageByte, string productId, ref string err)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageByte);
                Image image = Image.FromStream(ms);
                string imagName = productId + "_" + DateTime.Now.ToString("yyMMddHHmmss") + ".jpg";
                string path = HttpContext.Current.Server.MapPath("/") + "Image\\Products\\" + imagName;

                ImageHandler.ResizeImg(image, 181, 220, 100, path);
                //image.Save(path, System.Drawing.Imaging.ImageFormat.Png);

                //// update vao DB
                string strQuery = "UPDATE `products` SET `Image`='" + imagName + "' where `productId`='" + productId + "'";
                MySqlConnection connection = new MySqlConnection(pConnectionString);
                MySqlCommand command;
                connection.Open();
                command = new MySqlCommand(strQuery, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                err = e.Message.ToString();
            }
        }

        public static void ByteArrayToImageFilebyMemoryStreamEmployee(string pConnectionString, byte[] imageByte, string EmployeeId, ref string err)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageByte);
                Image image = Image.FromStream(ms);
                string imagName = EmployeeId + "_" + DateTime.Now.ToString("yyMMddHHmmss") + ".png";
                string path = HttpContext.Current.Server.MapPath("/") + "Image\\Users\\" + imagName;

                image.Save(path, System.Drawing.Imaging.ImageFormat.Png);

                //// update vao DB
                string strQuery = "UPDATE `employees` SET `Image`='" + imagName + "' where `EmployeeId`='" + EmployeeId + "'";
                MySqlConnection connection = new MySqlConnection(pConnectionString);
                MySqlCommand command;
                connection.Open();
                command = new MySqlCommand(strQuery, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                err = e.Message.ToString();
            }
        }

        #endregion

        #region Delete Old Image - Huỳnh Dung Create on 26/11/2014

        private static bool DeleteOldImage(string ImgPath, string ImgName) {
            bool res = false;
            if(ImgPath !="" && ImgName !=""){
                System.IO.File.Delete(ImgPath + ImgName);
            }
            res = true;
            return res;
        }

        #endregion

    }
}