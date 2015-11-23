using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

using System.Windows.Forms;
using System.Management;

namespace TimingSystem.Utility
{
    public class ExcelWriter
    {
        public static void Write(List<DataTable> workSheets, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            xlApp.DisplayAlerts = false;
            xlApp.AlertBeforeOverwriting = false;
            xlApp.DefaultFilePath = Environment.CurrentDirectory;

            xlApp.ScreenUpdating = false;
            CultureInfo CurrentCI = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Workbooks workbooks = xlApp.Workbooks;
            Workbook workbook = workbooks.Add();
            Sheets _workSheets = (Sheets)workbook.Worksheets; 
          
            try
            {
                int workSheetCount = _workSheets.Count;
                int workSheetToBeAddedCount = workSheets.Count - workSheetCount;
                if (workSheetToBeAddedCount > 0)
                {
                    for (int z = 0; z < workSheetToBeAddedCount; z++)
                    {
                        Worksheet worksheet = (Worksheet)_workSheets.Add();
                    }
                }

                for (int a = 0; a < workSheets.Count; a++)
                {
                    Worksheet worksheet = (Worksheet)workbook.Worksheets[a + 1];
                    worksheet.EnableCalculation = false;
                    if (!string.IsNullOrEmpty(workSheets[a].TableName))
                        worksheet.Name = workSheets[a].TableName;

                    for (int i = 0; i < workSheets[a].Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = workSheets[a].Columns[i].ColumnName;
                        Range range = (Range)worksheet.Cells[1, i + 1];
                        range.Interior.ColorIndex = 15;
                        range.Font.Bold = true;
                        range.EntireColumn.AutoFit();
                    }

                    //Get dimensions of the 2-d array 
                    int rowCount = workSheets[a].Rows.Count;
                    if (rowCount > 0)
                    {
                        int columnCount = workSheets[a].Columns.Count;
                        string[,] array = new string[rowCount, columnCount];

                        for (int s = 0; s < rowCount; s++)
                        {
                            for (int s2 = 0; s2 < columnCount; s2++)
                            {
                                array[s, s2] = workSheets[a].Rows[s][s2].ToString();
                            }
                        }

                        // Get an Excel Range of the same dimensions 
                        Range range2 = (Range)worksheet.Cells[2, 1];
                        range2 = range2.get_Resize(rowCount, columnCount);
                        // Assign the 2-d array to the Excel Range 
                        range2.set_Value(XlRangeValueDataType.xlRangeValueDefault, array);
                    }

                }
                workbook.SaveCopyAs(filePath);
            }
            finally
            {
                try
                {
                    xlApp.ScreenUpdating = true;
                    xlApp.Quit();
                }
                catch
                {
                    //supress
                }

                //KillProcess(xlApp);
            }

        }

        public static void OutDataToExcel(System.Data.DataTable srcDataTable, string excelFilePath)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            object missing = System.Reflection.Missing.Value;

            //导出到execl   
            try
            {
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能您的电脑未安装Excel!");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbooks xlBooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook xlBook = xlBooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlBook.Worksheets[1];

                //让后台执行设置为不可见，为true的话会看到打开一个Excel，然后数据在往里写  
                xlApp.Visible = false;

                object[,] objData = new object[srcDataTable.Rows.Count + 1, srcDataTable.Columns.Count];
                //首先将数据写入到一个二维数组中  
                for (int i = 0; i < srcDataTable.Columns.Count; i++)
                {
                    objData[0, i] = srcDataTable.Columns[i].ColumnName;
                }
                if (srcDataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < srcDataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < srcDataTable.Columns.Count; j++)
                        {
                            objData[i + 1, j] = srcDataTable.Rows[i][j];
                        }
                    }
                }

                string startCol = "A";
                int iCnt = (srcDataTable.Columns.Count / 26);
                string endColSignal = (iCnt == 0 ? "" : ((char)('A' + (iCnt - 1))).ToString());
                string endCol = endColSignal + ((char)('A' + srcDataTable.Columns.Count - iCnt * 26 - 1)).ToString();
                Microsoft.Office.Interop.Excel.Range range = xlSheet.get_Range(startCol + "1", endCol + (srcDataTable.Rows.Count - iCnt * 26 + 1).ToString());

                range.Value = objData; //给Exccel中的Range整体赋值  
                range.EntireColumn.AutoFit(); //设定Excel列宽度自适应  
                xlSheet.get_Range(startCol + "1", endCol + "1").Font.Bold = 1;//Excel文件列名 字体设定为Bold  

                //设置禁止弹出保存和覆盖的询问提示框  
                xlApp.DisplayAlerts = false;
                xlApp.AlertBeforeOverwriting = false;

                if (xlSheet != null)
                {
                    xlBook.SaveCopyAs(excelFilePath);
                    xlApp.Quit();  
                    //KillProcess(xlApp);
                }
            }
            catch (Exception ex)
            {
                //KillProcess(xlApp);
                throw ex;
            }


        }

    }


}
