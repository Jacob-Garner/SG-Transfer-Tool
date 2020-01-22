using System;
using System.IO;
using System.Windows.Forms;
using SG_Transfer_Tool.Classes;

namespace SG_Transfer_Tool.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        #region Variables



        #endregion

        #region Events

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            //Load the saved SaveGame folder path.
            try
            {
                TxtboxSaveGameFolderPath.Text = Global.ReadSettings().Item1;
                TxtboxGamePath.Text = Global.ReadSettings().Item2;
                BtnSave.Select();
            }

            catch
            {
                MessageBox.Show("There was an error while loading settings. " +
                        "Please try again.", "Load error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBrowseGameFolder_Click(object sender, EventArgs e)
        {
            //Let the user browse for a folder.
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    TxtboxSaveGameFolderPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void BtnBrowseGame_Click(object sender, EventArgs e)
        {
            //Let the user browse for the game.
            using (OpenFileDialog fileBrowser = new OpenFileDialog())
            {
                fileBrowser.Filter = "exe|*.exe|shortcut|*.lnk";

                if (fileBrowser.ShowDialog() == DialogResult.OK)
                {
                    TxtboxGamePath.Text = fileBrowser.FileName;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Save all the changes the user made.
            if (FormIsValid())
            {
                try
                {
                    string[] paths = { TxtboxSaveGameFolderPath.Text, TxtboxGamePath.Text };

                    Global.WriteSettings(paths);
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("There was an error while saving the selected path to settings. " +
                        "Please try again.", "Save error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("The folder or file path you chose is invalid! " +
                    "Please try again.", "Path invalid",
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
            if (!Directory.Exists(TxtboxSaveGameFolderPath.Text))
                return false;
            if (!File.Exists(TxtboxGamePath.Text))
                return false;

            return true;
        }

        #endregion
    }
}