using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Mnogookno
{
    public class ClassExcel
    {
        public static Excel.Application excelApp;
        public static Excel.Workbook excelBook;
        public static Excel.Worksheet excelSheet;
        public static Excel.Range excelCells;

        public static Excel.Range GetLastCells(string sheet)
        {
            excelSheet = (Excel.Worksheet)excelBook.Sheets[sheet];
            excelCells = excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            return (excelCells);
        }

        public static int GetCellsRow(Excel.Range range)
        {
            int count = range.Row;
            return count;
        }

        public static void GetCells(string sheet, int row, int column)
        {
            excelSheet = (Excel.Worksheet)excelBook.Sheets[sheet];
            excelCells = ClassExcel.excelSheet.Cells[row, column];
        }

        public static string GetCellsString(string sheet, int row, int column)
        {
            excelSheet = (Excel.Worksheet)excelBook.Sheets[sheet];
            excelCells = ClassExcel.excelSheet.Cells[row, column];
            return excelCells.Value2;
        }

        public static double GetCellsDouble(string sheet, int row, int column)
        {
            excelSheet = (Excel.Worksheet)excelBook.Sheets[sheet];
            excelCells = ClassExcel.excelSheet.Cells[row, column];
            double doub = Convert.ToDouble(excelCells.Value2);
            return doub;
        }

        public static bool CheckNullCell(string sheet, int row, int column, int length)
        {
            string check; bool chk = true;
            excelSheet = (Excel.Worksheet)excelBook.Sheets[sheet];
            for (int i=column; i<= length-1; i++)
            {
                excelCells = ClassExcel.excelSheet.Cells[row, i];
                try
                {
                    check = excelCells.Value2.ToString();
                }
                catch
                {
                    return false;
                }
                
                check.Replace(" ", String.Empty);
                if (check == "" || check is null)
                    chk = false;
            }
            return chk;
            
        }
    }
}
