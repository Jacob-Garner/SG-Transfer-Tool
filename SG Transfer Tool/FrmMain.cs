using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using SG_Transfer_Tool.Forms;
using SG_Transfer_Tool.Classes;

namespace SG_Transfer_Tool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Variables

        private string[] saves = null;
        private string saveGameFolderPath = null;
        private string saveGameFilePath = null;

        #endregion

        #region Enums

        private enum GameToggle
        {
            Start,
            Stop
        }

        #endregion

        #region Events

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Load data from files.
            try
            {
                saves = Global.ReadSaves();
                LoadSaves();
                LoadPaths();

                MnuStpMain.Select();
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error while loading app data. Please contact the dev with " +
                    "details of the error shown below:\n\n" + ex.Message + "\n\n\nThe app will now close", 
                    "App data missing or corrupt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void MenBtnSettings_Click(object sender, EventArgs e)
        {
            //Display the settings form to the user.
            this.Enabled = false;

            using (FrmSettings settingsWindow = new FrmSettings())
            {
                settingsWindow.ShowDialog();
            }

            LoadPaths();
            MnuStpMain.Select();
            this.Enabled = true;
        }

        private void MenBtnNewFromFile_Click(object sender, EventArgs e)
        {
            //Let the user select a file to make a save from.
            try
            {
                string filePath = "";

                using (OpenFileDialog fileBrowser = new OpenFileDialog())
                {
                    fileBrowser.Filter = "SaveGame files|*.txt";

                    if (fileBrowser.ShowDialog() == DialogResult.OK)
                    {
                        filePath = fileBrowser.FileName;

                        //Display the add new form to the user, with the selected 
                        //GameSave file loaded.
                        this.Enabled = false;

                        using (FrmAddNew addNewWindow = new FrmAddNew(filePath))
                        {
                            addNewWindow.ShowDialog();
                        }
                    }
                }

                LoadSaves();
                MnuStpMain.Select();
                this.Enabled = true;
            }

            catch
            {
                MessageBox.Show("There was an error while opening the selected file.", "File open error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenBtnFromCurrentSave_Click(object sender, EventArgs e)
        {
            //Display the add new form to the user, with the current 
            //game GameSave file loaded.
            this.Enabled = false;

            using (FrmAddNew addNewWindow = new FrmAddNew(saveGameFilePath))
            {
                addNewWindow.ShowDialog();
            }

            LoadSaves();
            MnuStpMain.Select();
            this.Enabled = true;
        }

        private void MenBtnRemoveAll_Click(object sender, EventArgs e)
        {
            //Remove all of the save files.
            if (MessageBox.Show("Are you sure you want to remove all saves?", "Remove all saves", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    DirectoryInfo savesDirectory = new DirectoryInfo(Global.SavesFolderPath);
                    FileInfo[] files = savesDirectory.GetFiles("*.txt");

                    foreach (FileInfo file in files)
                    {
                        if (file.Name != "DummyFile (do not remove!).txt")
                            File.Delete(Global.SavesFolderPath + "\\" + file.Name);
                    }

                    LoadSaves();
                }

                catch
                {
                    MessageBox.Show("There was an error while removing the saves. " +
                        "Some or all saves may not have been removed.", "Save remove error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenBtnRemoveSelected_Click(object sender, EventArgs e)
        {
            //Remove the selected save file.
            try
            {
                if (LstboxSaves.SelectedItems.Count == 1)
                {
                    int selectedIndex = LstboxSaves.SelectedIndex;
                    string selectedSave = LstboxSaves.Items[selectedIndex].ToString();
                    File.Delete(Global.SavesFolderPath + "\\" + selectedSave);

                    LoadSaves();
                }

                else
                {
                    if (LstboxSaves.SelectedItems.Count <= 0)
                    {
                        MessageBox.Show("Please select a save to remove.", "No save selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        MessageBox.Show("Please select only one save to remove.", "Too many saves selected",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            catch
            {
                MessageBox.Show("There was an error while removing the selected save. " +
                    "Please try again.", "Save remove error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadSelectedSave_Click(object sender, EventArgs e)
        {
            //Load the selected save file.
            try
            {
                if (LstboxSaves.SelectedItems.Count == 1)
                {
                    ToggleGame(GameToggle.Stop);

                    int selectedIndex = LstboxSaves.SelectedIndex;
                    string selectedSave = LstboxSaves.Items[selectedIndex].ToString();

                    File.Copy(Global.SavesFolderPath + "\\" + selectedSave,
                        Global.ReadSettings().Item1 + "\\" + "SaveGame.txt", true);

                    ToggleGame(GameToggle.Start);
                }

                else
                {
                    if (LstboxSaves.SelectedItems.Count <= 0)
                    {
                        MessageBox.Show("Please select a save to load.", "No save selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        MessageBox.Show("Please select only one save to load.", "Too many saves selected",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            catch
            {
                MessageBox.Show("There was an error while loading the selected save. " +
                    "Please try again.", "Save load error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Functions

        //Closes or opens the game.
        private void ToggleGame(GameToggle toggle)
        {
            if (toggle == GameToggle.Start)
                Process.Start(Global.ReadSettings().Item2);

            else if (toggle == GameToggle.Stop)
            {
                Process[] game = Process.GetProcessesByName("TheMessenger");

                if (game.Length > 0)
                    game[0].CloseMainWindow();
            }
        }

        //Load LstboxSaves with all the saves.
        private void LoadSaves()
        {
            saves = Global.ReadSaves();
            Array.Sort(saves, (a, b) => string.Compare(a, b));
            LstboxSaves.Items.Clear();

            foreach (string save in saves)
                LstboxSaves.Items.Add(save);
        }

        //Loads the path of the SaveGame folder and file.
        private void LoadPaths()
        {
            try
            {
                saveGameFolderPath = Global.ReadSettings().Item1;
                saveGameFilePath = saveGameFolderPath + @"\SaveGame.txt";
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error while trying to load app path settings. " +
                    "Please contact the dev with details of the error shown below:\n\n" + ex.Message,
                    "Path load error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}