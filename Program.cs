using System;
using IronXL;


namespace Excel_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            XLReader.Read_xl("C:\\Users\\Matthew\\source\repos\\Excel Practice\\example.xlsx");

            GeneralMethods.Close();

        }

    }
}
