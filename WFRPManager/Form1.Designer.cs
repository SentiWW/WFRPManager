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
            this.TopMenuStrip.Size = new System.Drawing.Size(1027, 24);
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
            this.BottomStatusStrip.Location = new System.Drawing.Point(0, 464);
            this.BottomStatusStrip.Name = "BottomStatusStrip";
            this.BottomStatusStrip.Size = new System.Drawing.Size(1027, 22);
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
            this.MainPanel.Controls.Add(this.CharacterName);
            this.MainPanel.Controls.Add(this.NextPage);
            this.MainPanel.Controls.Add(this.LeftFlowPanel);
            this.MainPanel.Controls.Add(this.FirstPictureBox);
            this.MainPanel.Controls.Add(this.SecondPictureBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1027, 440);
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
            this.CharacterName.Location = new System.Drawing.Point(277, 103);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(638, 37);
            this.CharacterName.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1027, 486);
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
    }
}

