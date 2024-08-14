using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Cultic_SE
{
    public partial class Form1 : Form
    {
         //Version and newest version address.
        private string version = "1.0";
        private string versionAddress = "https://pastebin.com/raw/1ibswsA9";

        // String to save the file path
        // XElement to navigate the XML file
        // List of interesting elements I want to navigate separately.
        private string savePath { get; set; }
        private XElement reader { get; set; }
        private List<XElement> elements { get; set; }

        public Form1()
        {
            InitializeComponent();
            elements = new List<XElement>();
        }

        /// <summary>
        /// Iterate through elements and import the values to GUI.
        /// </summary>
        private void loadData()
        {
            // Load general data from special elements in list.
            foreach(var x in elements)
            {
                switch(x.Name+"")
                {
                    case "playerHP": playerHP.Value = int.Parse(x.Value); break;
                    /*case "playerWeapon": weapon.Value = int.Parse(x.Value); break;
                    case "playerOffHand": offhandWeapon.Value = int.Parse(x.Value); break;*/
                    case "playerImbuements": playerImbues.Value = int.Parse(x.Value); break;
                    case "playerWeaponParts": weaponParts.Value = int.Parse(x.Value); break;
                    case "gameDifficulty": gameDiff.SelectedIndex = int.Parse(x.Value); break;
                    //case "playerCurrentEquipment": playerEquip.Value = int.Parse(x.Value); break;
                    case "saveFileName": saveFileName.Text = x.Value; break;
                    case "isCustomDifficulty": isCustom.Checked = (x.Value.Equals("true")); break;
                    default: break;
                }
            }

            clearForm();
            // Read playerAmmo values from reader.
            foreach (var x in reader.Elements().Descendants("playerAmmo").Descendants())
                playerAmmo.Items.Add(x.Value);

            // Read playerMaxAmmo values from reader.
            foreach (var x in reader.Elements().Descendants("playerMaxAmmo").Descendants())
                playerMaxAmmo.Items.Add(x.Value);


            //TODO: Enable Form
        }

        /// <summary>
        /// Save the values from the GUI to the save file.
        /// </summary>
        private void saveData()
        {
            foreach (var x in elements)
            {
                switch (x.Name + "")
                {
                    case "playerHP": x.SetValue(playerHP.Value); break;
                    /*case "playerWeapon": x.SetValue(weapon.Value); break;
                    case "playerOffHand": x.SetValue(offhandWeapon.Value); break;*/
                    case "playerImbuements": x.SetValue(playerImbues.Value); break;
                    case "playerWeaponParts": x.SetValue(weaponParts.Value); break;
                    case "gameDifficulty": x.SetValue(gameDiff.SelectedIndex); break;
                    //case "playerCurrentEquipment": x.SetValue(playerEquip.Value); break;
                    case "saveFileName": x.SetValue(saveFileName.Text); break;
                    case "isCustomDifficulty": x.SetValue((isCustom.Checked) ? "true" : "false"); break;
                    default: break;
                }
            }

            // Unlock all upgrades if checked:
            // Ability position:    0   1   2   3   19  20  21  22  38  39  40  41  57  58  59  60
            // Ability value:       4   1   1   1   2   1   2   2   2   2   2   2   1   1   2   1
            int pos = 0;
            if (unlockUpgrades.Checked)
                foreach (var x in reader.Elements().Descendants("playerUpgrades").Descendants())
                {
                    // Player health ability.
                    if (pos == 0)
                        x.SetValue(4);
                    // Special values for various abilities.
                    else if ((pos >= 21 && pos <= 22) || pos == 19 || pos == 40 || pos == 41 || pos == 59 || (pos >= 38 && pos <= 41))
                        x.SetValue(2);
                    else
                        x.SetValue(1);

                    pos++;
                }

            // Max out ammo if checked:
            if (maxAmmo.Checked)
            {
                foreach (var x in reader.Elements().Descendants("playerAmmo").Descendants())
                    x.SetValue(999999);

                foreach (var x in reader.Elements().Descendants("playerMaxAmmo").Descendants())
                    x.SetValue(999999);
            }

            reader.Save(savePath);
        }

        /// <summary>
        /// Read XML save data by looping through specific elements.
        /// </summary>
        /// <param name="path">File path to the CULTIC .sav data.</param>
        private void readData(String path)
        {
            try
            {
                reader = XElement.Load(path);

                // Read playerData elements.
                foreach (var x in reader.Element("playerData").Elements())
                    elements.Add(x);

                // Read remaining data:
                foreach(var x in reader.Elements())
                {
                    // if data has sub values, loop through them.
                    if (x.HasElements)
                    {
                        foreach(var y in reader.Elements().Descendants())
                        {
                            if (y.Parent.Name == "dictionaryItem")
                                continue;
                            elements.Add(y);
                        }
                    }
                    else
                    {
                        elements.Add(x);
                    }
                }

                loadData();
            }
            catch(Exception ex)
            {
                displayMessage(ex.Message);
            }
        }



        /// <summary>
        /// Display a popup message.
        /// </summary>
        /// <param name="message"></param>
        private void displayMessage(String message)
        {
            MessageBox.Show(message);
        }
        private void clearForm()
        {
            playerAmmo.Items.Clear();
            playerMaxAmmo.Items.Clear();
        }

        /// <summary>
        /// Open a file dialog and let the user choose the CULTIC save. (ps dont trust the user)
        /// If the user opens a file read the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click_1(object sender, EventArgs e)
        {
            // Allow user to choose .sav file with a dialog. (Todo: save path for future?)
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(fileDialog.FileName))
                {
                    displayMessage("Error reading file.");
                    return;
                }

                savePath = fileDialog.FileName;
                readData(savePath);
            }
        }

        /// <summary>
        /// If the file exists, save the file. TODO: Wipe info from savePath, and controls?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(savePath))
                saveData();
            else
                displayMessage("Could not locate save, try locating a valid .sav file.");
        }

        /// <summary>
        /// Check for updates and then display credit for the program. You sexy bastard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            string newVersion = version;
            string about = String.Format("Developer: NerdGuyMan");

            using (WebClient client = new WebClient())
            {
                try
                {
                    newVersion = client.DownloadString(versionAddress);
                    if (newVersion.CompareTo(version) > 0)
                        about += String.Format("\n(New update available: {0})", newVersion);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show(about, "Version " + version, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
