using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy.FunctionalClasses
{
    public class EdairyMainClass
    {
        private static string filePath = @"eDairyTable.xlsx";
        private static string sheetName = "table1";

        public static void CreateRecordFunction(string[] values)
        {
            EdairyBDConnection.CreateRecordInBD(filePath, sheetName, values);

        }

        public static void DeleteRecordFunction()
        {

        }

        public static void SearchRecordFunction()
        {

        }
    }
}
