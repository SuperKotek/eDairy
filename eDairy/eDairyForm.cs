using eDairy.DesignClasses;
using eDairy.FunctionalClasses;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace eDairy
{
    public partial class eDairyForm : Form
    {
        int width;
        int height;
        bool isPanelOpnd;
        bool isRecordReadOnly = false;
        int buttonfunction;
        int recordIndex = -1;

        eDairyScapegoat eDairyDS = new eDairyScapegoat();

        public eDairyForm()
        {
            InitializeComponent();

            width = this.Width;
            height = this.Height;
            isPanelOpnd = false;
            buttonfunction = 0;

            eDairyDS = EdairyDBConnection.ReadFromExcel();
            InterfaceClass.DataGridUpdater(eDairyDS, eDairyStorage);

            eDairyStorage.Columns[0].Width = eDairyStorage.Width;

            DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isRecordReadOnly = true;
            recordIndex = eDairyStorage.CurrentCell.RowIndex;
            Records record = eDairyDS.SearchById(recordIndex);
            OpenPanel();
            InterfaceClass.PrintRecord(record, RecordNameTxtBox, RecordTxtBox, RecordCreateDataTxtBox, RecordChangeDataTxtBox);
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
            isRecordReadOnly = false;
            InterfaceClass.ClearRecordPanel(RecordNameTxtBox, RecordTxtBox, RecordCreateDataTxtBox, RecordChangeDataTxtBox);
            OpenPanel();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recordIndex >= 0)
            {
                Records record = eDairyDS.SearchById(recordIndex);
                DeleteForm deleteForm = new DeleteForm(record);
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    eDairyDS.Delete(recordIndex);
                }
            }
            else
            { MessageBox.Show("Выберите запись для удаления!"); }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (buttonfunction)
            {
                // Создание записи
                case 1:
                    {
                        InterfaceClass.CreateRecord(eDairyDS, eDairyStorage, RecordNameTxtBox, RecordTxtBox);
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
            buttonfunction = 0;
        }



        private void OpenPanel()
        {
            if (!isPanelOpnd)
            {
                isPanelOpnd = true;
                InterfaceClass.OpenDairyRecord(width, eDairyStorage, eDairyRecordPanel, RecordNameTxtBox,
                    RecordTxtBox, isRecordReadOnly);
                DesignHelper.DataGridPanelOpenFix(width, height, eDairyStorage, eDairyRecordPanel);
            }
            if (isRecordReadOnly)
            {
                RecordNameTxtBox.ReadOnly = true;
                RecordTxtBox.ReadOnly = true;
                mainButton.Enabled = false;
            }
            else
            {
                RecordNameTxtBox.ReadOnly = false;
                RecordTxtBox.ReadOnly = false;
                mainButton.Enabled = true;
            }
        }

        private void ClosePanel()
        {
            if (isPanelOpnd)
            {
                isPanelOpnd = false;
                InterfaceClass.CloseDairyRecord(width, eDairyStorage, eDairyRecordPanel);
                DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage);
            }
        }
    }
}
