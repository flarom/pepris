namespace Pepris {
    partial class frmConfig {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            trackScale = new TrackBar();
            label9 = new Label();
            label7 = new Label();
            keyQuit2 = new Controls.KeyBox();
            keyQuit = new Controls.KeyBox();
            keyHold2 = new Controls.KeyBox();
            keyRotateClockwise2 = new Controls.KeyBox();
            keyHardDrop2 = new Controls.KeyBox();
            keySoftDrop2 = new Controls.KeyBox();
            keyMoveRight2 = new Controls.KeyBox();
            keyMoveLeft2 = new Controls.KeyBox();
            keyHold = new Controls.KeyBox();
            keyRotateClockwise = new Controls.KeyBox();
            keyHardDrop = new Controls.KeyBox();
            keySoftDrop = new Controls.KeyBox();
            keyMoveRight = new Controls.KeyBox();
            keyMoveLeft = new Controls.KeyBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            label10 = new Label();
            btnRemoveBackgroundImage = new Button();
            btnEditBackgroundImage = new Button();
            btnAddBackgroundImage = new Button();
            label15 = new Label();
            linkBsky = new LinkLabel();
            linkWebsite = new LinkLabel();
            linkGithub = new LinkLabel();
            label14 = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tabControl = new TabControl();
            tabControls = new TabPage();
            tabHandling = new TabPage();
            tabAudio = new TabPage();
            chkSfx = new CheckBox();
            label12 = new Label();
            label13 = new Label();
            trackSfxVol = new TrackBar();
            tabVideo = new TabPage();
            chkBoardBounce = new CheckBox();
            trackOpacity = new TrackBar();
            label11 = new Label();
            label8 = new Label();
            tabCustomization = new TabPage();
            chkAllowCustomBgColors = new CheckBox();
            chkUseBackground = new CheckBox();
            lstBgImgs = new ListBox();
            tabAbout = new TabPage();
            label17 = new Label();
            pictureBox2 = new PictureBox();
            label16 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnTabAbout = new Button();
            btnTabCustomization = new Button();
            btnTabVideo = new Button();
            btnTabAudio = new Button();
            btnTabHandling = new Button();
            btnTabControls = new Button();
            dialogTitle1 = new Controls.DialogTitleBar();
            ((System.ComponentModel.ISupportInitialize)trackScale).BeginInit();
            tabControl.SuspendLayout();
            tabControls.SuspendLayout();
            tabAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackSfxVol).BeginInit();
            tabVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackOpacity).BeginInit();
            tabCustomization.SuspendLayout();
            tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // trackScale
            // 
            trackScale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackScale.Location = new Point(10, 35);
            trackScale.Margin = new Padding(5);
            trackScale.Maximum = 30;
            trackScale.Minimum = 20;
            trackScale.Name = "trackScale";
            trackScale.Size = new Size(377, 45);
            trackScale.TabIndex = 0;
            trackScale.Value = 20;
            trackScale.Scroll += trackScale_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Help;
            label9.Location = new Point(10, 10);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 0;
            label9.Text = "Tetrominoes scale";
            toolTip1.SetToolTip(label9, "The size of the blocks");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 183);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 21;
            label7.Text = "Quit game";
            // 
            // keyQuit2
            // 
            keyQuit2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyQuit2.BackColor = Color.White;
            keyQuit2.BorderStyle = BorderStyle.FixedSingle;
            keyQuit2.Location = new Point(313, 179);
            keyQuit2.Name = "keyQuit2";
            keyQuit2.SelectedKey = Keys.None;
            keyQuit2.Size = new Size(100, 23);
            keyQuit2.TabIndex = 20;
            keyQuit2.Tag = "13";
            keyQuit2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyQuit
            // 
            keyQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyQuit.BackColor = Color.White;
            keyQuit.BorderStyle = BorderStyle.FixedSingle;
            keyQuit.Location = new Point(207, 179);
            keyQuit.Name = "keyQuit";
            keyQuit.SelectedKey = Keys.Escape;
            keyQuit.Size = new Size(100, 23);
            keyQuit.TabIndex = 19;
            keyQuit.Tag = "12";
            keyQuit.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyHold2
            // 
            keyHold2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyHold2.BackColor = Color.White;
            keyHold2.BorderStyle = BorderStyle.FixedSingle;
            keyHold2.Location = new Point(313, 150);
            keyHold2.Name = "keyHold2";
            keyHold2.SelectedKey = Keys.NumPad0;
            keyHold2.Size = new Size(100, 23);
            keyHold2.TabIndex = 18;
            keyHold2.Tag = "11";
            keyHold2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyRotateClockwise2
            // 
            keyRotateClockwise2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyRotateClockwise2.BackColor = Color.White;
            keyRotateClockwise2.BorderStyle = BorderStyle.FixedSingle;
            keyRotateClockwise2.Location = new Point(313, 121);
            keyRotateClockwise2.Name = "keyRotateClockwise2";
            keyRotateClockwise2.SelectedKey = Keys.NumPad5;
            keyRotateClockwise2.Size = new Size(100, 23);
            keyRotateClockwise2.TabIndex = 17;
            keyRotateClockwise2.Tag = "9";
            keyRotateClockwise2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyHardDrop2
            // 
            keyHardDrop2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyHardDrop2.BackColor = Color.White;
            keyHardDrop2.BorderStyle = BorderStyle.FixedSingle;
            keyHardDrop2.Location = new Point(313, 92);
            keyHardDrop2.Name = "keyHardDrop2";
            keyHardDrop2.SelectedKey = Keys.NumPad8;
            keyHardDrop2.Size = new Size(100, 23);
            keyHardDrop2.TabIndex = 16;
            keyHardDrop2.Tag = "7";
            keyHardDrop2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keySoftDrop2
            // 
            keySoftDrop2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keySoftDrop2.BackColor = Color.White;
            keySoftDrop2.BorderStyle = BorderStyle.FixedSingle;
            keySoftDrop2.Location = new Point(313, 63);
            keySoftDrop2.Name = "keySoftDrop2";
            keySoftDrop2.SelectedKey = Keys.NumPad2;
            keySoftDrop2.Size = new Size(100, 23);
            keySoftDrop2.TabIndex = 15;
            keySoftDrop2.Tag = "5";
            keySoftDrop2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyMoveRight2
            // 
            keyMoveRight2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyMoveRight2.BackColor = Color.White;
            keyMoveRight2.BorderStyle = BorderStyle.FixedSingle;
            keyMoveRight2.Location = new Point(313, 34);
            keyMoveRight2.Name = "keyMoveRight2";
            keyMoveRight2.SelectedKey = Keys.NumPad6;
            keyMoveRight2.Size = new Size(100, 23);
            keyMoveRight2.TabIndex = 14;
            keyMoveRight2.Tag = "3";
            keyMoveRight2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyMoveLeft2
            // 
            keyMoveLeft2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyMoveLeft2.BackColor = Color.White;
            keyMoveLeft2.BorderStyle = BorderStyle.FixedSingle;
            keyMoveLeft2.Location = new Point(313, 6);
            keyMoveLeft2.Name = "keyMoveLeft2";
            keyMoveLeft2.SelectedKey = Keys.NumPad4;
            keyMoveLeft2.Size = new Size(100, 23);
            keyMoveLeft2.TabIndex = 13;
            keyMoveLeft2.Tag = "1";
            keyMoveLeft2.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyHold
            // 
            keyHold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyHold.BackColor = Color.White;
            keyHold.BorderStyle = BorderStyle.FixedSingle;
            keyHold.Location = new Point(207, 150);
            keyHold.Name = "keyHold";
            keyHold.SelectedKey = Keys.ShiftKey;
            keyHold.Size = new Size(100, 23);
            keyHold.TabIndex = 12;
            keyHold.Tag = "10";
            keyHold.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyRotateClockwise
            // 
            keyRotateClockwise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyRotateClockwise.BackColor = Color.White;
            keyRotateClockwise.BorderStyle = BorderStyle.FixedSingle;
            keyRotateClockwise.Location = new Point(207, 121);
            keyRotateClockwise.Name = "keyRotateClockwise";
            keyRotateClockwise.SelectedKey = Keys.Up;
            keyRotateClockwise.Size = new Size(100, 23);
            keyRotateClockwise.TabIndex = 11;
            keyRotateClockwise.Tag = "8";
            keyRotateClockwise.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyHardDrop
            // 
            keyHardDrop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyHardDrop.BackColor = Color.White;
            keyHardDrop.BorderStyle = BorderStyle.FixedSingle;
            keyHardDrop.Location = new Point(207, 92);
            keyHardDrop.Name = "keyHardDrop";
            keyHardDrop.SelectedKey = Keys.Space;
            keyHardDrop.Size = new Size(100, 23);
            keyHardDrop.TabIndex = 10;
            keyHardDrop.Tag = "6";
            keyHardDrop.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keySoftDrop
            // 
            keySoftDrop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keySoftDrop.BackColor = Color.White;
            keySoftDrop.BorderStyle = BorderStyle.FixedSingle;
            keySoftDrop.Location = new Point(207, 63);
            keySoftDrop.Name = "keySoftDrop";
            keySoftDrop.SelectedKey = Keys.Down;
            keySoftDrop.Size = new Size(100, 23);
            keySoftDrop.TabIndex = 9;
            keySoftDrop.Tag = "4";
            keySoftDrop.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyMoveRight
            // 
            keyMoveRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyMoveRight.BackColor = Color.White;
            keyMoveRight.BorderStyle = BorderStyle.FixedSingle;
            keyMoveRight.Location = new Point(207, 35);
            keyMoveRight.Name = "keyMoveRight";
            keyMoveRight.SelectedKey = Keys.Right;
            keyMoveRight.Size = new Size(100, 23);
            keyMoveRight.TabIndex = 8;
            keyMoveRight.Tag = "2";
            keyMoveRight.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // keyMoveLeft
            // 
            keyMoveLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyMoveLeft.BackColor = Color.White;
            keyMoveLeft.BorderStyle = BorderStyle.FixedSingle;
            keyMoveLeft.Location = new Point(207, 6);
            keyMoveLeft.Name = "keyMoveLeft";
            keyMoveLeft.RightToLeft = RightToLeft.No;
            keyMoveLeft.SelectedKey = Keys.Left;
            keyMoveLeft.Size = new Size(100, 23);
            keyMoveLeft.TabIndex = 7;
            keyMoveLeft.Tag = "0";
            keyMoveLeft.SelectedKeyChanged += keyMoveLeft_SelectedKeyChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 125);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 5;
            label6.Text = "Rotate clockwise";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 154);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 4;
            label5.Text = "Swap hold piece";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 96);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Hard drop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 67);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Soft drop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 41);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "Move falling piece right";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 14);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 0;
            label2.Text = "Move falling piece left";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Help;
            label10.Location = new Point(8, 75);
            label10.Name = "label10";
            label10.Padding = new Padding(5);
            label10.Size = new Size(133, 25);
            label10.TabIndex = 8;
            label10.Text = "Background image(s):";
            toolTip1.SetToolTip(label10, "The images that will be randomly selected and displayed as wallpapers");
            // 
            // btnRemoveBackgroundImage
            // 
            btnRemoveBackgroundImage.Cursor = Cursors.Hand;
            btnRemoveBackgroundImage.FlatAppearance.BorderSize = 0;
            btnRemoveBackgroundImage.FlatStyle = FlatStyle.Flat;
            btnRemoveBackgroundImage.Location = new Point(84, 246);
            btnRemoveBackgroundImage.Name = "btnRemoveBackgroundImage";
            btnRemoveBackgroundImage.Size = new Size(32, 32);
            btnRemoveBackgroundImage.TabIndex = 5;
            btnRemoveBackgroundImage.Text = "delete";
            toolTip1.SetToolTip(btnRemoveBackgroundImage, "Remove the selected items from the list");
            btnRemoveBackgroundImage.UseVisualStyleBackColor = true;
            btnRemoveBackgroundImage.Click += btnRemoveBackgroundImage_Click;
            // 
            // btnEditBackgroundImage
            // 
            btnEditBackgroundImage.Cursor = Cursors.Hand;
            btnEditBackgroundImage.FlatAppearance.BorderSize = 0;
            btnEditBackgroundImage.FlatStyle = FlatStyle.Flat;
            btnEditBackgroundImage.Location = new Point(46, 246);
            btnEditBackgroundImage.Name = "btnEditBackgroundImage";
            btnEditBackgroundImage.Size = new Size(32, 32);
            btnEditBackgroundImage.TabIndex = 4;
            btnEditBackgroundImage.Text = "edit";
            toolTip1.SetToolTip(btnEditBackgroundImage, "Edit selected item");
            btnEditBackgroundImage.UseVisualStyleBackColor = true;
            btnEditBackgroundImage.Click += btnEditBackgroundImage_Click;
            // 
            // btnAddBackgroundImage
            // 
            btnAddBackgroundImage.Cursor = Cursors.Hand;
            btnAddBackgroundImage.FlatAppearance.BorderSize = 0;
            btnAddBackgroundImage.FlatStyle = FlatStyle.Flat;
            btnAddBackgroundImage.Location = new Point(8, 246);
            btnAddBackgroundImage.Name = "btnAddBackgroundImage";
            btnAddBackgroundImage.Size = new Size(32, 32);
            btnAddBackgroundImage.TabIndex = 3;
            btnAddBackgroundImage.Text = "add";
            toolTip1.SetToolTip(btnAddBackgroundImage, "Add an item");
            btnAddBackgroundImage.UseVisualStyleBackColor = true;
            btnAddBackgroundImage.Click += btnAddBackgroundImage_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Cursor = Cursors.Help;
            label15.Location = new Point(10, 114);
            label15.Margin = new Padding(5);
            label15.Name = "label15";
            label15.Size = new Size(80, 15);
            label15.TabIndex = 5;
            label15.Text = "Board opacity";
            toolTip1.SetToolTip(label15, "How transparent the board is");
            // 
            // linkBsky
            // 
            linkBsky.AutoSize = true;
            linkBsky.Location = new Point(180, 70);
            linkBsky.Name = "linkBsky";
            linkBsky.Padding = new Padding(0, 5, 5, 5);
            linkBsky.Size = new Size(107, 25);
            linkBsky.TabIndex = 2;
            linkBsky.TabStop = true;
            linkBsky.Tag = "https://flarom.bsky.social";
            linkBsky.Text = "flarom.bsky.social";
            linkBsky.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(linkBsky, "https://flarom.bsky.social");
            linkBsky.LinkClicked += LinkClicked;
            // 
            // linkWebsite
            // 
            linkWebsite.AutoSize = true;
            linkWebsite.Location = new Point(6, 70);
            linkWebsite.Name = "linkWebsite";
            linkWebsite.Padding = new Padding(0, 5, 5, 5);
            linkWebsite.Size = new Size(87, 25);
            linkWebsite.TabIndex = 0;
            linkWebsite.TabStop = true;
            linkWebsite.Tag = "https://flarom.github.io/pepris-page";
            linkWebsite.Text = "Pepris website";
            linkWebsite.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(linkWebsite, "https://flarom.github.io/pepris-page");
            linkWebsite.LinkClicked += LinkClicked;
            // 
            // linkGithub
            // 
            linkGithub.AutoSize = true;
            linkGithub.Location = new Point(99, 70);
            linkGithub.Name = "linkGithub";
            linkGithub.Padding = new Padding(0, 5, 5, 5);
            linkGithub.Size = new Size(75, 25);
            linkGithub.TabIndex = 1;
            linkGithub.TabStop = true;
            linkGithub.Tag = "https://github.com/flarom/pepris";
            linkGithub.Text = "Github repo";
            linkGithub.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(linkGithub, "https://github.com/flarom/pepris");
            linkGithub.LinkClicked += LinkClicked;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 37);
            label14.Margin = new Padding(5);
            label14.Name = "label14";
            label14.Size = new Size(122, 15);
            label14.TabIndex = 5;
            label14.Text = "Sound effects volume";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowPreview = true;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.CommonPictures;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabControls);
            tabControl.Controls.Add(tabHandling);
            tabControl.Controls.Add(tabAudio);
            tabControl.Controls.Add(tabVideo);
            tabControl.Controls.Add(tabCustomization);
            tabControl.Controls.Add(tabAbout);
            tabControl.Location = new Point(286, 30);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(427, 558);
            tabControl.TabIndex = 1;
            tabControl.TabStop = false;
            // 
            // tabControls
            // 
            tabControls.AutoScroll = true;
            tabControls.Controls.Add(keyQuit2);
            tabControls.Controls.Add(keyQuit);
            tabControls.Controls.Add(keyHold2);
            tabControls.Controls.Add(keyRotateClockwise2);
            tabControls.Controls.Add(keyHardDrop2);
            tabControls.Controls.Add(keySoftDrop2);
            tabControls.Controls.Add(keyMoveLeft);
            tabControls.Controls.Add(keyMoveRight2);
            tabControls.Controls.Add(keyMoveRight);
            tabControls.Controls.Add(keyMoveLeft2);
            tabControls.Controls.Add(keySoftDrop);
            tabControls.Controls.Add(keyHold);
            tabControls.Controls.Add(keyHardDrop);
            tabControls.Controls.Add(keyRotateClockwise);
            tabControls.Controls.Add(label7);
            tabControls.Controls.Add(label2);
            tabControls.Controls.Add(label1);
            tabControls.Controls.Add(label3);
            tabControls.Controls.Add(label4);
            tabControls.Controls.Add(label5);
            tabControls.Controls.Add(label6);
            tabControls.ForeColor = SystemColors.ControlText;
            tabControls.Location = new Point(4, 27);
            tabControls.Name = "tabControls";
            tabControls.Padding = new Padding(3);
            tabControls.Size = new Size(419, 527);
            tabControls.TabIndex = 0;
            tabControls.Text = "Controls";
            // 
            // tabHandling
            // 
            tabHandling.ForeColor = Color.White;
            tabHandling.Location = new Point(4, 27);
            tabHandling.Name = "tabHandling";
            tabHandling.Padding = new Padding(3);
            tabHandling.Size = new Size(419, 527);
            tabHandling.TabIndex = 1;
            tabHandling.Text = "Handling";
            // 
            // tabAudio
            // 
            tabAudio.Controls.Add(chkSfx);
            tabAudio.Controls.Add(label12);
            tabAudio.Controls.Add(label13);
            tabAudio.Controls.Add(trackSfxVol);
            tabAudio.Controls.Add(label14);
            tabAudio.ForeColor = SystemColors.ControlText;
            tabAudio.Location = new Point(4, 27);
            tabAudio.Name = "tabAudio";
            tabAudio.Padding = new Padding(5);
            tabAudio.Size = new Size(419, 527);
            tabAudio.TabIndex = 2;
            tabAudio.Text = "Audio & Volume";
            // 
            // chkSfx
            // 
            chkSfx.AutoSize = true;
            chkSfx.Location = new Point(8, 8);
            chkSfx.Margin = new Padding(5);
            chkSfx.Name = "chkSfx";
            chkSfx.Size = new Size(98, 19);
            chkSfx.TabIndex = 8;
            chkSfx.Text = "Sound effects";
            chkSfx.UseVisualStyleBackColor = true;
            chkSfx.CheckedChanged += togSfx_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(350, 90);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 7;
            label12.Text = "100%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 90);
            label13.Name = "label13";
            label13.Size = new Size(23, 15);
            label13.TabIndex = 6;
            label13.Text = "0%";
            // 
            // trackSfxVol
            // 
            trackSfxVol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackSfxVol.Location = new Point(8, 60);
            trackSfxVol.Maximum = 100;
            trackSfxVol.Name = "trackSfxVol";
            trackSfxVol.Size = new Size(377, 45);
            trackSfxVol.TabIndex = 4;
            trackSfxVol.TickFrequency = 10;
            trackSfxVol.Value = 50;
            trackSfxVol.Scroll += trackSfxVol_Scroll;
            // 
            // tabVideo
            // 
            tabVideo.Controls.Add(chkBoardBounce);
            tabVideo.Controls.Add(label15);
            tabVideo.Controls.Add(trackOpacity);
            tabVideo.Controls.Add(label11);
            tabVideo.Controls.Add(label8);
            tabVideo.Controls.Add(trackScale);
            tabVideo.Controls.Add(label9);
            tabVideo.ForeColor = SystemColors.ControlText;
            tabVideo.Location = new Point(4, 27);
            tabVideo.Name = "tabVideo";
            tabVideo.Padding = new Padding(5);
            tabVideo.Size = new Size(419, 527);
            tabVideo.TabIndex = 3;
            tabVideo.Text = "Video & Interface";
            // 
            // chkBoardBounce
            // 
            chkBoardBounce.AutoSize = true;
            chkBoardBounce.Location = new Point(10, 85);
            chkBoardBounce.Margin = new Padding(5);
            chkBoardBounce.Name = "chkBoardBounce";
            chkBoardBounce.Size = new Size(100, 19);
            chkBoardBounce.TabIndex = 6;
            chkBoardBounce.Text = "Bouncy board";
            chkBoardBounce.UseVisualStyleBackColor = true;
            chkBoardBounce.CheckedChanged += togBoardBounce_CheckedChanged;
            // 
            // trackOpacity
            // 
            trackOpacity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackOpacity.Location = new Point(10, 139);
            trackOpacity.Margin = new Padding(5);
            trackOpacity.Maximum = 100;
            trackOpacity.Minimum = 75;
            trackOpacity.Name = "trackOpacity";
            trackOpacity.Size = new Size(377, 45);
            trackOpacity.TabIndex = 4;
            trackOpacity.TickFrequency = 5;
            trackOpacity.Value = 100;
            trackOpacity.Scroll += trackOpacity_Scroll;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(355, 65);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 3;
            label11.Text = "30px";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 65);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 2;
            label8.Text = "20px";
            // 
            // tabCustomization
            // 
            tabCustomization.Controls.Add(chkAllowCustomBgColors);
            tabCustomization.Controls.Add(chkUseBackground);
            tabCustomization.Controls.Add(btnAddBackgroundImage);
            tabCustomization.Controls.Add(btnEditBackgroundImage);
            tabCustomization.Controls.Add(btnRemoveBackgroundImage);
            tabCustomization.Controls.Add(lstBgImgs);
            tabCustomization.Controls.Add(label10);
            tabCustomization.ForeColor = SystemColors.ControlText;
            tabCustomization.Location = new Point(4, 27);
            tabCustomization.Name = "tabCustomization";
            tabCustomization.Padding = new Padding(5);
            tabCustomization.Size = new Size(419, 527);
            tabCustomization.TabIndex = 4;
            tabCustomization.Text = "Customization";
            // 
            // chkAllowCustomBgColors
            // 
            chkAllowCustomBgColors.AutoSize = true;
            chkAllowCustomBgColors.Location = new Point(8, 43);
            chkAllowCustomBgColors.Name = "chkAllowCustomBgColors";
            chkAllowCustomBgColors.Padding = new Padding(5);
            chkAllowCustomBgColors.Size = new Size(211, 29);
            chkAllowCustomBgColors.TabIndex = 10;
            chkAllowCustomBgColors.Text = "Allow custom background colors";
            chkAllowCustomBgColors.UseVisualStyleBackColor = true;
            chkAllowCustomBgColors.CheckedChanged += checkAllowCustomColors_CheckedChanged;
            // 
            // chkUseBackground
            // 
            chkUseBackground.AutoSize = true;
            chkUseBackground.Location = new Point(8, 8);
            chkUseBackground.Name = "chkUseBackground";
            chkUseBackground.Padding = new Padding(5);
            chkUseBackground.Size = new Size(173, 29);
            chkUseBackground.TabIndex = 9;
            chkUseBackground.Text = "Show background images";
            chkUseBackground.UseVisualStyleBackColor = true;
            chkUseBackground.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lstBgImgs
            // 
            lstBgImgs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstBgImgs.BorderStyle = BorderStyle.FixedSingle;
            lstBgImgs.FormattingEnabled = true;
            lstBgImgs.ItemHeight = 15;
            lstBgImgs.Location = new Point(8, 103);
            lstBgImgs.Name = "lstBgImgs";
            lstBgImgs.SelectionMode = SelectionMode.MultiExtended;
            lstBgImgs.Size = new Size(391, 137);
            lstBgImgs.TabIndex = 2;
            // 
            // tabAbout
            // 
            tabAbout.BackColor = Color.White;
            tabAbout.Controls.Add(label17);
            tabAbout.Controls.Add(pictureBox2);
            tabAbout.Controls.Add(linkBsky);
            tabAbout.Controls.Add(linkWebsite);
            tabAbout.Controls.Add(linkGithub);
            tabAbout.Controls.Add(label16);
            tabAbout.Controls.Add(textBox1);
            tabAbout.Controls.Add(pictureBox1);
            tabAbout.ForeColor = SystemColors.ControlText;
            tabAbout.Location = new Point(4, 27);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(3);
            tabAbout.Size = new Size(419, 527);
            tabAbout.TabIndex = 5;
            tabAbout.Text = "About";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(225, 52);
            label17.Name = "label17";
            label17.Size = new Size(22, 15);
            label17.TabIndex = 7;
            label17.Text = "0.1";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.ImageLocation = "https://media1.tenor.com/m/PfX3-5yai3QAAAAC/kasane-teto.gif";
            pictureBox2.Location = new Point(96, 348);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(104, 310);
            label16.Name = "label16";
            label16.Padding = new Padding(5);
            label16.Size = new Size(210, 35);
            label16.TabIndex = 2;
            label16.Text = "Thank you for playing!";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 98);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(407, 209);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fullLogoBig;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(213, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnTabAbout);
            panel1.Controls.Add(btnTabCustomization);
            panel1.Controls.Add(btnTabVideo);
            panel1.Controls.Add(btnTabAudio);
            panel1.Controls.Add(btnTabHandling);
            panel1.Controls.Add(btnTabControls);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 554);
            panel1.TabIndex = 0;
            // 
            // btnTabAbout
            // 
            btnTabAbout.BackColor = Color.FromArgb(32, 32, 32);
            btnTabAbout.Cursor = Cursors.Hand;
            btnTabAbout.Dock = DockStyle.Top;
            btnTabAbout.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTabAbout.FlatAppearance.BorderSize = 0;
            btnTabAbout.FlatStyle = FlatStyle.Flat;
            btnTabAbout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTabAbout.ImageAlign = ContentAlignment.MiddleRight;
            btnTabAbout.Location = new Point(0, 235);
            btnTabAbout.Margin = new Padding(3, 0, 3, 0);
            btnTabAbout.Name = "btnTabAbout";
            btnTabAbout.Size = new Size(290, 47);
            btnTabAbout.TabIndex = 5;
            btnTabAbout.Tag = "tabAbout";
            btnTabAbout.Text = "About";
            btnTabAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnTabAbout.UseVisualStyleBackColor = false;
            btnTabAbout.Click += btnTabControls_Click;
            btnTabAbout.Enter += ButtonFocused;
            // 
            // btnTabCustomization
            // 
            btnTabCustomization.BackColor = Color.FromArgb(32, 32, 32);
            btnTabCustomization.Cursor = Cursors.Hand;
            btnTabCustomization.Dock = DockStyle.Top;
            btnTabCustomization.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTabCustomization.FlatAppearance.BorderSize = 0;
            btnTabCustomization.FlatStyle = FlatStyle.Flat;
            btnTabCustomization.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTabCustomization.ImageAlign = ContentAlignment.MiddleRight;
            btnTabCustomization.Location = new Point(0, 188);
            btnTabCustomization.Margin = new Padding(3, 0, 3, 0);
            btnTabCustomization.Name = "btnTabCustomization";
            btnTabCustomization.Size = new Size(290, 47);
            btnTabCustomization.TabIndex = 4;
            btnTabCustomization.Tag = "tabCustomization";
            btnTabCustomization.Text = "Customization";
            btnTabCustomization.TextAlign = ContentAlignment.MiddleLeft;
            btnTabCustomization.UseVisualStyleBackColor = false;
            btnTabCustomization.Click += btnTabControls_Click;
            btnTabCustomization.Enter += ButtonFocused;
            // 
            // btnTabVideo
            // 
            btnTabVideo.BackColor = Color.FromArgb(32, 32, 32);
            btnTabVideo.Cursor = Cursors.Hand;
            btnTabVideo.Dock = DockStyle.Top;
            btnTabVideo.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTabVideo.FlatAppearance.BorderSize = 0;
            btnTabVideo.FlatStyle = FlatStyle.Flat;
            btnTabVideo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTabVideo.ImageAlign = ContentAlignment.MiddleRight;
            btnTabVideo.Location = new Point(0, 141);
            btnTabVideo.Margin = new Padding(3, 0, 3, 0);
            btnTabVideo.Name = "btnTabVideo";
            btnTabVideo.Size = new Size(290, 47);
            btnTabVideo.TabIndex = 3;
            btnTabVideo.Tag = "tabVideo";
            btnTabVideo.Text = "Video && Interface";
            btnTabVideo.TextAlign = ContentAlignment.MiddleLeft;
            btnTabVideo.UseVisualStyleBackColor = false;
            btnTabVideo.Click += btnTabControls_Click;
            btnTabVideo.Enter += ButtonFocused;
            // 
            // btnTabAudio
            // 
            btnTabAudio.BackColor = Color.FromArgb(32, 32, 32);
            btnTabAudio.Cursor = Cursors.Hand;
            btnTabAudio.Dock = DockStyle.Top;
            btnTabAudio.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTabAudio.FlatAppearance.BorderSize = 0;
            btnTabAudio.FlatStyle = FlatStyle.Flat;
            btnTabAudio.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTabAudio.ImageAlign = ContentAlignment.MiddleRight;
            btnTabAudio.Location = new Point(0, 94);
            btnTabAudio.Margin = new Padding(3, 0, 3, 0);
            btnTabAudio.Name = "btnTabAudio";
            btnTabAudio.Size = new Size(290, 47);
            btnTabAudio.TabIndex = 2;
            btnTabAudio.Tag = "tabAudio";
            btnTabAudio.Text = "Audio && Volume";
            btnTabAudio.TextAlign = ContentAlignment.MiddleLeft;
            btnTabAudio.UseVisualStyleBackColor = false;
            btnTabAudio.Click += btnTabControls_Click;
            btnTabAudio.Enter += ButtonFocused;
            // 
            // btnTabHandling
            // 
            btnTabHandling.BackColor = Color.FromArgb(32, 32, 32);
            btnTabHandling.Cursor = Cursors.Hand;
            btnTabHandling.Dock = DockStyle.Top;
            btnTabHandling.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTabHandling.FlatAppearance.BorderSize = 0;
            btnTabHandling.FlatStyle = FlatStyle.Flat;
            btnTabHandling.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTabHandling.ImageAlign = ContentAlignment.MiddleRight;
            btnTabHandling.Location = new Point(0, 47);
            btnTabHandling.Margin = new Padding(3, 0, 3, 0);
            btnTabHandling.Name = "btnTabHandling";
            btnTabHandling.Size = new Size(290, 47);
            btnTabHandling.TabIndex = 1;
            btnTabHandling.Tag = "tabHandling";
            btnTabHandling.Text = "Handling";
            btnTabHandling.TextAlign = ContentAlignment.MiddleLeft;
            btnTabHandling.UseVisualStyleBackColor = false;
            btnTabHandling.Click += btnTabControls_Click;
            btnTabHandling.Enter += ButtonFocused;
            // 
            // btnTabControls
            // 
            btnTabControls.BackColor = Color.White;
            btnTabControls.Cursor = Cursors.Hand;
            btnTabControls.Dock = DockStyle.Top;
            btnTabControls.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTabControls.FlatAppearance.BorderSize = 0;
            btnTabControls.FlatStyle = FlatStyle.Flat;
            btnTabControls.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTabControls.ForeColor = Color.FromArgb(32, 32, 32);
            btnTabControls.ImageAlign = ContentAlignment.MiddleRight;
            btnTabControls.Location = new Point(0, 0);
            btnTabControls.Margin = new Padding(3, 0, 3, 0);
            btnTabControls.Name = "btnTabControls";
            btnTabControls.Size = new Size(290, 47);
            btnTabControls.TabIndex = 0;
            btnTabControls.Tag = "tabControls";
            btnTabControls.Text = "Controls";
            btnTabControls.TextAlign = ContentAlignment.MiddleLeft;
            btnTabControls.UseVisualStyleBackColor = false;
            btnTabControls.Click += btnTabControls_Click;
            btnTabControls.Enter += ButtonFocused;
            // 
            // dialogTitle1
            // 
            dialogTitle1.BackColor = Color.FromArgb(32, 32, 32);
            dialogTitle1.CanAutoClose = true;
            dialogTitle1.CanMove = true;
            dialogTitle1.Dock = DockStyle.Top;
            dialogTitle1.ForeColor = Color.White;
            dialogTitle1.Location = new Point(0, 0);
            dialogTitle1.Name = "dialogTitle1";
            dialogTitle1.Size = new Size(709, 30);
            dialogTitle1.TabIndex = 2;
            dialogTitle1.TabStop = false;
            dialogTitle1.Title = "Options";
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(709, 584);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(dialogTitle1);
            Controls.Add(tabControl);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(500, 200);
            Name = "frmConfig";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += frmConf_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackScale).EndInit();
            tabControl.ResumeLayout(false);
            tabControls.ResumeLayout(false);
            tabControls.PerformLayout();
            tabAudio.ResumeLayout(false);
            tabAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackSfxVol).EndInit();
            tabVideo.ResumeLayout(false);
            tabVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackOpacity).EndInit();
            tabCustomization.ResumeLayout(false);
            tabCustomization.PerformLayout();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtMoveRight;
        private TextBox txtHardDrop;
        private TextBox txtMoveDown;
        private TextBox txtHold;
        private TextBox txtRotateClock;
        private Label label6;
        private Controls.KeyBox keyMoveLeft;
        private Controls.KeyBox keyMoveRight;
        private Controls.KeyBox keyHold;
        private Controls.KeyBox keyRotateClockwise;
        private Controls.KeyBox keyHardDrop;
        private Controls.KeyBox keySoftDrop;
        private Controls.KeyBox keyMoveLeft2;
        private Controls.KeyBox keyHold2;
        private Controls.KeyBox keyRotateClockwise2;
        private Controls.KeyBox keyHardDrop2;
        private Controls.KeyBox keySoftDrop2;
        private Controls.KeyBox keyMoveRight2;
        private Label label7;
        private Controls.KeyBox keyQuit2;
        private Controls.KeyBox keyQuit;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private TrackBar trackScale;
        private Label label9;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabControl tabControl;
        private TabPage tabControls;
        private TabPage tabHandling;
        private TabPage tabAudio;
        private TabPage tabVideo;
        private TabPage tabCustomization;
        private Label label10;
        private Panel panel1;
        private Button btnTabVideo;
        private Button btnTabAudio;
        private Button btnTabHandling;
        private Button btnTabControls;
        private Button btnTabCustomization;
        private ListBox lstBgImgs;
        private Button btnRemoveBackgroundImage;
        public Controls.DialogTitleBar dialogTitle1;
        private Button btnEditBackgroundImage;
        private Label label11;
        private Label label8;
        private Button btnAddBackgroundImage;
        private Label label12;
        private Label label13;
        private TrackBar trackSfxVol;
        private Label label14;
        private Label label15;
        private TrackBar trackOpacity;
        private CheckBox chkUseBackground;
        private CheckBox chkAllowCustomBgColors;
        private CheckBox chkBoardBounce;
        private CheckBox chkSfx;
        private TabPage tabAbout;
        private Button btnTabAbout;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label16;
        private LinkLabel linkGithub;
        private LinkLabel linkWebsite;
        private LinkLabel linkBsky;
        private PictureBox pictureBox2;
        private Label label17;
    }
}