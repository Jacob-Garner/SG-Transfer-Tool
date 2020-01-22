namespace SG_Transfer_Tool
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LstboxSaves = new System.Windows.Forms.ListBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.MnuStpMain = new System.Windows.Forms.MenuStrip();
            this.MenBtnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenBtnNewFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenBtnFromCurrentSave = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenBtnRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenBtnRemoveSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLoadSelectedSave = new System.Windows.Forms.Button();
            this.MnuStpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LstboxSaves
            // 
            this.LstboxSaves.FormattingEnabled = true;
            this.LstboxSaves.ItemHeight = 14;
            this.LstboxSaves.Location = new System.Drawing.Point(12, 79);
            this.LstboxSaves.Name = "LstboxSaves";
            this.LstboxSaves.Size = new System.Drawing.Size(396, 172);
            this.LstboxSaves.TabIndex = 0;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(8, 51);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(92, 23);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Save files:";
            // 
            // MnuStpMain
            // 
            this.MnuStpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenBtnSettings,
            this.createToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.MnuStpMain.Location = new System.Drawing.Point(0, 0);
            this.MnuStpMain.Name = "MnuStpMain";
            this.MnuStpMain.Size = new System.Drawing.Size(420, 24);
            this.MnuStpMain.TabIndex = 2;
            // 
            // MenBtnSettings
            // 
            this.MenBtnSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.MenBtnSettings.Name = "MenBtnSettings";
            this.MenBtnSettings.Size = new System.Drawing.Size(62, 20);
            this.MenBtnSettings.Text = "Settings";
            this.MenBtnSettings.Click += new System.EventHandler(this.MenBtnSettings_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenBtnNewFromFile,
            this.MenBtnFromCurrentSave});
            this.createToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // MenBtnNewFromFile
            // 
            this.MenBtnNewFromFile.Name = "MenBtnNewFromFile";
            this.MenBtnNewFromFile.Size = new System.Drawing.Size(196, 22);
            this.MenBtnNewFromFile.Text = "New from file";
            this.MenBtnNewFromFile.Click += new System.EventHandler(this.MenBtnNewFromFile_Click);
            // 
            // MenBtnFromCurrentSave
            // 
            this.MenBtnFromCurrentSave.Name = "MenBtnFromCurrentSave";
            this.MenBtnFromCurrentSave.Size = new System.Drawing.Size(196, 22);
            this.MenBtnFromCurrentSave.Text = "New from current save";
            this.MenBtnFromCurrentSave.Click += new System.EventHandler(this.MenBtnFromCurrentSave_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenBtnRemoveAll,
            this.MenBtnRemoveSelected});
            this.removeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // MenBtnRemoveAll
            // 
            this.MenBtnRemoveAll.Name = "MenBtnRemoveAll";
            this.MenBtnRemoveAll.Size = new System.Drawing.Size(146, 22);
            this.MenBtnRemoveAll.Text = "All";
            this.MenBtnRemoveAll.Click += new System.EventHandler(this.MenBtnRemoveAll_Click);
            // 
            // MenBtnRemoveSelected
            // 
            this.MenBtnRemoveSelected.Name = "MenBtnRemoveSelected";
            this.MenBtnRemoveSelected.Size = new System.Drawing.Size(146, 22);
            this.MenBtnRemoveSelected.Text = "Selected save";
            this.MenBtnRemoveSelected.Click += new System.EventHandler(this.MenBtnRemoveSelected_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLoadSelectedSave
            // 
            this.BtnLoadSelectedSave.Location = new System.Drawing.Point(12, 257);
            this.BtnLoadSelectedSave.Name = "BtnLoadSelectedSave";
            this.BtnLoadSelectedSave.Size = new System.Drawing.Size(396, 25);
            this.BtnLoadSelectedSave.TabIndex = 4;
            this.BtnLoadSelectedSave.Text = "Load selected save";
            this.BtnLoadSelectedSave.UseVisualStyleBackColor = true;
            this.BtnLoadSelectedSave.Click += new System.EventHandler(this.BtnLoadSelectedSave_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 295);
            this.Controls.Add(this.BtnLoadSelectedSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.LstboxSaves);
            this.Controls.Add(this.MnuStpMain);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuStpMain;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SG Transfer Tool";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MnuStpMain.ResumeLayout(false);
            this.MnuStpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstboxSaves;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.MenuStrip MnuStpMain;
        private System.Windows.Forms.ToolStripMenuItem MenBtnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLoadSelectedSave;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenBtnNewFromFile;
        private System.Windows.Forms.ToolStripMenuItem MenBtnFromCurrentSave;
        private System.Windows.Forms.ToolStripMenuItem MenBtnRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem MenBtnRemoveSelected;
    }
}

