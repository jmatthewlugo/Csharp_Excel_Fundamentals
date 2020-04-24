using System;
using System.Collections.Generic;
using System.Text;
using IronXL;
using System.Linq;

namespace Excel_Practice
{
    class XLReader
    {
        public static void Read_xl(string filepath)
        {
            var workbook = WorkBook.Load(filepath);
            var sheet = workbook.WorkSheets.First() ;
            var range = sheet["A2:A4"];

            foreach (var cell in range)
            {
                Console.WriteLine(cell.Value);

            }

        }
    }
}
