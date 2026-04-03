namespace eDairy
{
    partial class DeleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InfoLabel = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            NameTxtBox = new TextBox();
            SuspendLayout();
            // 
            // InfoLabel
            // 
            InfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 10F);
            InfoLabel.Location = new Point(12, 7);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(333, 19);
            InfoLabel.TabIndex = 5;
            InfoLabel.Text = "Вы уверены, что хотите удалить следующий файл?";
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            confirmButton.BackColor = SystemColors.ButtonFace;
            confirmButton.FlatStyle = FlatStyle.Popup;
            confirmButton.Font = new Font("Segoe UI", 10F);
            confirmButton.Location = new Point(181, 75);
            confirmButton.Margin = new Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(161, 28);
            confirmButton.TabIndex = 9;
            confirmButton.Text = "Подтвердить";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.BackColor = SystemColors.ButtonFace;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI", 10F);
            cancelButton.Location = new Point(13, 75);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(162, 28);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTxtBox.Font = new Font("Segoe UI", 10F);
            NameTxtBox.Location = new Point(12, 36);
            NameTxtBox.Margin = new Padding(3, 2, 3, 2);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.ReadOnly = true;
            NameTxtBox.Size = new Size(329, 25);
            NameTxtBox.TabIndex = 11;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 114);
            Controls.Add(NameTxtBox);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(InfoLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoLabel;
        private Button confirmButton;
        private Button cancelButton;
        private TextBox NameTxtBox;
    }
}