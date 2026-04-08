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
            SearchMenuButton = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            датеСозданияToolStripMenuItem = new ToolStripMenuItem();
            датеИзмененияToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            eDairyStorage = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            DNotes = new DataGridViewButtonColumn();
            eDairyRecordPanel = new Panel();
            mainButton = new Button();
            RecordTxtBox = new RichTextBox();
            RecordNameLabel = new Label();
            RecordChangeDataLabel = new Label();
            RecordCreateDataLabel = new Label();
            RecordUpdateDataTxtBox = new TextBox();
            RecordCreateDataTxtBox = new TextBox();
            RecordNameTxtBox = new TextBox();
            eDairySearchNamePanel = new Panel();
            SearchNameButton1 = new Button();
            SearchNameButton = new Button();
            SearchTxtBox = new TextBox();
            SearchLabel = new Label();
            eDairySearchDatePanel = new Panel();
            SearchDataButton1 = new Button();
            SearchDateTimePicker2 = new DateTimePicker();
            SearchDateTimePicker1 = new DateTimePicker();
            SearchDataButton = new Button();
            SearchLabel1 = new Label();
            button1 = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eDairyStorage).BeginInit();
            eDairyRecordPanel.SuspendLayout();
            eDairySearchNamePanel.SuspendLayout();
            eDairySearchDatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { инструментарийToolStripMenuItem, SearchMenuButton, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(768, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // инструментарийToolStripMenuItem
            // 
            инструментарийToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьЗаписьToolStripMenuItem, удалитьЗаписьToolStripMenuItem, изменитьЗаписьToolStripMenuItem });
            инструментарийToolStripMenuItem.Name = "инструментарийToolStripMenuItem";
            инструментарийToolStripMenuItem.Size = new Size(122, 20);
            инструментарийToolStripMenuItem.Text = "Работа с записями";
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
            // SearchMenuButton
            // 
            SearchMenuButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, датеСозданияToolStripMenuItem, датеИзмененияToolStripMenuItem });
            SearchMenuButton.Name = "SearchMenuButton";
            SearchMenuButton.Size = new Size(80, 20);
            SearchMenuButton.Text = "Поиск по...";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(162, 22);
            toolStripMenuItem1.Text = "Имени";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // датеСозданияToolStripMenuItem
            // 
            датеСозданияToolStripMenuItem.Name = "датеСозданияToolStripMenuItem";
            датеСозданияToolStripMenuItem.Size = new Size(162, 22);
            датеСозданияToolStripMenuItem.Text = "Дате создания";
            датеСозданияToolStripMenuItem.Click += датеСозданияToolStripMenuItem_Click;
            // 
            // датеИзмененияToolStripMenuItem
            // 
            датеИзмененияToolStripMenuItem.Name = "датеИзмененияToolStripMenuItem";
            датеИзмененияToolStripMenuItem.Size = new Size(162, 22);
            датеИзмененияToolStripMenuItem.Text = "Дате изменения";
            датеИзмененияToolStripMenuItem.Click += датеИзмененияToolStripMenuItem_Click;
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
            eDairyStorage.Location = new Point(12, 30);
            eDairyStorage.Margin = new Padding(3, 2, 3, 2);
            eDairyStorage.Name = "eDairyStorage";
            eDairyStorage.ReadOnly = true;
            eDairyStorage.RowHeadersVisible = false;
            eDairyStorage.RowHeadersWidth = 51;
            eDairyStorage.ScrollBars = ScrollBars.None;
            eDairyStorage.Size = new Size(744, 267);
            eDairyStorage.TabIndex = 1;
            eDairyStorage.CellContentClick += dataGridView1_CellContentClick;
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
            eDairyRecordPanel.Size = new Size(370, 267);
            eDairyRecordPanel.TabIndex = 2;
            eDairyRecordPanel.Visible = false;
            // 
            // mainButton
            // 
            mainButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainButton.BackColor = SystemColors.ButtonFace;
            mainButton.FlatStyle = FlatStyle.Popup;
            mainButton.Font = new Font("Segoe UI", 10F);
            mainButton.Location = new Point(11, 230);
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
            RecordTxtBox.Size = new Size(345, 118);
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
            RecordChangeDataLabel.Location = new Point(190, 177);
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
            RecordCreateDataLabel.Location = new Point(11, 177);
            RecordCreateDataLabel.Name = "RecordCreateDataLabel";
            RecordCreateDataLabel.Size = new Size(101, 19);
            RecordCreateDataLabel.TabIndex = 4;
            RecordCreateDataLabel.Text = "Дата создания";
            // 
            // RecordUpdateDataTxtBox
            // 
            RecordUpdateDataTxtBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RecordUpdateDataTxtBox.Font = new Font("Segoe UI", 12F);
            RecordUpdateDataTxtBox.Location = new Point(190, 197);
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
            RecordCreateDataTxtBox.Location = new Point(11, 197);
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
            // eDairySearchNamePanel
            // 
            eDairySearchNamePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eDairySearchNamePanel.BackColor = SystemColors.AppWorkspace;
            eDairySearchNamePanel.BorderStyle = BorderStyle.FixedSingle;
            eDairySearchNamePanel.Controls.Add(SearchNameButton1);
            eDairySearchNamePanel.Controls.Add(SearchNameButton);
            eDairySearchNamePanel.Controls.Add(SearchTxtBox);
            eDairySearchNamePanel.Controls.Add(SearchLabel);
            eDairySearchNamePanel.Location = new Point(8, 302);
            eDairySearchNamePanel.Name = "eDairySearchNamePanel";
            eDairySearchNamePanel.Size = new Size(748, 44);
            eDairySearchNamePanel.TabIndex = 3;
            eDairySearchNamePanel.Visible = false;
            // 
            // SearchNameButton1
            // 
            SearchNameButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchNameButton1.BackColor = SystemColors.ButtonFace;
            SearchNameButton1.FlatStyle = FlatStyle.Popup;
            SearchNameButton1.Font = new Font("Segoe UI", 8F);
            SearchNameButton1.Location = new Point(614, 10);
            SearchNameButton1.Margin = new Padding(3, 2, 3, 2);
            SearchNameButton1.Name = "SearchNameButton1";
            SearchNameButton1.Size = new Size(127, 23);
            SearchNameButton1.TabIndex = 15;
            SearchNameButton1.Text = "Сбросить все";
            SearchNameButton1.UseVisualStyleBackColor = false;
            SearchNameButton1.Click += SearchNameButton1_Click;
            // 
            // SearchNameButton
            // 
            SearchNameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchNameButton.BackColor = SystemColors.ButtonFace;
            SearchNameButton.FlatStyle = FlatStyle.Popup;
            SearchNameButton.Font = new Font("Segoe UI", 8F);
            SearchNameButton.Location = new Point(481, 10);
            SearchNameButton.Margin = new Padding(3, 2, 3, 2);
            SearchNameButton.Name = "SearchNameButton";
            SearchNameButton.Size = new Size(127, 23);
            SearchNameButton.TabIndex = 9;
            SearchNameButton.Text = "Найти";
            SearchNameButton.UseVisualStyleBackColor = false;
            SearchNameButton.Click += SearchNameButton_Click;
            // 
            // SearchTxtBox
            // 
            SearchTxtBox.Location = new Point(125, 10);
            SearchTxtBox.Name = "SearchTxtBox";
            SearchTxtBox.Size = new Size(350, 23);
            SearchTxtBox.TabIndex = 10;
            // 
            // SearchLabel
            // 
            SearchLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 10F);
            SearchLabel.Location = new Point(3, 12);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(116, 19);
            SearchLabel.TabIndex = 9;
            SearchLabel.Text = "Название записи";
            // 
            // eDairySearchDatePanel
            // 
            eDairySearchDatePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eDairySearchDatePanel.BackColor = SystemColors.AppWorkspace;
            eDairySearchDatePanel.BorderStyle = BorderStyle.FixedSingle;
            eDairySearchDatePanel.Controls.Add(SearchDataButton1);
            eDairySearchDatePanel.Controls.Add(SearchDateTimePicker2);
            eDairySearchDatePanel.Controls.Add(SearchDateTimePicker1);
            eDairySearchDatePanel.Controls.Add(SearchDataButton);
            eDairySearchDatePanel.Controls.Add(SearchLabel1);
            eDairySearchDatePanel.Controls.Add(button1);
            eDairySearchDatePanel.Controls.Add(label1);
            eDairySearchDatePanel.Location = new Point(8, 302);
            eDairySearchDatePanel.Name = "eDairySearchDatePanel";
            eDairySearchDatePanel.Size = new Size(748, 44);
            eDairySearchDatePanel.TabIndex = 4;
            eDairySearchDatePanel.Visible = false;
            // 
            // SearchDataButton1
            // 
            SearchDataButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchDataButton1.BackColor = SystemColors.ButtonFace;
            SearchDataButton1.FlatStyle = FlatStyle.Popup;
            SearchDataButton1.Font = new Font("Segoe UI", 8F);
            SearchDataButton1.Location = new Point(614, 12);
            SearchDataButton1.Margin = new Padding(3, 2, 3, 2);
            SearchDataButton1.Name = "SearchDataButton1";
            SearchDataButton1.Size = new Size(127, 23);
            SearchDataButton1.TabIndex = 14;
            SearchDataButton1.Text = "Сбросить все";
            SearchDataButton1.UseVisualStyleBackColor = false;
            SearchDataButton1.Click += SearchDataButton1_Click;
            // 
            // SearchDateTimePicker2
            // 
            SearchDateTimePicker2.Location = new Point(305, 12);
            SearchDateTimePicker2.Name = "SearchDateTimePicker2";
            SearchDateTimePicker2.Size = new Size(170, 23);
            SearchDateTimePicker2.TabIndex = 13;
            // 
            // SearchDateTimePicker1
            // 
            SearchDateTimePicker1.Location = new Point(125, 12);
            SearchDateTimePicker1.Name = "SearchDateTimePicker1";
            SearchDateTimePicker1.Size = new Size(170, 23);
            SearchDateTimePicker1.TabIndex = 12;
            // 
            // SearchDataButton
            // 
            SearchDataButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchDataButton.BackColor = SystemColors.ButtonFace;
            SearchDataButton.FlatStyle = FlatStyle.Popup;
            SearchDataButton.Font = new Font("Segoe UI", 8F);
            SearchDataButton.Location = new Point(481, 12);
            SearchDataButton.Margin = new Padding(3, 2, 3, 2);
            SearchDataButton.Name = "SearchDataButton";
            SearchDataButton.Size = new Size(127, 23);
            SearchDataButton.TabIndex = 11;
            SearchDataButton.Text = "Найти";
            SearchDataButton.UseVisualStyleBackColor = false;
            SearchDataButton.Click += SearchDataButton_Click;
            // 
            // SearchLabel1
            // 
            SearchLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchLabel1.AutoSize = true;
            SearchLabel1.Font = new Font("Segoe UI", 10F);
            SearchLabel1.Location = new Point(7, 12);
            SearchLabel1.Name = "SearchLabel1";
            SearchLabel1.Size = new Size(107, 19);
            SearchLabel1.TabIndex = 11;
            SearchLabel1.Text = "Диапозон даты";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(566, -48);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(709, 23);
            button1.TabIndex = 9;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(3, -46);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 9;
            label1.Text = "Название записи";
            // 
            // eDairyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 358);
            Controls.Add(eDairySearchDatePanel);
            Controls.Add(eDairySearchNamePanel);
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
            eDairySearchNamePanel.ResumeLayout(false);
            eDairySearchNamePanel.PerformLayout();
            eDairySearchDatePanel.ResumeLayout(false);
            eDairySearchDatePanel.PerformLayout();
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
        private TextBox RecordUpdateDataTxtBox;
        private TextBox RecordCreateDataTxtBox;
        private Label RecordChangeDataLabel;
        private Label RecordCreateDataLabel;
        private Label RecordNameLabel;
        private RichTextBox RecordTxtBox;
        private Button mainButton;
        private ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewButtonColumn DNotes;
        private ToolStripMenuItem SearchMenuButton;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem датеСозданияToolStripMenuItem;
        private ToolStripMenuItem датеИзмененияToolStripMenuItem;
        private Panel eDairySearchNamePanel;
        private Button SearchNameButton;
        private TextBox SearchTxtBox;
        private Label SearchLabel;
        private Panel eDairySearchDatePanel;
        private DateTimePicker SearchDateTimePicker1;
        private Button SearchDataButton;
        private Label SearchLabel1;
        private Button button1;
        private Label label1;
        private DateTimePicker SearchDateTimePicker2;
        private Button SearchNameButton1;
        private Button SearchDataButton1;
    }
}
