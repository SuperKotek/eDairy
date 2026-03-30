using System;
using System.Buffers;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy.FunctionalClasses
{
    public class EdairyDBConnection
    {
        private static string filePath = @"eDairyTable.xlsx";
        private static string sheetName = "table1";

        public static List<Records> ReadFromExcel()
        {
            List<Records> result = new List<Records>();

            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};" +
                $"Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [" + sheetName + "$]";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Records record = new Records
                            {
                                Name = reader["Name"].ToString(),
                                Text = reader["Text"].ToString(),
                                CreatedAt = reader["Created_Data"].ToString(),
                                UpdatedAt = reader["Updated_Data"].ToString()
                            };

                            result.Add(record);
                        }
                    }
                }
            }

            return result;
        }

        public static void InsertIntoExcel(Records record)
        {
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};" +
                $"Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [" + sheetName + @"$] VALUES (Name, Text, Created_Data, Updated_Data)";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Name", record.Name);
                    command.Parameters.AddWithValue("Text", record.Text);
                    command.Parameters.AddWithValue("Created_Data", record.CreatedAt);
                    command.Parameters.AddWithValue("Updated_Data", record.UpdatedAt);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
