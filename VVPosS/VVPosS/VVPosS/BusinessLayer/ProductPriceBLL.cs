using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVPosS.Entities;
using System.Data;
using System.Configuration;

namespace VVPosS.BusinessLayer
{
    public class ProductPriceBLL:IObjectBLL<ProductPrice>
    {

        private string errorString = "";

        public string ErrorString
        {
            get { return errorString; }
            set { errorString = value; }
        }

        /// <summary>
        /// Get list products
        /// </summary>
        /// <returns></returns>
        public DataTable GetProductsPriceByProductId(string sProductId)
        {
            DataTable res = new DataTable(); 
            string query = @"SELECT `productprice`.`Price`
                            FROM `productprice`
                            WHERE `productprice`.`ProductId` = '"+sProductId+"'";
                   query += @" ORDER BY `productprice`.`Time` DESC
                            LIMIT 0,1 ";
            DataSet dataset = new DataSet();
            Program.destopService.DataQuery(Program.Username, Program.Password, query, ref dataset, "ProductPrice", ref errorString);

            if (string.IsNullOrEmpty(errorString))
            {
                res = dataset.Tables["ProductPrice"];
            }
            else
            {
                res = null;
            }
            return res;
        }
    }
}
