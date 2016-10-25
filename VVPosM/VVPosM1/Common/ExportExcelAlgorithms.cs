using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExcelCOM = Microsoft.Office.Interop.Excel;//Microsoft.Office.Tools.Excel
using Microsoft.CSharp.RuntimeBinder;
using System.Data;

namespace VVPosM1.Common
{
    class ExportExcelAlgorithms
    {
        /// <summary>
        /// Export file excel from datagridview
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="fileName"></param>
        public void ExportFileFromDataGridView(System.Windows.Forms.DataGridView dgv, string fileName)
        {
            //set properties for SaveFileDilog
            SaveFileDialog sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Excel file(*.xls)|*.xls";
            sfdSave.Title = "Save to Excel file";
            sfdSave.FileName = fileName;

            //proccess save file excel
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                //create file infomation
                FileInfo f = new FileInfo(sfdSave.FileName);
                //delete if file exists
                if (f.Exists == true) f.Delete();
                //Create excel file
                ExcelCOM.Application exApp = new ExcelCOM.Application();
                ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
                ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
                //ExcelCOM.Range chartRange;
                exSheet.Name = fileName;
                //get data from datagridview import into excel file
                //exSheet.Cells.FormatConditions

                //exSheet.get_Range("b2", "e3").Merge(false);

                //chartRange = exSheet.get_Range("b2", "e9");
                //chartRange.BorderAround(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);

                //xlWorkBook.SaveAs("csharp.net-informations.xls", ExcelCOM.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, ExcelCOM.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                //import header
                int col = 1;
                for (int i = 1; i <= dgv.ColumnCount; i++)
                {

                    exSheet.Cells[1, col] = dgv.Columns[i - 1].HeaderText;
                    col++;
                    //chartRange = exSheet.Cells[1, col];
                    //Font.Bold = true;


                }

                //import data
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    col = 1;
                    for (int j = 1; j < dgv.ColumnCount; j++)
                    {

                        exSheet.Cells[i + 2, col + 1] = dgv.Rows[i].Cells[j].Value.ToString();

                        col++;

                        //chartRange.Cells.Formula


                    }
                }

                //(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);
                //chartRange.BorderAround(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);
                exApp.Visible = false;
                //Save file excel into dictionary that you choose
                exBook.SaveAs(sfdSave.FileName, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                    null, null, false, false,
                    ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                    false, false, false, false, false);

                //close and release object
                exBook.Close(false, false, false);
                exApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM385"),
                           Common.clsLanguages.GetResource("CRM11"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        public void ExportFileFromDataTable(DataTable dt, string fileName)
        {
            //set properties for SaveFileDilog
            SaveFileDialog sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Excel file(*.xls)|*.xls";
            sfdSave.Title = "Save to Excel file";
            sfdSave.FileName = fileName;

            //proccess save file excel
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                //create file infomation
                FileInfo f = new FileInfo(sfdSave.FileName);
                //delete if file exists
                if (f.Exists == true) f.Delete();
                //Create excel file
                ExcelCOM.Application exApp = new ExcelCOM.Application();
                ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
                ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
                //ExcelCOM.Range chartRange;
                exSheet.Name = fileName;
                //get data from datagridview import into excel file
                //exSheet.Cells.FormatConditions

                //exSheet.get_Range("b2", "e3").Merge(false);

                //chartRange = exSheet.get_Range("b2", "e9");
                //chartRange.BorderAround(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);

                //xlWorkBook.SaveAs("csharp.net-informations.xls", ExcelCOM.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, ExcelCOM.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                //import header
                int col = 1;
                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    exSheet.Cells[1, col] = dt.Columns[i].Caption;
                    col++;
                    //chartRange = exSheet.Cells[1, col];
                    //Font.Bold = true;


                }

                //import data
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    col = 1;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        exSheet.Cells[i + 2, col].NumberFormat = "@";
                        exSheet.Cells[i + 2, col] = dt.Rows[i][j].ToString();

                        col++;

                        //chartRange.Cells.Formula


                    }
                }

                //(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);
                //chartRange.BorderAround(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);
                exApp.Visible = false;
                //Save file excel into dictionary that you choose
                exBook.SaveAs(sfdSave.FileName, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                    null, null, false, false,
                    ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                    false, false, false, false, false);

                //close and release object
                exBook.Close(false, false, false);
                exApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

