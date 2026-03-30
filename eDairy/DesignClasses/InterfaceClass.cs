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
            created_data.Text = record.CreatedAt;
            updated_data.Text = record.UpdatedAt;
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

        public static void RecordButtonClick()
        {

        }
    }
}
