using Pepris.Controls;

namespace Pepris {
    public partial class frmConfig : Form {
        public Color primary = Color.White;
        Sounds sounds = new Sounds();
        Settings settings = new Settings();
        WindowsSymbols symbols = new WindowsSymbols();
        dlgSelect select = new();
        dlgInput input = new();
        string[] moveKeys = ["Left", "NumPad4", "Right", "NumPad6", "Down", "NumPad2", "Space", "NumPad8", "Up", "NumPad5", "ShiftKey", "NumPad0", "Escape", "None"];

        public frmConfig() {
            InitializeComponent();
            try {
                InitializeSettings();
            } catch { 
            }

            tabControl.Location = new Point(285, 0);
            tabControl.Size = new Size(428, 589);
            WindowEffects.useDarkBorder(this.Handle, true);
            this.CancelButton = dialogTitle1.btnClose;
            symbols.ApplySymbol("add", btnAddBackgroundImage);
            symbols.ApplySymbol("edit", btnEditBackgroundImage);
            symbols.ApplySymbol("delete", btnRemoveBackgroundImage);
        }
        private void InitializeSettings() {
            //controls
            moveKeys = settings.GetSettingStringArray("moveKeys");
            keyMoveLeft.SelectedKey = settings.ParseKey(moveKeys[0]);
            keyMoveLeft2.SelectedKey = settings.ParseKey(moveKeys[1]);
            keyMoveRight.SelectedKey = settings.ParseKey(moveKeys[2]);
            keyMoveRight2.SelectedKey = settings.ParseKey(moveKeys[3]);
            keySoftDrop.SelectedKey = settings.ParseKey(moveKeys[4]);
            keySoftDrop2.SelectedKey = settings.ParseKey(moveKeys[5]);
            keyHardDrop.SelectedKey = settings.ParseKey(moveKeys[6]);
            keyHardDrop2.SelectedKey = settings.ParseKey(moveKeys[7]);
            keyRotateClockwise.SelectedKey = settings.ParseKey(moveKeys[8]);
            keyRotateClockwise2.SelectedKey = settings.ParseKey(moveKeys[9]);
            keyHold.SelectedKey = settings.ParseKey(moveKeys[10]);
            keyHold2.SelectedKey = settings.ParseKey(moveKeys[11]);
            keyQuit.SelectedKey = settings.ParseKey(moveKeys[12]);
            keyQuit2.SelectedKey = settings.ParseKey(moveKeys[13]);
            //handling

            //audio & volume
            chkSfx.Checked = settings.GetSettingBool("useSfx");
            trackSfxVol.Value = settings.GetSettingInt("sfxVolume");

            //video & interface
            trackScale.Value = settings.GetSettingInt("pointSize");
            chkBoardBounce.Checked = settings.GetSettingBool("boardBounce");
            trackOpacity.Value = (int)(settings.GetSettingDouble("boardOpacity") * 100);
            //customization
            chkAllowCustomBgColors.Checked = settings.GetSettingBool("allowCustomBgColors");
            chkUseBackground.Checked = settings.GetSettingBool("useBackground");
            lstBgImgs.Items.AddRange(settings.GetSettingStringArray("backgrounds"));
        }

        private void frmConf_FormClosing(object sender, FormClosingEventArgs e) {
            sounds.Play(sounds.back);
        }
        #region controls
        private void keyMoveLeft_SelectedKeyChanged(object sender, EventArgs e) {
            // key binds
            KeyBox kb = sender as KeyBox;

            if (kb.SelectedKey != null) {
                moveKeys[int.Parse(kb.Tag.ToString())] = kb.SelectedKey.ToString();
                settings.SaveSetting("moveKeys", moveKeys);
            }
        }
        #endregion
        #region handling

