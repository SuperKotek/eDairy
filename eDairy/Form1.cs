using eDairy.DesignClasses;
using eDairy.FunctionalClasses;

namespace eDairy
{
    public partial class eDairyForm : Form
    {
        int width;
        int height;
        bool isPanelOpnd;
        TextBox[] textBoxes;
        bool isRecordReadOnly = false;
        int buttonfunction;

        public eDairyForm()
        {
            InitializeComponent();

            width = this.Width;
            height = this.Height;

            eDairyStorage.Rows.Add("Кнопочка");
            eDairyStorage.Rows.Add("Кнепочка");
            eDairyStorage.Rows.Add("А это вообще что?");

            eDairyStorage.Columns[0].Width = eDairyStorage.Width;
            isPanelOpnd = false;
            buttonfunction = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            if (e.RowIndex == 0)
            {
                MessageBox.Show("Все остальное тож робит робит");
            }
            else if (e.RowIndex == 1)
            {
                MessageBox.Show("Все остальное тож робит робит");
            }
            else
                MessageBox.Show("Все остальное тож робит робит");
        }

        private void eDairyForm_SizeChanged(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            if (isPanelOpnd)
            { DesignHelper.DataGridPanelOpenFix(width, height, eDairyStorage, eDairyRecordPanel); }
            else
            { DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage); }
        }

        private void открытьПанельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPanelOpnd = true;
            InterfaceClass.OpenDairyRecord(width, eDairyStorage, eDairyRecordPanel, RecordNameTxtBox,
                RecordTxtBox, isRecordReadOnly);
            DesignHelper.DataGridPanelOpenFix(width, height, eDairyStorage, eDairyRecordPanel);
        }

        private void закрытьПанельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceClass.CloseDairyRecord(width, eDairyStorage, eDairyRecordPanel);
            DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage);
            isPanelOpnd = false;
        }

        private void создатьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonfunction = 1;
            if (!isPanelOpnd)
            {
                isPanelOpnd = true;
                InterfaceClass.OpenDairyRecord(width, eDairyStorage, eDairyRecordPanel, RecordNameTxtBox,
                    RecordTxtBox, isRecordReadOnly);
                DesignHelper.DataGridPanelOpenFix(width, height, eDairyStorage, eDairyRecordPanel);
            }
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (buttonfunction)
            {
                // Создание записи
                case 1:
                    {
                        string name = RecordNameTxtBox.Text;
                        string text = RecordTxtBox.Text;
                        string data1 = DateOnly.FromDateTime(DateTime.Now).ToString();
                        string data2 = DateOnly.FromDateTime(DateTime.Now).ToString();
                        string[] values = new string[] {name, text, data1, data2};
                        EdairyMainClass.CreateRecordFunction(values);
                        break;
                    }
                // Изменение записи
                case 2:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
