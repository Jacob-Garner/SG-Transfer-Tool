namespace SG_Transfer_Tool.Forms
{
    partial class FrmSettings
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TxtboxSaveGameFolderPath = new System.Windows.Forms.TextBox();
            this.BtnBrowseGameFolder = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancelClose = new System.Windows.Forms.Button();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.BtnBrowseGame = new System.Windows.Forms.Button();
            this.TxtboxGamePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(8, 15);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(163, 19);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Save game folder path:";
            // 
            // TxtboxSaveGameFolderPath
            // 
            this.TxtboxSaveGameFolderPath.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxSaveGameFolderPath.Location = new System.Drawing.Point(12, 37);
            this.TxtboxSaveGameFolderPath.Name = "TxtboxSaveGameFolderPath";
            this.TxtboxSaveGameFolderPath.Size = new System.Drawing.Size(358, 23);
            this.TxtboxSaveGameFolderPath.TabIndex = 1;
            // 
            // BtnBrowseGameFolder
            // 
            this.BtnBrowseGameFolder.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseGameFolder.Location = new System.Drawing.Point(12, 66);
            this.BtnBrowseGameFolder.Name = "BtnBrowseGameFolder";
            this.BtnBrowseGameFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseGameFolder.TabIndex = 2;
            this.BtnBrowseGameFolder.Text = "Browse";
            this.BtnBrowseGameFolder.UseVisualStyleBackColor = true;
            this.BtnBrowseGameFolder.Click += new System.EventHandler(this.BtnBrowseGameFolder_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(12, 220);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancelClose
            // 
            this.BtnCancelClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelClose.Location = new System.Drawing.Point(93, 220);
            this.BtnCancelClose.Name = "BtnCancelClose";
            this.BtnCancelClose.Size = new System.Drawing.Size(89, 23);
            this.BtnCancelClose.TabIndex = 4;
            this.BtnCancelClose.Text = "Cancel/close";
            this.BtnCancelClose.UseVisualStyleBackColor = true;
            this.BtnCancelClose.Click += new System.EventHandler(this.BtnCancelClose_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(8, 107);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(156, 19);
            this.Lbl2.TabIndex = 5;
            this.Lbl2.Text = "Game .exe or shortcut:";
            // 
            // BtnBrowseGame
            // 
            this.BtnBrowseGame.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseGame.Location = new System.Drawing.Point(12, 158);
            this.BtnBrowseGame.Name = "BtnBrowseGame";
            this.BtnBrowseGame.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseGame.TabIndex = 7;
            this.BtnBrowseGame.Text = "Browse";
            this.BtnBrowseGame.UseVisualStyleBackColor = true;
            this.BtnBrowseGame.Click += new System.EventHandler(this.BtnBrowseGame_Click);
            // 
            // TxtboxGamePath
            // 
            this.TxtboxGamePath.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxGamePath.Location = new System.Drawing.Point(12, 129);
            this.TxtboxGamePath.Name = "TxtboxGamePath";
            this.TxtboxGamePath.Size = new System.Drawing.Size(358, 23);
            this.TxtboxGamePath.TabIndex = 6;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 256);
            this.Controls.Add(this.BtnBrowseGame);
            this.Controls.Add(this.TxtboxGamePath);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.BtnCancelClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnBrowseGameFolder);
            this.Controls.Add(this.TxtboxSaveGameFolderPath);
            this.Controls.Add(this.Lbl1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox TxtboxSaveGameFolderPath;
        private System.Windows.Forms.Button BtnBrowseGameFolder;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancelClose;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Button BtnBrowseGame;
        private System.Windows.Forms.TextBox TxtboxGamePath;
    }
}