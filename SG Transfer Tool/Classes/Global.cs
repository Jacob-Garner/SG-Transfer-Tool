using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SG_Transfer_Tool.Classes
{
    public class Global
    {
        #region Variables

        public static readonly string SettingsFilePath = @"Data\Settings.txt";
        public static readonly string SavesFolderPath = @"Data\Saves";

        #endregion

        #region Functions

        //Reads and returns the list of all saves.
        public static string[] ReadSaves()
        {
            List<string> saves = new List<string>();

            try
            {
                DirectoryInfo savesDirectory = new DirectoryInfo(SavesFolderPath);
                FileInfo[] files = savesDirectory.GetFiles("*.txt");

                foreach (FileInfo file in files)
                {
                    if (file.Name != "DummyFile (do not remove!).txt")
                        saves.Add(file.Name);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an internal app error. Please contact the dev with " +
                    "details of the error shown below:\n\n" + ex.Message,
                    "Internal app error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return saves.ToArray();
        }

        //Save the app settings (which are just paths).
        public static void WriteSettings(string[] paths)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(SettingsFilePath))
                {
                    foreach (string path in paths)
                        writer.WriteLine(path);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an internal app error. Please contact the dev with " +
                    "details of the error shown below:\n\n" + ex.Message,
                    "Internal app error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Read and return the app settings (which are just paths).
        public static Tuple<string, string> ReadSettings()
        {
            string[] settings = null;

            try
            {
                settings = File.ReadAllLines(SettingsFilePath);
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an internal app error. Please contact the dev with " +
                    "details of the error shown below:\n\n" + ex.Message,
                    "Internal app error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new Tuple<string, string>(settings[0], settings[1]);
        }

        #endregion
    }
}