namespace WFRPManager
{
    partial class MainWindow
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
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NextPage = new System.Windows.Forms.Button();
            this.LeftFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FirstPictureBox = new System.Windows.Forms.PictureBox();
            this.SecondPictureBox = new System.Windows.Forms.PictureBox();
            this.CharacterName = new System.Windows.Forms.TextBox();
            this.CharacterRace = new System.Windows.Forms.TextBox();
            this.CharacterCurrentRole = new System.Windows.Forms.TextBox();
            this.CharacterPreviousRole = new System.Windows.Forms.TextBox();
            this.CharacterAge = new System.Windows.Forms.TextBox();
            this.CharacterSex = new System.Windows.Forms.TextBox();
            this.CharacterWeight = new System.Windows.Forms.TextBox();
            this.CharacterHeight = new System.Windows.Forms.TextBox();
            this.CharacterSiblings = new System.Windows.Forms.TextBox();
            this.CharacterEyeColour = new System.Windows.Forms.TextBox();
            this.CharacterHairColor = new System.Windows.Forms.TextBox();
            this.CharacterStartSign = new System.Windows.Forms.TextBox();
            this.CharacterBirthplace = new System.Windows.Forms.TextBox();
            this.CharacterFeatures = new System.Windows.Forms.TextBox();
            this.TopMenuStrip.SuspendLayout();
            this.BottomStatusStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(1813, 24);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "TopMenuStrip";
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.placeholderToolStripMenuItem.Text = "Placeholder";
            // 
            // BottomStatusStrip
            // 
            this.BottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.BottomStatusStrip.Location = new System.Drawing.Point(0, 795);
            this.BottomStatusStrip.Name = "BottomStatusStrip";
            this.BottomStatusStrip.Size = new System.Drawing.Size(1813, 22);
            this.BottomStatusStrip.TabIndex = 1;
            this.BottomStatusStrip.Text = "BottomStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Placeholder";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.CharacterFeatures);
            this.MainPanel.Controls.Add(this.CharacterBirthplace);
            this.MainPanel.Controls.Add(this.CharacterStartSign);
            this.MainPanel.Controls.Add(this.CharacterHairColor);
            this.MainPanel.Controls.Add(this.CharacterEyeColour);
            this.MainPanel.Controls.Add(this.CharacterSiblings);
            this.MainPanel.Controls.Add(this.CharacterHeight);
            this.MainPanel.Controls.Add(this.CharacterWeight);
            this.MainPanel.Controls.Add(this.CharacterSex);
            this.MainPanel.Controls.Add(this.CharacterAge);
            this.MainPanel.Controls.Add(this.CharacterPreviousRole);
            this.MainPanel.Controls.Add(this.CharacterCurrentRole);
            this.MainPanel.Controls.Add(this.CharacterRace);
            this.MainPanel.Controls.Add(this.CharacterName);
            this.MainPanel.Controls.Add(this.NextPage);
            this.MainPanel.Controls.Add(this.LeftFlowPanel);
            this.MainPanel.Controls.Add(this.FirstPictureBox);
            this.MainPanel.Controls.Add(this.SecondPictureBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1813, 771);
            this.MainPanel.TabIndex = 2;
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(1834, 3);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(32, 32);
            this.NextPage.TabIndex = 3;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // LeftFlowPanel
            // 
            this.LeftFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftFlowPanel.Name = "LeftFlowPanel";
            this.LeftFlowPanel.Size = new System.Drawing.Size(200, 2175);
            this.LeftFlowPanel.TabIndex = 2;
            // 
            // FirstPictureBox
            // 
            this.FirstPictureBox.ImageLocation = "D:\\vs\\repos\\WFRPManager\\WFRPManager\\resources\\w0.png";
            this.FirstPictureBox.Location = new System.Drawing.Point(193, 0);
            this.FirstPictureBox.Name = "FirstPictureBox";
            this.FirstPictureBox.Size = new System.Drawing.Size(1675, 2175);
            this.FirstPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FirstPictureBox.TabIndex = 0;
            this.FirstPictureBox.TabStop = false;
            // 
            // SecondPictureBox
            // 
            this.SecondPictureBox.ImageLocation = "D:\\vs\\repos\\WFRPManager\\WFRPManager\\resources\\w1.png";
            this.SecondPictureBox.Location = new System.Drawing.Point(193, 0);
            this.SecondPictureBox.Name = "SecondPictureBox";
            this.SecondPictureBox.Size = new System.Drawing.Size(1675, 2175);
            this.SecondPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SecondPictureBox.TabIndex = 1;
            this.SecondPictureBox.TabStop = false;
            // 
            // CharacterName
            // 
            this.CharacterName.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterName.Location = new System.Drawing.Point(292, 103);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(623, 37);
            this.CharacterName.TabIndex = 4;
            // 
            // CharacterRace
            // 
            this.CharacterRace.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterRace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterRace.Location = new System.Drawing.Point(292, 152);
            this.CharacterRace.Name = "CharacterRace";
            this.CharacterRace.Size = new System.Drawing.Size(585, 37);
            this.CharacterRace.TabIndex = 5;
            // 
            // CharacterCurrentRole
            // 
            this.CharacterCurrentRole.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterCurrentRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterCurrentRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterCurrentRole.Location = new System.Drawing.Point(382, 200);
            this.CharacterCurrentRole.Name = "CharacterCurrentRole";
            this.CharacterCurrentRole.Size = new System.Drawing.Size(533, 37);
            this.CharacterCurrentRole.TabIndex = 6;
            // 
            // CharacterPreviousRole
            // 
            this.CharacterPreviousRole.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterPreviousRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterPreviousRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterPreviousRole.Location = new System.Drawing.Point(409, 247);
            this.CharacterPreviousRole.Name = "CharacterPreviousRole";
            this.CharacterPreviousRole.Size = new System.Drawing.Size(506, 37);
            this.CharacterPreviousRole.TabIndex = 7;
            // 
            // CharacterAge
            // 
            this.CharacterAge.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterAge.Location = new System.Drawing.Point(289, 368);
            this.CharacterAge.Name = "CharacterAge";
            this.CharacterAge.Size = new System.Drawing.Size(279, 37);
            this.CharacterAge.TabIndex = 8;
            // 
            // CharacterSex
            // 
            this.CharacterSex.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSex.Location = new System.Drawing.Point(636, 368);
            this.CharacterSex.Name = "CharacterSex";
            this.CharacterSex.Size = new System.Drawing.Size(279, 37);
            this.CharacterSex.TabIndex = 9;
            // 
            // CharacterWeight
            // 
            this.CharacterWeight.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterWeight.Location = new System.Drawing.Point(648, 415);
            this.CharacterWeight.Name = "CharacterWeight";
            this.CharacterWeight.Size = new System.Drawing.Size(267, 37);
            this.CharacterWeight.TabIndex = 10;
            // 
            // CharacterHeight
            // 
            this.CharacterHeight.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterHeight.Location = new System.Drawing.Point(663, 464);
            this.CharacterHeight.Name = "CharacterHeight";
            this.CharacterHeight.Size = new System.Drawing.Size(252, 37);
            this.CharacterHeight.TabIndex = 11;
            // 
            // CharacterSiblings
            // 
            this.CharacterSiblings.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterSiblings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterSiblings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSiblings.Location = new System.Drawing.Point(704, 512);
            this.CharacterSiblings.Name = "CharacterSiblings";
            this.CharacterSiblings.Size = new System.Drawing.Size(211, 37);
            this.CharacterSiblings.TabIndex = 12;
            // 
            // CharacterEyeColour
            // 
            this.CharacterEyeColour.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterEyeColour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterEyeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterEyeColour.Location = new System.Drawing.Point(337, 415);
            this.CharacterEyeColour.Name = "CharacterEyeColour";
            this.CharacterEyeColour.Size = new System.Drawing.Size(231, 37);
            this.CharacterEyeColour.TabIndex = 13;
            // 
            // CharacterHairColor
            // 
            this.CharacterHairColor.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterHairColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterHairColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterHairColor.Location = new System.Drawing.Point(360, 464);
            this.CharacterHairColor.Name = "CharacterHairColor";
            this.CharacterHairColor.Size = new System.Drawing.Size(208, 37);
            this.CharacterHairColor.TabIndex = 14;
            // 
            // CharacterStartSign
            // 
            this.CharacterStartSign.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterStartSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterStartSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterStartSign.Location = new System.Drawing.Point(372, 512);
            this.CharacterStartSign.Name = "CharacterStartSign";
            this.CharacterStartSign.Size = new System.Drawing.Size(196, 37);
            this.CharacterStartSign.TabIndex = 15;
            // 
            // CharacterBirthplace
            // 
            this.CharacterBirthplace.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterBirthplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterBirthplace.Location = new System.Drawing.Point(391, 559);
            this.CharacterBirthplace.Name = "CharacterBirthplace";
            this.CharacterBirthplace.Size = new System.Drawing.Size(524, 37);
            this.CharacterBirthplace.TabIndex = 16;
            // 
            // CharacterFeatures
            // 
            this.CharacterFeatures.BackColor = System.Drawing.SystemColors.Window;
            this.CharacterFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterFeatures.Location = new System.Drawing.Point(391, 608);
            this.CharacterFeatures.Name = "CharacterFeatures";
            this.CharacterFeatures.Size = new System.Drawing.Size(524, 37);
            this.CharacterFeatures.TabIndex = 17;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1813, 817);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomStatusStrip);
            this.Controls.Add(this.TopMenuStrip);
            this.MainMenuStrip = this.TopMenuStrip;
            this.Name = "MainWindow";
            this.Text = "WFRPManager";
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.BottomStatusStrip.ResumeLayout(false);
            this.BottomStatusStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
        private System.Windows.Forms.StatusStrip BottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox FirstPictureBox;
        private System.Windows.Forms.PictureBox SecondPictureBox;
        private System.Windows.Forms.FlowLayoutPanel LeftFlowPanel;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox CharacterName;
        private System.Windows.Forms.TextBox CharacterRace;
        private System.Windows.Forms.TextBox CharacterCurrentRole;
        private System.Windows.Forms.TextBox CharacterPreviousRole;
        private System.Windows.Forms.TextBox CharacterBirthplace;
        private System.Windows.Forms.TextBox CharacterStartSign;
        private System.Windows.Forms.TextBox CharacterHairColor;
        private System.Windows.Forms.TextBox CharacterEyeColour;
        private System.Windows.Forms.TextBox CharacterSiblings;
        private System.Windows.Forms.TextBox CharacterHeight;
        private System.Windows.Forms.TextBox CharacterWeight;
        private System.Windows.Forms.TextBox CharacterSex;
        private System.Windows.Forms.TextBox CharacterAge;
        private System.Windows.Forms.TextBox CharacterFeatures;
    }
}

