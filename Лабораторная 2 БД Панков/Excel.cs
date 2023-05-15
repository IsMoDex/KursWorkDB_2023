using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;
namespace Лабораторная_2_БД_Панков
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        
        public Excel(string _path, int Sheet)
        {
            this.path = _path;

            if(File.Exists(this.path))
                wb = excel.Workbooks.Open(path);
            else
                wb = excel.Workbooks.Add();

            ws = wb.Worksheets[Sheet];
        }

        public string ReadCell(int i, int j)
        {
            if (ws.Cells[++i, ++j].Value2 != null) 
                return ws.Cells[i, j].Value2;

            return "";
        }

        public void WriteToCell(int i, int j, string value)
        {
            ws.Cells[++i, ++j].Value2 = value;
        }

        public void WriteRange(int start_i, int start_j, int end_i, int end_j, string[,] array)
        {
            Range range = ws.Range[ws.Cells[++start_i, ++start_j], ws.Cells[++end_i, ++end_j]];
            range.Value2 = array;
        }

        public void WriteDT(DataTable dt, string WorksheetName) //System.Data.
        {
            wb.Worksheets.Add(dt, WorksheetName);
        }

        public void Save()
        {
            if (File.Exists(this.path))
                wb.Save();
            else
                SaveAs(this.path);
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void Close()
        {
            wb.Close();
        }

        public void AddList()
        {
            AddLists(1);
        }

        public void AddLists(int Count)
        {
            for(int i = 0; i <= Count; ++i)
            {
                wb.Worksheets.Add(After: wb.Worksheets[wb.Worksheets.Count]);
            }
        }

        public void SelectWorkSheet(int SheetNumber)
        {
            this.ws = wb.Worksheets[++SheetNumber];
        }

        public void DeleteWorkSheet(int SheetNumber)
        {
            wb.Worksheets[SheetNumber].Delete();
        }

    }
}
