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
        private static string sheetNameFuse = "table2";
        private static string GetConnString(string filePath) =>
        $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties=""Excel 12.0 Xml;HDR=YES;""";

        public static eDairyScapegoat ReadFromExcel()
        {
            eDairyScapegoat result = new eDairyScapegoat();

            string connectionString = GetConnString(filePath);

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
                                ID = int.Parse(reader["ID"].ToString()),
                                Name = reader["Name"].ToString(),
                                Text = reader["Text"].ToString(),
                                Created_Data = reader["Created_Data"].ToString(),
                                Updated_Data = reader["Updated_Data"].ToString()
                            };

                            result.Insert(record);
                        }
                    }
                }
            }

            return result;
        }

        public static void SaveTreeToExcel(eDairyScapegoat tree)
        {
            List<Records> allRecords = tree.GetAll();
            try 
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                SaveTreeFunction(allRecords, sheetName);
            }
            catch (Exception e)
            {
                SaveTreeFunction(allRecords, sheetNameFuse);
                throw new Exception($"Возникла ошибка: {e.Message}. Восстановите сохраненную таблицу");
            }
        }
        
        private static void SaveTreeFunction(List<Records> allRecords, string sheet)
        {
            string connectionString = GetConnString(filePath);

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                string createTableSql = "CREATE TABLE [" + sheet + "] ([Id] INT, [Name] LONGTEXT, [Text] LONGTEXT, " +
                    "[Created_Data] VARCHAR(20), [Updated_Data] VARCHAR(20))";
                using (OleDbCommand cmd = new OleDbCommand(createTableSql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                foreach (Records record in allRecords)
                {
                    string insertSql = "INSERT INTO [" + sheet + "] ([Id], [Name], [Text], [Created_Data], " +
                        "[Updated_Data]) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand insCmd = new OleDbCommand(insertSql, conn))
                    {
                        insCmd.Parameters.AddWithValue("?", record.ID);
                        insCmd.Parameters.AddWithValue("?", record.Name ?? "");
                        insCmd.Parameters.AddWithValue("?", record.Text ?? "");
                        insCmd.Parameters.AddWithValue("?", record.Created_Data ?? "");
                        insCmd.Parameters.AddWithValue("?", record.Updated_Data ?? "");

                        insCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
