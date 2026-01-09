namespace Corvus.Forms
{
    partial class HomeForm
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
            menuHome = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            definitionsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            savingToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            inhouseToolStripMenuItem = new ToolStripMenuItem();
            acrossCooperationToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            panelDisplay = new Panel();
            menuHome.SuspendLayout();
            SuspendLayout();
            // 
            // menuHome
            // 
            menuHome.BackColor = Color.Purple;
            menuHome.ImageScalingSize = new Size(32, 32);
            menuHome.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, profileToolStripMenuItem, loanToolStripMenuItem, savingToolStripMenuItem, transferToolStripMenuItem, exchangeToolStripMenuItem, historyToolStripMenuItem });
            menuHome.Location = new Point(0, 0);
            menuHome.Name = "menuHome";
            menuHome.Padding = new Padding(11, 4, 0, 4);
            menuHome.Size = new Size(1486, 44);
            menuHome.TabIndex = 0;
            menuHome.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, definitionsToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.BackColor = Color.Purple;
            dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(274, 44);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // definitionsToolStripMenuItem
            // 
            definitionsToolStripMenuItem.BackColor = Color.Purple;
            definitionsToolStripMenuItem.ForeColor = Color.White;
            definitionsToolStripMenuItem.Name = "definitionsToolStripMenuItem";
            definitionsToolStripMenuItem.Size = new Size(274, 44);
            definitionsToolStripMenuItem.Text = "Terminologi";
            definitionsToolStripMenuItem.Click += definitionsToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.BackColor = Color.Purple;
            logoutToolStripMenuItem.ForeColor = Color.White;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(274, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.ForeColor = Color.White;
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(102, 36);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.ForeColor = Color.White;
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(85, 36);
            loanToolStripMenuItem.Text = "Loan";
            loanToolStripMenuItem.Click += loanToolStripMenuItem_Click;
            // 
            // savingToolStripMenuItem
            // 
            savingToolStripMenuItem.ForeColor = Color.White;
            savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            savingToolStripMenuItem.Size = new Size(105, 36);
            savingToolStripMenuItem.Text = "Saving";
            savingToolStripMenuItem.Click += savingToolStripMenuItem_Click;
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inhouseToolStripMenuItem, acrossCooperationToolStripMenuItem });
            transferToolStripMenuItem.ForeColor = Color.White;
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(118, 36);
            transferToolStripMenuItem.Text = "Transfer";
            // 
            // inhouseToolStripMenuItem
            // 
            inhouseToolStripMenuItem.BackColor = Color.Purple;
            inhouseToolStripMenuItem.Enabled = false;
            inhouseToolStripMenuItem.ForeColor = Color.White;
            inhouseToolStripMenuItem.Name = "inhouseToolStripMenuItem";
            inhouseToolStripMenuItem.Size = new Size(232, 44);
            inhouseToolStripMenuItem.Text = "Inhouse";
            inhouseToolStripMenuItem.Click += inhouseToolStripMenuItem_Click;
            // 
            // acrossCooperationToolStripMenuItem
            // 
            acrossCooperationToolStripMenuItem.BackColor = Color.Purple;
            acrossCooperationToolStripMenuItem.ForeColor = Color.White;
            acrossCooperationToolStripMenuItem.Name = "acrossCooperationToolStripMenuItem";
            acrossCooperationToolStripMenuItem.Size = new Size(232, 44);
            acrossCooperationToolStripMenuItem.Text = "Across";
            acrossCooperationToolStripMenuItem.Click += acrossCooperationToolStripMenuItem_Click;
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.ForeColor = Color.White;
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(135, 36);
            exchangeToolStripMenuItem.Text = "Exchange";
            exchangeToolStripMenuItem.Click += exchangeToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.ForeColor = Color.White;
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(109, 36);
            historyToolStripMenuItem.Text = "History";
            // 
            // panelDisplay
            // 
            panelDisplay.BackColor = Color.FromArgb(64, 0, 64);
            panelDisplay.Location = new Point(0, 58);
            panelDisplay.Margin = new Padding(6);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1486, 909);
            panelDisplay.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(panelDisplay);
            Controls.Add(menuHome);
            MainMenuStrip = menuHome;
            Margin = new Padding(6);
            Name = "HomeForm";
            Text = "Corvus";
            WindowState = FormWindowState.Maximized;
            Load += HomeForm_Load;
            menuHome.ResumeLayout(false);
            menuHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHome;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem savingToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem definitionsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem inhouseToolStripMenuItem;
        private ToolStripMenuItem acrossCooperationToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Panel panelDisplay;
    }
}