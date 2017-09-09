namespace FireRTC_Caller_ID_Changer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.areaSelectionLabel = new System.Windows.Forms.Label();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.programNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeCallerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayButton = new System.Windows.Forms.Button();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaSelectionLabel
            // 
            this.areaSelectionLabel.AutoSize = true;
            this.areaSelectionLabel.Location = new System.Drawing.Point(12, 15);
            this.areaSelectionLabel.Name = "areaSelectionLabel";
            this.areaSelectionLabel.Size = new System.Drawing.Size(77, 13);
            this.areaSelectionLabel.TabIndex = 0;
            this.areaSelectionLabel.Text = "Area selection:";
            // 
            // areaComboBox
            // 
            this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(151, 12);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(225, 21);
            this.areaComboBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 42);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(151, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(225, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(151, 65);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(225, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(151, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // programNotifyIcon
            // 
            this.programNotifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.programNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("programNotifyIcon.Icon")));
            this.programNotifyIcon.Text = "FireRTC Caller ID Changer";
            this.programNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.programNotifyIcon_MouseClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCallerIDToolStripMenuItem,
            this.openSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(163, 70);
            // 
            // changeCallerIDToolStripMenuItem
            // 
            this.changeCallerIDToolStripMenuItem.Name = "changeCallerIDToolStripMenuItem";
            this.changeCallerIDToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeCallerIDToolStripMenuItem.Text = "Change Caller ID";
            this.changeCallerIDToolStripMenuItem.Click += new System.EventHandler(this.changeCallerIDToolStripMenuItem_Click);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openSettingsToolStripMenuItem.Text = "Open Settings";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // minimizeToTrayButton
            // 
            this.minimizeToTrayButton.Location = new System.Drawing.Point(266, 91);
            this.minimizeToTrayButton.Name = "minimizeToTrayButton";
            this.minimizeToTrayButton.Size = new System.Drawing.Size(110, 23);
            this.minimizeToTrayButton.TabIndex = 13;
            this.minimizeToTrayButton.Text = "Minimize to tray";
            this.minimizeToTrayButton.UseVisualStyleBackColor = true;
            this.minimizeToTrayButton.Click += new System.EventHandler(this.minimizeToTrayButton_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(12, 101);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(35, 13);
            this.aboutLabel.TabIndex = 14;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "About";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 126);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.minimizeToTrayButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.areaSelectionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FireRTC Caller ID Changer - Settings";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label areaSelectionLabel;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NotifyIcon programNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem changeCallerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button minimizeToTrayButton;
        private System.Windows.Forms.LinkLabel aboutLabel;
    }
}

