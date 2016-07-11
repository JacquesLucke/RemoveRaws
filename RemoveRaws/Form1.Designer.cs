namespace RemoveRaws
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedFolderLabel = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.CheckedListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.fileTypesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectedFolderLabel
            // 
            this.selectedFolderLabel.AutoSize = true;
            this.selectedFolderLabel.Location = new System.Drawing.Point(9, 50);
            this.selectedFolderLabel.Name = "selectedFolderLabel";
            this.selectedFolderLabel.Size = new System.Drawing.Size(29, 13);
            this.selectedFolderLabel.TabIndex = 0;
            this.selectedFolderLabel.Text = "Path";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(12, 12);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Select Path";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // scanButton
            // 
            this.scanButton.Enabled = false;
            this.scanButton.Location = new System.Drawing.Point(93, 12);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 2;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(13, 107);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(360, 259);
            this.fileListBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(174, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // fileTypesTextBox
            // 
            this.fileTypesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTypesTextBox.Location = new System.Drawing.Point(13, 81);
            this.fileTypesTextBox.Name = "fileTypesTextBox";
            this.fileTypesTextBox.Size = new System.Drawing.Size(360, 20);
            this.fileTypesTextBox.TabIndex = 6;
            this.fileTypesTextBox.Text = "cr2, raw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 373);
            this.Controls.Add(this.fileTypesTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.selectedFolderLabel);
            this.Name = "Form1";
            this.Text = "Remove Raws";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedFolderLabel;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.CheckedListBox fileListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox fileTypesTextBox;
    }
}

