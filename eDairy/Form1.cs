using eDairy.DesignClasses;
using eDairy.FunctionalClasses;

namespace eDairy
{
    public partial class eDairyForm : Form
    {
        int width;
        int height;
        bool isPanelOpnd;
        bool isRecordReadOnly = false;
        int buttonfunction;
        List<Records> eRecords;
        eDairyScapegoat eDairyDS = new eDairyScapegoat();

        public eDairyForm()
        {
            InitializeComponent();

            width = this.Width;
            height = this.Height;
            isPanelOpnd = false;
            buttonfunction = 0;

            eRecords = EdairyDBConnection.ReadFromExcel();
            foreach (Records record in eRecords)
            { eDairyDS.Insert(record); }
            DesignHelper.DataGridUpdater(eRecords, eDairyStorage);

            eDairyStorage.Columns[0].Width = eDairyStorage.Width;

            DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = eDairyStorage.CurrentCell.RowIndex;
            eDairyScapegoat scapegoat = new eDairyScapegoat();
            Records record = scapegoat.Search(index);
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

        private void îòêðûòüÏàíåëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPanelOpnd = true;
            InterfaceClass.OpenDairyRecord(width, eDairyStorage, eDairyRecordPanel, RecordNameTxtBox,
                RecordTxtBox, isRecordReadOnly);
            DesignHelper.DataGridPanelOpenFix(width, height, eDairyStorage, eDairyRecordPanel);
        }

        private void çàêðûòüÏàíåëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceClass.CloseDairyRecord(width, eDairyStorage, eDairyRecordPanel);
            DesignHelper.DataGridPanelCloseFix(width, height, eDairyStorage);
            isPanelOpnd = false;
        }

        private void ñîçäàòüÇàïèñüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void óäàëèòüÇàïèñüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            switch (buttonfunction)
            {
                // Ñîçäàíèå çàïèñè
                case 1:
                    {
                        Records record = new Records
                        {
                            Id = eRecords.Count+1,
                            Name = RecordNameTxtBox.Text,
                            Text = RecordTxtBox.Text,
                            CreatedAt = DateOnly.FromDateTime(DateTime.Now).ToString(),
                            UpdatedAt = DateOnly.FromDateTime(DateTime.Now).ToString()
                        };
                        EdairyDBConnection.InsertIntoExcel(record);
                        eDairyStorage.Rows.Add(record.Name);
                        break;
                    }
                // Èçìåíåíèå çàïèñè
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
