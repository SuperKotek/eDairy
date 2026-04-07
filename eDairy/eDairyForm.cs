using eDairy.DesignClasses;
using eDairy.FunctionalClasses;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System;

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

            DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonfunction = 0;
            isRecordReadOnly = true;
            recordIndex = (int)eDairyStorage.Rows[e.RowIndex].Cells[0].Value;
            Records record = eDairyDS.SearchById(recordIndex);
            OpenPanel();
            InterfaceClass.PrintRecord(record, RecordNameTxtBox, RecordTxtBox, RecordCreateDataTxtBox, RecordUpdateDataTxtBox);
        }

        private void создатьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonfunction = 1;
            isRecordReadOnly = false;
            InterfaceClass.ClearRecordPanel(RecordNameTxtBox, RecordTxtBox, RecordCreateDataTxtBox, RecordUpdateDataTxtBox);
            OpenPanel();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recordIndex >= 0)
            {
                InterfaceClass.DeleteRecord(eDairyDS, eDairyStorage, recordIndex);
                recordIndex = -1;
                ClosePanel();
            }
            else
            { MessageBox.Show("Выберите запись для удаления!"); }
        }

        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recordIndex >= 0)
            {
                buttonfunction = 2;
                isRecordReadOnly = false;
                RecordUpdateDataTxtBox.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
                OpenPanel();
            }
            else
            { MessageBox.Show("Выберите запись для изменения!"); }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (buttonfunction)
            {
                // Создание записи
                case 1:
                    {
                        if (RecordNameTxtBox.Text == "")
                        { MessageBox.Show("Запись должна иметь название!"); }
                        else
                        {
                            if (RecordTxtBox.Text == "")
                            { RecordTxtBox.Text = "-"; }
                            InterfaceClass.CreateRecord(eDairyDS, eDairyStorage, RecordNameTxtBox, RecordTxtBox);
                            InterfaceClass.ClearRecordPanel(RecordNameTxtBox, RecordTxtBox, RecordCreateDataTxtBox, RecordUpdateDataTxtBox);
                        }
                        break;
                    }
                // Изменение записи
                case 2:
                    {
                        if (RecordNameTxtBox.Text == "")
                        { MessageBox.Show("Запись должна иметь название!"); }
                        else
                        {
                            if (RecordTxtBox.Text == "")
                            { RecordTxtBox.Text = "-"; }
                            InterfaceClass.UpdateRecord(eDairyDS, eDairyStorage, recordIndex, RecordNameTxtBox, RecordTxtBox);
                        }
                        isRecordReadOnly = true;
                        OpenPanel();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
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
