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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            terminologiToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            savingToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, profileToolStripMenuItem, loanToolStripMenuItem, savingToolStripMenuItem, transferToolStripMenuItem, exchangeToolStripMenuItem, historyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, terminologiToolStripMenuItem, logToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(180, 22);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // terminologiToolStripMenuItem
            // 
            terminologiToolStripMenuItem.Name = "terminologiToolStripMenuItem";
            terminologiToolStripMenuItem.Size = new Size(180, 22);
            terminologiToolStripMenuItem.Text = "Terminologi";
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(180, 22);
            logToolStripMenuItem.Text = "Logout";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 20);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(45, 20);
            loanToolStripMenuItem.Text = "Loan";
            // 
            // savingToolStripMenuItem
            // 
            savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            savingToolStripMenuItem.Size = new Size(54, 20);
            savingToolStripMenuItem.Text = "Saving";
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(61, 20);
            transferToolStripMenuItem.Text = "Transfer";
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(69, 20);
            exchangeToolStripMenuItem.Text = "Exchange";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(57, 20);
            historyToolStripMenuItem.Text = "History";
            // 
            // HomeForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomeForms";
            Text = "Corvus Cooperation";
            Load += HomeForms_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem terminologiToolStripMenuItem;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem savingToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
    }
}