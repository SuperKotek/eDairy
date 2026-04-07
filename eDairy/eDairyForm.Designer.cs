using eDairy.FunctionalClasses;

namespace eDairy
{
    partial class eDairyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            инструментарийToolStripMenuItem = new ToolStripMenuItem();
            создатьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            изменитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            найтиЗаписьToolStripMenuItem = new ToolStripMenuItem();
            создатьОтчетToolStripMenuItem = new ToolStripMenuItem();
            текстовыйФайлToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            eDairyStorage = new DataGridView();
            eDairyRecordPanel = new Panel();
            mainButton = new Button();
            RecordTxtBox = new RichTextBox();
            RecordNameLabel = new Label();
            RecordChangeDataLabel = new Label();
            RecordCreateDataLabel = new Label();
            RecordUpdateDataTxtBox = new TextBox();
            RecordCreateDataTxtBox = new TextBox();
            RecordNameTxtBox = new TextBox();
            id = new DataGridViewTextBoxColumn();
            DNotes = new DataGridViewButtonColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eDairyStorage).BeginInit();
            eDairyRecordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { инструментарийToolStripMenuItem, создатьОтчетToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(768, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // инструментарийToolStripMenuItem
            // 
            инструментарийToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьЗаписьToolStripMenuItem, удалитьЗаписьToolStripMenuItem, изменитьЗаписьToolStripMenuItem, найтиЗаписьToolStripMenuItem });
            инструментарийToolStripMenuItem.Name = "инструментарийToolStripMenuItem";
            инструментарийToolStripMenuItem.Size = new Size(113, 20);
            инструментарийToolStripMenuItem.Text = "Инструментарий";
            // 
            // создатьЗаписьToolStripMenuItem
            // 
            создатьЗаписьToolStripMenuItem.Name = "создатьЗаписьToolStripMenuItem";
            создатьЗаписьToolStripMenuItem.Size = new Size(168, 22);
            создатьЗаписьToolStripMenuItem.Text = "Создать запись";
            создатьЗаписьToolStripMenuItem.Click += создатьЗаписьToolStripMenuItem_Click;
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            удалитьЗаписьToolStripMenuItem.Size = new Size(168, 22);
            удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            удалитьЗаписьToolStripMenuItem.Click += удалитьЗаписьToolStripMenuItem_Click;
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            изменитьЗаписьToolStripMenuItem.Size = new Size(168, 22);
            изменитьЗаписьToolStripMenuItem.Text = "Изменить запись";
            изменитьЗаписьToolStripMenuItem.Click += изменитьЗаписьToolStripMenuItem_Click;
            // 
            // найтиЗаписьToolStripMenuItem
            // 
            найтиЗаписьToolStripMenuItem.Name = "найтиЗаписьToolStripMenuItem";
            найтиЗаписьToolStripMenuItem.Size = new Size(168, 22);
            найтиЗаписьToolStripMenuItem.Text = "Найти запись";
            // 
            // создатьОтчетToolStripMenuItem
            // 
            создатьОтчетToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { текстовыйФайлToolStripMenuItem });
            создатьОтчетToolStripMenuItem.Name = "создатьОтчетToolStripMenuItem";
            создатьОтчетToolStripMenuItem.Size = new Size(95, 20);
            создатьОтчетToolStripMenuItem.Text = "Создать отчет";
            // 
            // текстовыйФайлToolStripMenuItem
            // 
            текстовыйФайлToolStripMenuItem.Name = "текстовыйФайлToolStripMenuItem";
            текстовыйФайлToolStripMenuItem.Size = new Size(165, 22);
            текстовыйФайлToolStripMenuItem.Text = "Текстовый файл";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // eDairyStorage
            // 
            eDairyStorage.AllowUserToAddRows = false;
            eDairyStorage.AllowUserToDeleteRows = false;
            eDairyStorage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eDairyStorage.ColumnHeadersVisible = false;
            eDairyStorage.Columns.AddRange(new DataGridViewColumn[] { id, DNotes });
            eDairyStorage.Location = new Point(386, 30);
            eDairyStorage.Margin = new Padding(3, 2, 3, 2);
            eDairyStorage.Name = "eDairyStorage";
            eDairyStorage.ReadOnly = true;
            eDairyStorage.RowHeadersVisible = false;
            eDairyStorage.RowHeadersWidth = 51;
            eDairyStorage.ScrollBars = ScrollBars.None;
            eDairyStorage.Size = new Size(370, 317);
            eDairyStorage.TabIndex = 1;
            eDairyStorage.CellContentClick += dataGridView1_CellContentClick;
            // 
            // eDairyRecordPanel
            // 
            eDairyRecordPanel.BackColor = SystemColors.ActiveCaption;
            eDairyRecordPanel.BorderStyle = BorderStyle.FixedSingle;
            eDairyRecordPanel.Controls.Add(mainButton);
            eDairyRecordPanel.Controls.Add(RecordTxtBox);
            eDairyRecordPanel.Controls.Add(RecordNameLabel);
            eDairyRecordPanel.Controls.Add(RecordChangeDataLabel);
            eDairyRecordPanel.Controls.Add(RecordCreateDataLabel);
            eDairyRecordPanel.Controls.Add(RecordUpdateDataTxtBox);
            eDairyRecordPanel.Controls.Add(RecordCreateDataTxtBox);
            eDairyRecordPanel.Controls.Add(RecordNameTxtBox);
            eDairyRecordPanel.Location = new Point(8, 30);
            eDairyRecordPanel.Margin = new Padding(3, 2, 3, 2);
            eDairyRecordPanel.Name = "eDairyRecordPanel";
            eDairyRecordPanel.Size = new Size(370, 317);
            eDairyRecordPanel.TabIndex = 2;
            eDairyRecordPanel.Visible = false;
            // 
            // mainButton
            // 
            mainButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainButton.BackColor = SystemColors.ButtonFace;
            mainButton.FlatStyle = FlatStyle.Popup;
            mainButton.Font = new Font("Segoe UI", 10F);
            mainButton.Location = new Point(11, 280);
            mainButton.Margin = new Padding(3, 2, 3, 2);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(346, 28);
            mainButton.TabIndex = 8;
            mainButton.Text = "Подтвердить";
            mainButton.UseVisualStyleBackColor = false;
            mainButton.Click += mainButton_Click;
            // 
            // RecordTxtBox
            // 
            RecordTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RecordTxtBox.Location = new Point(11, 57);
            RecordTxtBox.Margin = new Padding(3, 2, 3, 2);
            RecordTxtBox.Name = "RecordTxtBox";
            RecordTxtBox.Size = new Size(345, 168);
            RecordTxtBox.TabIndex = 7;
            RecordTxtBox.Text = "";
            // 
            // RecordNameLabel
            // 
            RecordNameLabel.AutoSize = true;
            RecordNameLabel.Font = new Font("Segoe UI", 10F);
            RecordNameLabel.Location = new Point(11, 8);
            RecordNameLabel.Name = "RecordNameLabel";
            RecordNameLabel.Size = new Size(116, 19);
            RecordNameLabel.TabIndex = 6;
            RecordNameLabel.Text = "Название записи";
            // 
            // RecordChangeDataLabel
            // 
            RecordChangeDataLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RecordChangeDataLabel.AutoSize = true;
            RecordChangeDataLabel.Font = new Font("Segoe UI", 10F);
            RecordChangeDataLabel.Location = new Point(190, 227);
            RecordChangeDataLabel.Name = "RecordChangeDataLabel";
            RecordChangeDataLabel.Size = new Size(112, 19);
            RecordChangeDataLabel.TabIndex = 5;
            RecordChangeDataLabel.Text = "Дата изменения";
            // 
            // RecordCreateDataLabel
            // 
            RecordCreateDataLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RecordCreateDataLabel.AutoSize = true;
            RecordCreateDataLabel.Font = new Font("Segoe UI", 10F);
            RecordCreateDataLabel.Location = new Point(11, 227);
            RecordCreateDataLabel.Name = "RecordCreateDataLabel";
            RecordCreateDataLabel.Size = new Size(101, 19);
            RecordCreateDataLabel.TabIndex = 4;
            RecordCreateDataLabel.Text = "Дата создания";
            // 
            // RecordUpdateDataTxtBox
            // 
            RecordUpdateDataTxtBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RecordUpdateDataTxtBox.Font = new Font("Segoe UI", 12F);
            RecordUpdateDataTxtBox.Location = new Point(190, 247);
            RecordUpdateDataTxtBox.Margin = new Padding(3, 2, 3, 2);
            RecordUpdateDataTxtBox.Name = "RecordUpdateDataTxtBox";
            RecordUpdateDataTxtBox.ReadOnly = true;
            RecordUpdateDataTxtBox.Size = new Size(167, 29);
            RecordUpdateDataTxtBox.TabIndex = 3;
            // 
            // RecordCreateDataTxtBox
            // 
            RecordCreateDataTxtBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RecordCreateDataTxtBox.Font = new Font("Segoe UI", 12F);
            RecordCreateDataTxtBox.Location = new Point(11, 247);
            RecordCreateDataTxtBox.Margin = new Padding(3, 2, 3, 2);
            RecordCreateDataTxtBox.Name = "RecordCreateDataTxtBox";
            RecordCreateDataTxtBox.ReadOnly = true;
            RecordCreateDataTxtBox.Size = new Size(167, 29);
            RecordCreateDataTxtBox.TabIndex = 2;
            // 
            // RecordNameTxtBox
            // 
            RecordNameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RecordNameTxtBox.Font = new Font("Segoe UI", 10F);
            RecordNameTxtBox.Location = new Point(11, 28);
            RecordNameTxtBox.Margin = new Padding(3, 2, 3, 2);
            RecordNameTxtBox.Name = "RecordNameTxtBox";
            RecordNameTxtBox.Size = new Size(345, 25);
            RecordNameTxtBox.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // DNotes
            // 
            DNotes.FlatStyle = FlatStyle.Flat;
            DNotes.HeaderText = "Записи Электронного дневника:";
            DNotes.MinimumWidth = 6;
            DNotes.Name = "DNotes";
            DNotes.ReadOnly = true;
            DNotes.Width = 300;
            // 
            // eDairyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 358);
            Controls.Add(eDairyStorage);
            Controls.Add(menuStrip1);
            Controls.Add(eDairyRecordPanel);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(784, 397);
            Name = "eDairyForm";
            Text = "E-Dairy";
            SizeChanged += eDairyForm_SizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eDairyStorage).EndInit();
            eDairyRecordPanel.ResumeLayout(false);
            eDairyRecordPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem инструментарийToolStripMenuItem;
        private DataGridView eDairyStorage;
        private Panel eDairyRecordPanel;
        private TextBox RecordNameTxtBox;
        private ToolStripMenuItem создатьЗаписьToolStripMenuItem;
        private ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem найтиЗаписьToolStripMenuItem;
        private TextBox RecordUpdateDataTxtBox;
        private TextBox RecordCreateDataTxtBox;
        private Label RecordChangeDataLabel;
        private Label RecordCreateDataLabel;
        private Label RecordNameLabel;
        private RichTextBox RecordTxtBox;
        private Button mainButton;
        private ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem создатьОтчетToolStripMenuItem;
        private ToolStripMenuItem текстовыйФайлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewButtonColumn DNotes;
    }
}
