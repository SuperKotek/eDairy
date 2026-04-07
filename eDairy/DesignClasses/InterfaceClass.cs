using eDairy.FunctionalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDairy.DesignClasses
{
    public class InterfaceClass
    {

        public static void PrintRecord(Records record, TextBox name, RichTextBox text, 
            TextBox created_data, TextBox updated_data)
        {
            name.Text = record.Name;
            text.Text = record.Text;
            created_data.Text = record.Created_Data;
            updated_data.Text = record.Updated_Data;
        }

        public static void ClearRecordPanel(TextBox name, RichTextBox text,
            TextBox created_data, TextBox updated_data)
        {
            name.Text = "";
            text.Text = "";
            created_data.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
            updated_data.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
        }

        public static void OpenDairyRecord(int width, DataGridView grid, Panel panel, 
            TextBox textname, RichTextBox text, bool isRecordReadOnly)
        {
            grid.Location = new Point(width / 2 - 9, 31);
            grid.Width = width / 2 - 21;
            panel.Show();
            if (isRecordReadOnly)
            {
                textname.ReadOnly = true;
                text.ReadOnly = true;
            }
            else
            {
                textname.ReadOnly = false;
                text.ReadOnly = false;
            }
        }

        public static void CloseDairyRecord(int width, DataGridView grid, Panel panel)
        {
            panel.Hide();
            grid.Width = width - 42;
            grid.Location = new Point(12, 31);
        }
        
        public static void DataGridUpdater(eDairyScapegoat eRecords, DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (Records record in eRecords.GetAll())
            { grid.Rows.Add(record.ID, record.Name); }
        }

        // Основные функции приложения

        public static void CreateRecord(eDairyScapegoat eRecords, DataGridView grid,
            TextBox name, RichTextBox text)
        {
            Records record = new Records
            {
                ID = eRecords.GetNextId(),
                Name = name.Text,
                Text = text.Text,
                Created_Data = DateOnly.FromDateTime(DateTime.Now).ToString(),
                Updated_Data = DateOnly.FromDateTime(DateTime.Now).ToString()
            };
            eRecords.Insert(record);
            EdairyDBConnection.SaveTreeToExcel(eRecords);
            grid.Rows.Add(record.ID, record.Name);
        }

        public static void DeleteRecord(eDairyScapegoat eRecords, DataGridView grid, int index)
        {
            Records record = eRecords.SearchById(index);
            DeleteForm deleteForm = new DeleteForm(record);
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                eRecords.Delete(index);
                EdairyDBConnection.SaveTreeToExcel(eRecords);
                InterfaceClass.DataGridUpdater(eRecords, grid);
            }
        }

        public static void UpdateRecord(eDairyScapegoat eRecords, DataGridView grid, int index,
            TextBox name, RichTextBox text)
        {
            string newName = name.Text;
            string newText = text.Text;
            string Updated_Data = DateOnly.FromDateTime(DateTime.Now).ToString();
            eRecords.Update(index, newName, newText, Updated_Data);
            EdairyDBConnection.SaveTreeToExcel(eRecords);
            InterfaceClass.DataGridUpdater(eRecords, grid);
        }
    }
}