        #endregion
        #region audio & volume
        private void togSfx_CheckedChanged(object sender, EventArgs e) {
            // allow the game to play sound effects
            settings.SaveSetting("useSfx", chkSfx.Checked.ToString());
        }
        private void trackSfxVol_Scroll(object sender, EventArgs e) {
            // sound effects volume
            settings.SaveSetting("sfxVolume", trackSfxVol.Value.ToString());
            sounds.Play(sounds.hover);
        }
        #endregion
        #region video & interface
        private void trackScale_Scroll(object sender, EventArgs e) {
            // scale of the tetrominoes
            settings.SaveSetting("pointSize", trackScale.Value.ToString());
        }
        private void togBoardBounce_CheckedChanged(object sender, EventArgs e) {
            // allow the board to move arround the screen
            settings.SaveSetting("boardBounce", chkBoardBounce.Checked.ToString());
        }
        private void trackOpacity_Scroll(object sender, EventArgs e) {
            // opacity of the board
            double opacity = (double)trackOpacity.Value / 100; // since a form opacity is an value between 0 and 1. we are dividing it by 100, so 50 becames 0.5
            settings.SaveSetting("boardOpacity", opacity.ToString());
        }
        #endregion
        #region customization
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            // show background images
            settings.SaveSetting("useBackground", chkUseBackground.Checked.ToString());
        }
        private void checkAllowCustomColors_CheckedChanged(object sender, EventArgs e) {
            // pick a random color from the background to paint the UI
            settings.SaveSetting("allowCustomBgColors", chkAllowCustomBgColors.Checked.ToString());
        }
        private void btnRemoveBackgroundImage_Click(object sender, EventArgs e) {
            // remove a image path from the backgrounds list
            foreach (string s in lstBgImgs.SelectedItems.OfType<string>().ToList()) {
                lstBgImgs.Items.Remove(s);
            }
            saveBackgrounds();
        }
        private void btnEditBackgroundImage_Click(object sender, EventArgs e) {
            // edit a image path from the backgrounds list
            List<string> oldItems = new List<string>();
            List<string> newItems = new List<string>();

            foreach (string s in lstBgImgs.SelectedItems.OfType<string>().ToList()) {
                oldItems.Add(s);
                lstBgImgs.Items.Remove(s);
            }

            foreach (string s in oldItems) {
                newItems.Add(input.getInput("Edit item", "Edit \"" + s + "\"", s, true, "edit"));
            }

            lstBgImgs.Items.AddRange(newItems.ToArray());
            saveBackgrounds();
        }
        private void btnAddBackgroundImage_Click(object sender, EventArgs e) {
            // add a image path to the backgrounds list
            int addMode = select.getAnswer(["From file", "From folder", "From URL"], ["file", "folder", "link"], "Insert image");

            if (select.DialogResult == DialogResult.Cancel) return;

            switch (addMode) {
                case 0: // add file
                    if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                        foreach (string filePath in openFileDialog1.FileNames) {
                            lstBgImgs.Items.Add(filePath);
                        }
                    }
                    break;
                case 1: // add folder
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                        lstBgImgs.Items.Add(folderBrowserDialog1.SelectedPath);
                    }
                    break;
                case 2: // add url
                    string url = input.getInput("Insert image URL", "Enter the desired image below", "", true, "link");

                    if (url != null && Uri.IsWellFormedUriString(url, UriKind.Absolute)) {
                        lstBgImgs.Items.Add(url);
                    }
                    break;
            }

            saveBackgrounds();
        }
        private void saveBackgrounds() {
            // save current backgrounds list
            List<string> backPaths = new List<string>();

            foreach (string item in lstBgImgs.Items) {
                backPaths.Add(item);
            }

            settings.SaveSetting("backgrounds", backPaths.ToArray());
        }
        #endregion

        private void btnTabControls_Click(object sender, EventArgs e) {
            Button btn = sender as Button;

            if (btn != null && btn.Tag != null) {
                string tabPageName = btn.Tag.ToString();

                foreach (TabPage tabPage in tabControl.TabPages) {
                    if (tabPage.Name == tabPageName) {
                        tabControl.SelectedTab = tabPage;
                        break;
                    }
                }
            }
        }

        private async void ButtonFocused(object sender, EventArgs e) {
            foreach (Control con in panel1.Controls) {
                if (con is Button unfocused) {
                    unfocused.BackColor = Color.FromArgb(32, 32, 32);
                    unfocused.ForeColor = primary;
                    unfocused.Padding = new Padding(20, 0, 0, 0);
                }
            }
            if (sender is Button focused) {
                focused.BackColor = primary;
                focused.ForeColor = Color.FromArgb(32, 32, 32);
                for (int i = 20; i <= 40; i += 2) {
                    focused.Padding = new Padding(i, 0, 0, 0);
                    await Task.Delay(1);
                }
            }
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LinkLabel lnk = sender as LinkLabel;
            string link = lnk.Tag.ToString();
            System.Diagnostics.Process.Start("explorer", link);
        }
    }
}
