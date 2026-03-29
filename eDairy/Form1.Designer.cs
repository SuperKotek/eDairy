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
            панельРедактированияToolStripMenuItem = new ToolStripMenuItem();
            открытьПанельToolStripMenuItem = new ToolStripMenuItem();
            закрытьПанельToolStripMenuItem = new ToolStripMenuItem();
            инструментарийToolStripMenuItem = new ToolStripMenuItem();
            создатьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            найтиЗаписьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            текстовыйФайлToolStripMenuItem = new ToolStripMenuItem();
            DNotes = new DataGridViewButtonColumn();
            eDairyStorage = new DataGridView();
            eDairyRecordPanel = new Panel();
            mainButton = new Button();
            RecordTxtBox = new RichTextBox();
            RecordNameLabel = new Label();
            RecordChangeDataLabel = new Label();
            RecordCreateDataLabel = new Label();
            RecordChangeDataTxtBox = new TextBox();
            RecordCreateDataTxtBox = new TextBox();
            RecordNameTxtBox = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eDairyStorage).BeginInit();
            eDairyRecordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { панельРедактированияToolStripMenuItem, инструментарийToolStripMenuItem, сохранитьКакToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // панельРедактированияToolStripMenuItem
            // 
            панельРедактированияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьПанельToolStripMenuItem, закрытьПанельToolStripMenuItem });
            панельРедактированияToolStripMenuItem.Name = "панельРедактированияToolStripMenuItem";
            панельРедактированияToolStripMenuItem.Size = new Size(194, 24);
            панельРедактированияToolStripMenuItem.Text = "Панель редактирования";
            // 
            // открытьПанельToolStripMenuItem
            // 
            открытьПанельToolStripMenuItem.Name = "открытьПанельToolStripMenuItem";
            открытьПанельToolStripMenuItem.Size = new Size(204, 26);
            открытьПанельToolStripMenuItem.Text = "Открыть панель";
            открытьПанельToolStripMenuItem.Click += открытьПанельToolStripMenuItem_Click;
            // 
            // закрытьПанельToolStripMenuItem
            // 
            закрытьПанельToolStripMenuItem.Name = "закрытьПанельToolStripMenuItem";
            закрытьПанельToolStripMenuItem.Size = new Size(204, 26);
            закрытьПанельToolStripMenuItem.Text = "Закрыть панель";
            закрытьПанельToolStripMenuItem.Click += закрытьПанельToolStripMenuItem_Click;
            // 
            // инструментарийToolStripMenuItem
            // 
            инструментарийToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьЗаписьToolStripMenuItem, удалитьЗаписьToolStripMenuItem, найтиЗаписьToolStripMenuItem });
            инструментарийToolStripMenuItem.Name = "инструментарийToolStripMenuItem";
            инструментарийToolStripMenuItem.Size = new Size(141, 24);
            инструментарийToolStripMenuItem.Text = "Инструментарий";
            // 
            // создатьЗаписьToolStripMenuItem
            // 
            создатьЗаписьToolStripMenuItem.Name = "создатьЗаписьToolStripMenuItem";
            создатьЗаписьToolStripMenuItem.Size = new Size(200, 26);
            создатьЗаписьToolStripMenuItem.Text = "Создать запись";
            создатьЗаписьToolStripMenuItem.Click += создатьЗаписьToolStripMenuItem_Click;
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            удалитьЗаписьToolStripMenuItem.Size = new Size(200, 26);
            удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            удалитьЗаписьToolStripMenuItem.Click += удалитьЗаписьToolStripMenuItem_Click;
            // 
            // найтиЗаписьToolStripMenuItem
            // 
            найтиЗаписьToolStripMenuItem.Name = "найтиЗаписьToolStripMenuItem";
            найтиЗаписьToolStripMenuItem.Size = new Size(200, 26);
            найтиЗаписьToolStripMenuItem.Text = "Найти запись";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { текстовыйФайлToolStripMenuItem });
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(132, 24);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // текстовыйФайлToolStripMenuItem
            // 
            текстовыйФайлToolStripMenuItem.Name = "текстовыйФайлToolStripMenuItem";
            текстовыйФайлToolStripMenuItem.Size = new Size(204, 26);
            текстовыйФайлToolStripMenuItem.Text = "Текстовый файл";
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
            // eDairyStorage
            // 
            eDairyStorage.AllowUserToAddRows = false;
            eDairyStorage.AllowUserToDeleteRows = false;
            eDairyStorage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eDairyStorage.ColumnHeadersVisible = false;
            eDairyStorage.Columns.AddRange(new DataGridViewColumn[] { DNotes });
            eDairyStorage.Location = new Point(438, 31);
            eDairyStorage.Name = "eDairyStorage";
            eDairyStorage.ReadOnly = true;
            eDairyStorage.RowHeadersVisible = false;
            eDairyStorage.RowHeadersWidth = 51;
            eDairyStorage.ScrollBars = ScrollBars.None;
            eDairyStorage.Size = new Size(426, 426);
            eDairyStorage.TabIndex = 1;
            eDairyStorage.CellContentClick += dataGridView1_CellContentClick;
            // 
            // eDairyRecordPanel
            // 
            eDairyRecordPanel.BackColor = SystemColors.ActiveCaption;
            eDairyRecordPanel.Controls.Add(mainButton);
            eDairyRecordPanel.Controls.Add(RecordTxtBox);
            eDairyRecordPanel.Controls.Add(RecordNameLabel);
            eDairyRecordPanel.Controls.Add(RecordChangeDataLabel);
            eDairyRecordPanel.Controls.Add(RecordCreateDataLabel);
            eDairyRecordPanel.Controls.Add(RecordChangeDataTxtBox);
            eDairyRecordPanel.Controls.Add(RecordCreateDataTxtBox);
            eDairyRecordPanel.Controls.Add(RecordNameTxtBox);
            eDairyRecordPanel.Location = new Point(12, 31);
            eDairyRecordPanel.Name = "eDairyRecordPanel";
            eDairyRecordPanel.Size = new Size(420, 426);
            eDairyRecordPanel.TabIndex = 2;
            eDairyRecordPanel.Visible = false;
            // 
            // mainButton
            // 
            mainButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainButton.Font = new Font("Segoe UI", 10F);
            mainButton.Location = new Point(13, 376);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(394, 37);
            mainButton.TabIndex = 8;
            mainButton.Text = "Подтвердить";
            mainButton.UseVisualStyleBackColor = true;
            mainButton.Click += mainButton_Click;
            // 
            // RecordTxtBox
            // 
            RecordTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RecordTxtBox.Location = new Point(13, 73);
            RecordTxtBox.Name = "RecordTxtBox";
            RecordTxtBox.Size = new Size(394, 234);
            RecordTxtBox.TabIndex = 7;
            RecordTxtBox.Text = "";
            // 
            // RecordNameLabel
            // 
            RecordNameLabel.AutoSize = true;
            RecordNameLabel.Font = new Font("Segoe UI", 10F);
            RecordNameLabel.Location = new Point(13, 11);
            RecordNameLabel.Name = "RecordNameLabel";
            RecordNameLabel.Size = new Size(146, 23);
            RecordNameLabel.TabIndex = 6;
            RecordNameLabel.Text = "Название записи";
            // 
            // RecordChangeDataLabel
            // 
            RecordChangeDataLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RecordChangeDataLabel.AutoSize = true;
            RecordChangeDataLabel.Font = new Font("Segoe UI", 10F);
            RecordChangeDataLabel.Location = new Point(217, 310);
            RecordChangeDataLabel.Name = "RecordChangeDataLabel";
            RecordChangeDataLabel.Size = new Size(139, 23);
            RecordChangeDataLabel.TabIndex = 5;
            RecordChangeDataLabel.Text = "Дата изменения";
            // 
            // RecordCreateDataLabel
            // 
            RecordCreateDataLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RecordCreateDataLabel.AutoSize = true;
            RecordCreateDataLabel.Font = new Font("Segoe UI", 10F);
            RecordCreateDataLabel.Location = new Point(13, 310);
            RecordCreateDataLabel.Name = "RecordCreateDataLabel";
            RecordCreateDataLabel.Size = new Size(125, 23);
            RecordCreateDataLabel.TabIndex = 4;
            RecordCreateDataLabel.Text = "Дата создания";
            // 
            // RecordChangeDataTxtBox
            // 
            RecordChangeDataTxtBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RecordChangeDataTxtBox.Font = new Font("Segoe UI", 12F);
            RecordChangeDataTxtBox.Location = new Point(217, 336);
            RecordChangeDataTxtBox.Name = "RecordChangeDataTxtBox";
            RecordChangeDataTxtBox.ReadOnly = true;
            RecordChangeDataTxtBox.Size = new Size(190, 34);
            RecordChangeDataTxtBox.TabIndex = 3;
            // 
            // RecordCreateDataTxtBox
            // 
            RecordCreateDataTxtBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RecordCreateDataTxtBox.Font = new Font("Segoe UI", 12F);
            RecordCreateDataTxtBox.Location = new Point(13, 336);
            RecordCreateDataTxtBox.Name = "RecordCreateDataTxtBox";
            RecordCreateDataTxtBox.ReadOnly = true;
            RecordCreateDataTxtBox.Size = new Size(190, 34);
            RecordCreateDataTxtBox.TabIndex = 2;
            // 
            // RecordNameTxtBox
            // 
            RecordNameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RecordNameTxtBox.Font = new Font("Segoe UI", 10F);
            RecordNameTxtBox.Location = new Point(13, 37);
            RecordNameTxtBox.Name = "RecordNameTxtBox";
            RecordNameTxtBox.Size = new Size(394, 30);
            RecordNameTxtBox.TabIndex = 0;
            // 
            // eDairyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 469);
            Controls.Add(eDairyStorage);
            Controls.Add(menuStrip1);
            Controls.Add(eDairyRecordPanel);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(894, 516);
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
        private DataGridViewButtonColumn DNotes;
        private DataGridView eDairyStorage;
        private Panel eDairyRecordPanel;
        private TextBox RecordNameTxtBox;
        private ToolStripMenuItem панельРедактированияToolStripMenuItem;
        private ToolStripMenuItem открытьПанельToolStripMenuItem;
        private ToolStripMenuItem закрытьПанельToolStripMenuItem;
        private ToolStripMenuItem создатьЗаписьToolStripMenuItem;
        private ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem найтиЗаписьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem текстовыйФайлToolStripMenuItem;
        private TextBox RecordChangeDataTxtBox;
        private TextBox RecordCreateDataTxtBox;
        private Label RecordChangeDataLabel;
        private Label RecordCreateDataLabel;
        private Label RecordNameLabel;
        private RichTextBox RecordTxtBox;
        private Button mainButton;
    }
}
