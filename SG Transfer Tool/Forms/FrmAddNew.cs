using System;
using System.IO;
using System.Windows.Forms;
using SG_Transfer_Tool.Classes;

namespace SG_Transfer_Tool.Forms
{
    public partial class FrmAddNew : Form
    {
        public FrmAddNew()
        {
            InitializeComponent();
        }

        public FrmAddNew(string filePath)
        {
            InitializeComponent();
            TxtboxSaveGameFilePath.Text = filePath;
        }

        #region Variables



        #endregion

        #region Events

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
            TxtboxName.Select();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            //Let the user select a SaveGame file.
            using (OpenFileDialog fileBrowser = new OpenFileDialog())
            {
                fileBrowser.Filter = "SaveGame files|*.txt";

                if (fileBrowser.ShowDialog() == DialogResult.OK)
                {
                    TxtboxSaveGameFilePath.Text = fileBrowser.FileName;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Create a new save.
            if (FormIsValid())
            {
                try
                {
                    File.Copy(TxtboxSaveGameFilePath.Text, 
                        Global.SavesFolderPath + "\\" + TxtboxName.Text + ".txt");

                    this.Close();
                }

                catch
                {
                    MessageBox.Show("There was an error while saving the SaveGame file. " +
                        "Please try agian.", "Save error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("There is invalid data in one or more controls! " +
                    "Make sure you provided a valid path and a name that has " +
                    "not already been used for a save.", "Invalid data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Functions

        //Check that all form controls have valid data.
        private bool FormIsValid()
        {
            if (!File.Exists(TxtboxSaveGameFilePath.Text))
                return false;
            if (TxtboxName.Text == "")
                return false;
            if (File.Exists(Global.SavesFolderPath + "\\" + TxtboxName.Text + ".txt"))
                return false;

            return true;
        }

        #endregion
    }
}