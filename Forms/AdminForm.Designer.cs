namespace Corvus.Forms
{
    partial class AdminForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            accessToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            approvalToolStripMenuItem = new ToolStripMenuItem();
            acrossToolStripMenuItem = new ToolStripMenuItem();
            panelDisplay = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, memberToolStripMenuItem, accessToolStripMenuItem, productToolStripMenuItem, approvalToolStripMenuItem, acrossToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1486, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurationToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 38);
            fileToolStripMenuItem.Text = "FIle";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(294, 44);
            configurationToolStripMenuItem.Text = "Configuration";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(294, 44);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(125, 38);
            memberToolStripMenuItem.Text = "Member";
            // 
            // accessToolStripMenuItem
            // 
            accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            accessToolStripMenuItem.Size = new Size(104, 38);
            accessToolStripMenuItem.Text = "Access";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(116, 38);
            productToolStripMenuItem.Text = "Product";
            // 
            // approvalToolStripMenuItem
            // 
            approvalToolStripMenuItem.Name = "approvalToolStripMenuItem";
            approvalToolStripMenuItem.Size = new Size(129, 38);
            approvalToolStripMenuItem.Text = "Approval";
            // 
            // acrossToolStripMenuItem
            // 
            acrossToolStripMenuItem.Name = "acrossToolStripMenuItem";
            acrossToolStripMenuItem.Size = new Size(241, 38);
            acrossToolStripMenuItem.Text = "Across Cooperation";
            acrossToolStripMenuItem.Click += acrossToolStripMenuItem_Click;
            // 
            // panelDisplay
            // 
            panelDisplay.Location = new Point(0, 58);
            panelDisplay.Margin = new Padding(6, 6, 6, 6);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1486, 911);
            panelDisplay.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1486, 960);
            Controls.Add(panelDisplay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            Name = "AdminForm";
            Text = "Corvus Cooperation";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem accessToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem approvalToolStripMenuItem;
        private ToolStripMenuItem acrossToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panelDisplay;
    }
}