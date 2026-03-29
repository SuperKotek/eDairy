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
    internal class EdairyBDConnection
    {
        public static string[] ReadRecordInBD(string filePath, string sheetName, string columnName, string searchValue)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + $"Data Source={filePath};" +
                                      "Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Формируем запрос
                string query = $"SELECT * FROM [{sheetName}$] WHERE [{columnName}] = @searchValue";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Добавляем параметр (защита от SQL-инъекций и проблем с типами)
                    command.Parameters.AddWithValue("@searchValue", searchValue);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Создаём DataTable для одной строки или работаем напрямую с reader
                            DataTable result = new DataTable();
                            result.Load(reader);
                            string[] values = [ result.Rows[0][0].ToString(), result.Rows[0][1].ToString(),
                            result.Rows[0][2].ToString(), result.Rows[0][3].ToString()];
                            return values;
                        }
                        else
                        {
                            return null; // Строка не найдена
                        }
                    }
                }
            }
        }

        public static string[] ReadAllRecordsNameInBD(string filePath, string sheetName, string columnName, string searchValue)
        {
            List<string> values = new List<string>();

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + $"Data Source={filePath};" +
                                      "Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT [{columnName}] FROM [{sheetName}$]";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Получаем значение, пропускаем NULL
                        string value = reader[0].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            values.Add(value);
                        }
                    }
                }
            }

            return values.ToArray();
        }

        public static void CreateRecordInBD(string filePath, string sheetName, string[] values)
        {
            try
            {
                string connectionPath;
                connectionPath = @"Provider=Microsoft.ACE.OLEDB.12.0;" + $"Data Source={filePath};" +
                          "Extended Properties='Excel 12.0;HDR=YES'";

                using (OleDbConnection connection = new OleDbConnection(connectionPath))
                {
                    connection.Open();

                    string query = $"INSERT INTO [{sheetName}$] VALUES (@val1, @val2, @val3, @val4)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@val1", values[0]); // Название записи
                        command.Parameters.AddWithValue("@val2", values[1]); // Текст Записи
                        command.Parameters.AddWithValue("@val3", values[2]); // Дата создания
                        command.Parameters.AddWithValue("@val4", values[3]); // Дата изменения

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        // Подправить для изменения всей записи
        public static void UpdateRecordInBD(string filePath, string sheetName, string columnToUpdate, 
                                    string newValue, string conditionColumn, string conditionValue)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + $"Data Source={filePath};" +
                                      "Extended Properties='Excel 12.0;HDR=YES'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE [{sheetName}$] SET [{columnToUpdate}] = @newValue " +
                              $"WHERE [{conditionColumn}] = @condition";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@condition", conditionValue);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteRecordInBD(string filePath, string sheetName, string conditionColumn, string conditionValue)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + $"Data Source={filePath};" +
                                      "Extended Properties='Excel 12.0;HDR=YES'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM [{sheetName}$] WHERE [{conditionColumn}] = @condition";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@condition", conditionValue);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
