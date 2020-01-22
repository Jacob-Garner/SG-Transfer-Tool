namespace SG_Transfer_Tool.Forms
{
    partial class FrmAddNew
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
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtboxSaveGameFilePath = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtboxName = new System.Windows.Forms.TextBox();
            this.BtnCancelClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(12, 71);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 25);
            this.BtnBrowse.TabIndex = 5;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtboxSaveGameFilePath
            // 
            this.TxtboxSaveGameFilePath.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxSaveGameFilePath.Location = new System.Drawing.Point(12, 40);
            this.TxtboxSaveGameFilePath.Name = "TxtboxSaveGameFilePath";
            this.TxtboxSaveGameFilePath.Size = new System.Drawing.Size(358, 23);
            this.TxtboxSaveGameFilePath.TabIndex = 4;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(8, 16);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(102, 19);
            this.Lbl1.TabIndex = 3;
            this.Lbl1.Text = "Save file path:";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(8, 122);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(52, 19);
            this.Lbl2.TabIndex = 6;
            this.Lbl2.Text = "Name:";
            // 
            // TxtboxName
            // 
            this.TxtboxName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxName.Location = new System.Drawing.Point(12, 145);
            this.TxtboxName.Name = "TxtboxName";
            this.TxtboxName.Size = new System.Drawing.Size(358, 23);
            this.TxtboxName.TabIndex = 7;
            // 
            // BtnCancelClose
            // 
            this.BtnCancelClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelClose.Location = new System.Drawing.Point(93, 212);
            this.BtnCancelClose.Name = "BtnCancelClose";
            this.BtnCancelClose.Size = new System.Drawing.Size(89, 25);
            this.BtnCancelClose.TabIndex = 9;
            this.BtnCancelClose.Text = "Cancel/close";
            this.BtnCancelClose.UseVisualStyleBackColor = true;
            this.BtnCancelClose.Click += new System.EventHandler(this.BtnCancelClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(12, 212);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 25);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 244);
            this.Controls.Add(this.BtnCancelClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtboxName);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtboxSaveGameFilePath);
            this.Controls.Add(this.Lbl1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddNew";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new";
            this.Load += new System.EventHandler(this.FrmAddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtboxSaveGameFilePath;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxtboxName;
        private System.Windows.Forms.Button BtnCancelClose;
        private System.Windows.Forms.Button BtnAdd;
    }
}