                MessageBox.Show(Common.clsLanguages.GetResource("CRMExcelExport"));
                //CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.RM.GetString("00385"),
                //            Common.clsLanguages.RM.GetString("00011"),
                //            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                //            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        /// <summary>
        /// Export file excel from datagridview - Created by Huynh Dung - ố ồ
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="fileName"></param>
        public void ExportFileFromDataGridView_Dung(System.Windows.Forms.DataGridView dgv, string fileName, string title)
        {
            //set properties for SaveFileDilog
            SaveFileDialog sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Excel file(*.xls)|*.xls";
            sfdSave.Title = "Save to Excel file";
            sfdSave.FileName = fileName;

            //proccess save file excel
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                //create file infomation
                FileInfo f = new FileInfo(sfdSave.FileName);
                //delete if file exists
                if (f.Exists == true) f.Delete();
                //Create excel file
                ExcelCOM.Application exApp = new ExcelCOM.Application();
                ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
                ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
                //Microsoft.Office.Interop.Excel.Range excelCellrange;
                ExcelCOM.Range excelCellrange;
                exSheet.Name = fileName;
               
                //import Caption
                excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, dgv.ColumnCount]];
                exSheet.get_Range((object)exSheet.Cells[1, 1], (object)exSheet.Cells[1, dgv.ColumnCount]).Merge(false);
                excelCellrange = exSheet.get_Range((object)exSheet.Cells[1, 1], (object)exSheet.Cells[1, dgv.ColumnCount]);
                excelCellrange.FormulaR1C1 = title;
                excelCellrange.HorizontalAlignment = 3;
                excelCellrange.VerticalAlignment = 3;

                excelCellrange = exSheet.Range[exSheet.Cells[2, 1], exSheet.Cells[dgv.RowCount + 2, dgv.ColumnCount]];
                excelCellrange.NumberFormat = "@";
                //import header
                int col = 1;
                for (int i = 1; i <= dgv.ColumnCount; i++)
                {

                    exSheet.Cells[2, col] = dgv.Columns[i - 1].HeaderText;
                    col++;
                    //chartRange = exSheet.Cells[1, col];
                    //Font.Bold = true;


                }

                //import data
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    col = 1;
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {

                        if (i != 0)
                        {
                            if ((dgv.Rows[i - 1].Cells[j].Value.ToString() == dgv.Rows[i].Cells[j].Value.ToString()) && (col == 1 || col == 2 || col == 3))
                            {
                                exSheet.get_Range((object)exSheet.Cells[i + 2, col], (object)exSheet.Cells[i + 3, col]).Merge(Type.Missing);
                                exSheet.Cells[i + 3, col] = dgv.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                exSheet.Cells[i + 3, col] = dgv.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        else
                        {
                            exSheet.Cells[i + 3, col] = dgv.Rows[i].Cells[j].Value.ToString();
                        }

                        col++;

                        //chartRange.Cells.Formula


                    }
                }
                //

                // now we resize the columns
                excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[dgv.RowCount + 2, dgv.ColumnCount]];
                excelCellrange.EntireColumn.AutoFit();

                //excelCellrange.OutlineLevel = 2;
                //excelCellrange.Group(Type.Missing, Type.Missing, Type.Missing, Type.Missing);


                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;


                //excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, dgv.ColumnCount]];
                //FormattingExcelCells(excelCellrange, "#f5f5f5", System.Drawing.Color.DarkBlue, true);

                //excelCellrange = exSheet.Range[exSheet.Cells[2, 1], exSheet.Cells[2, dgv.ColumnCount]];
                //FormattingExcelCells(excelCellrange, "#0488a1", System.Drawing.Color.White, true);

                exApp.Visible = false;
                //
                //exBook = ActiveWorkbook;
                exBook.CheckCompatibility = false;
                //Save file excel into dictionary that you choose
                exBook.SaveAs(sfdSave.FileName, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                    null, null, false, false,
                    ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                    false, false, false, false, false);

                //close and release object
                exBook.Close(false, false, false);
                exApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRMFileExportSuccess"),
                            Common.clsLanguages.GetResource("CRMInformation"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        public void ExportFileFromDataTable_Dung(DataTable dt, string fileName, string title, string[] prm)
        {
            //set properties for SaveFileDilog
            SaveFileDialog sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Excel file(*.xls)|*.xls";
            sfdSave.Title = "Save to Excel file";
            sfdSave.FileName = fileName;

            //proccess save file excel
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                //create file infomation
                FileInfo f = new FileInfo(sfdSave.FileName);
                //delete if file exists
                if (f.Exists == true) f.Delete();
                //Create excel file
                ExcelCOM.Application exApp = new ExcelCOM.Application();
                ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
                ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
                //Microsoft.Office.Interop.Excel.Range excelCellrange;
                ExcelCOM.Range excelCellrange;
                exSheet.Name = fileName;
            
                //import Caption
                excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, dt.Columns.Count]];
                exSheet.get_Range((object)exSheet.Cells[1, 1], (object)exSheet.Cells[1, dt.Columns.Count]).Merge(false);
                excelCellrange = exSheet.get_Range((object)exSheet.Cells[1, 1], (object)exSheet.Cells[1, dt.Columns.Count]);
                excelCellrange.FormulaR1C1 = title;
                excelCellrange.HorizontalAlignment = 3;
                excelCellrange.VerticalAlignment = 3;

                excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[dt.Rows.Count + 2, dt.Columns.Count]];
                excelCellrange.NumberFormat = "@";
                //import header
                int col = 1;
                for (int i = 1; i <= dt.Columns.Count; i++)
                {

                    exSheet.Cells[2, col] = dt.Columns[i - 1].Caption;
                    col++;
                }

                //import data
                //int row = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //row++;
                    col = 1;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if(prm != null){
                            bool has = Array.IndexOf(prm, col.ToString()) >= 0;
                            if (has)
                            {
                                excelCellrange = exSheet.Range[exSheet.Cells[i + 3, col], exSheet.Cells[i + 3, col]];
                                excelCellrange.NumberFormat = "#,##0.00";
                                exSheet.Cells[i + 3, col] = double.Parse(dt.Rows[i][j].ToString()).ToString(); 
                            }
                            else {
                                //exSheet.Cells[i + 3, col].NumberFormat = "@";
                                exSheet.Cells[i + 3, col] = dt.Rows[i][j].ToString();
                            }
                        }
                        else {
                          //  exSheet.Cells[i + 3, col].NumberFormat = "@";
                            exSheet.Cells[i + 3, col] = dt.Rows[i][j].ToString();
                        }
                        col++;
                    }
                }

                // now we resize the columns
                excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[dt.Rows.Count + 2, dt.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();

                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                //excelCellrange = exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, dt.Columns.Count]];
                //FormattingExcelCells(excelCellrange, "#f5f5f5", System.Drawing.Color.DarkBlue, true);

                //excelCellrange = exSheet.Range[exSheet.Cells[2, 1], exSheet.Cells[2, dt.Columns.Count]];
                //FormattingExcelCells(excelCellrange, "#0488a1", System.Drawing.Color.White, true);

                exApp.Visible = false;
                //
                //exBook.CheckCompatibility = false;
                //Save file excel into dictionary that you choose
                exBook.SaveAs(sfdSave.FileName, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                    null, null, false, false,
                    ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                    false, false, false, false, false);

                //close and release object
                exBook.Close(false, false, false);
                exApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("ExcelExport"),
                            Common.clsLanguages.GetResource("Information"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }

        /// <summary>
        /// FUNCTION FOR FORMATTING EXCEL CELLS - Created by Huynh Dung - ố ồ
        /// </summary>
        /// <param name="range"></param>
        /// <param name="HTMLcolorCode"></param>
        /// <param name="fontColor"></param>
        /// <param name="IsFontbool"></param>
        public void FormattingExcelCells(ExcelCOM.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }

        public void ExportFileFromDataGridViewEmployee(System.Windows.Forms.DataGridView dgv, string fileName)
        {
            //set properties for SaveFileDilog
            SaveFileDialog sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Excel file(*.xls)|*.xls";
            sfdSave.Title = "Save to Excel file";
            sfdSave.FileName = fileName;

            //proccess save file excel
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                //create file infomation
                FileInfo f = new FileInfo(sfdSave.FileName);
                //delete if file exists
                if (f.Exists == true) f.Delete();
                //Create excel file
                ExcelCOM.Application exApp = new ExcelCOM.Application();
                ExcelCOM.Workbook exBook = exApp.Workbooks.Add(ExcelCOM.XlWBATemplate.xlWBATWorksheet);
                ExcelCOM.Worksheet exSheet = (ExcelCOM.Worksheet)exBook.Worksheets[1];
                //ExcelCOM.Range chartRange;
                exSheet.Name = fileName;

                //list field will be exported
                List<string> field = new List<string> { "EmployeeCode", "EmployeeName", "UserName", "Gender", "BirthDate", "PhoneNumber", "Email", "Address", "EmployeeTypeName", "CountryName", "EmployeeTypeName2", "CountryName2", "EmployeeTypeName3", "CountryName3", "HourlyWages", "CreatedDate", "UpdatedDate", "Notes" };

                //import header
                int col = 1;
                for (int i = 0; i < field.Count; i++)
                {
                    exSheet.Cells[1, col] = dgv.Columns[field[i]].HeaderText;
                    col++;
                }

                //import data
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    col = 1;
                    for (int j = 0; j < field.Count; j++)
                    {
                        exSheet.Cells[i + 2, col] = dgv.Rows[i].Cells[field[j]].Value.ToString();
                        col++;
                    }
                }

                //(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);
                //chartRange.BorderAround(ExcelCOM.XlLineStyle.xlContinuous, ExcelCOM.XlBorderWeight.xlMedium, ExcelCOM.XlColorIndex.xlColorIndexAutomatic, ExcelCOM.XlColorIndex.xlColorIndexAutomatic);
                exApp.Visible = false;
                //Save file excel into dictionary that you choose
                exBook.SaveAs(sfdSave.FileName, ExcelCOM.XlFileFormat.xlWorkbookNormal,
                    null, null, false, false,
                    ExcelCOM.XlSaveAsAccessMode.xlExclusive,
                    false, false, false, false, false);

                //close and release object
                exBook.Close(false, false, false);
                exApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

                CustomMessageBox.MessageBox.ShowCustomMessageBox(Common.clsLanguages.GetResource("CRM385"),
                            Common.clsLanguages.GetResource("CRM11"),
                            Common.Config.CUSTOM_MESSAGEBOX_ICON.Information,
                            Common.Config.CUSTOM_MESSAGEBOX_BUTTON.OK);
            }
        }
    }
}
