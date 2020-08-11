namespace WFRPManager
{
    partial class Register
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.RegisterLable = new System.Windows.Forms.Label();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MidPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MidPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(430, 472);
            this.MainPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TopPanel.Controls.Add(this.RegisterLable);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(430, 72);
            this.TopPanel.TabIndex = 0;
            // 
            // RegisterLable
            // 
            this.RegisterLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterLable.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLable.Location = new System.Drawing.Point(0, 0);
            this.RegisterLable.Name = "RegisterLable";
            this.RegisterLable.Size = new System.Drawing.Size(430, 72);
            this.RegisterLable.TabIndex = 0;
            this.RegisterLable.Text = "Zarejestruj się";
            this.RegisterLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MidPanel
            // 
            this.MidPanel.Controls.Add(this.textBox1);
            this.MidPanel.Controls.Add(this.EmailField);
            this.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidPanel.Location = new System.Drawing.Point(0, 72);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Padding = new System.Windows.Forms.Padding(64, 32, 64, 0);
            this.MidPanel.Size = new System.Drawing.Size(430, 400);
            this.MidPanel.TabIndex = 1;
            // 
            // EmailField
            // 
            this.EmailField.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EmailField.Location = new System.Drawing.Point(64, 32);
            this.EmailField.MaxLength = 256;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(302, 32);
            this.EmailField.TabIndex = 0;
            this.EmailField.Text = "E-Mail";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(64, 64);
            this.textBox1.MaxLength = 256;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "E-Mail";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 472);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label RegisterLable;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox EmailField;
    }
}