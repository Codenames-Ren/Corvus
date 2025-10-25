namespace Corvus.Forms
{
    partial class TerminologiPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblExchange = new Label();
            lblInhouse = new Label();
            lblAcross = new Label();
            labelExchange = new Label();
            labelInhouse = new Label();
            labelAcross = new Label();
            SuspendLayout();
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.Location = new Point(34, 30);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(18, 20);
            lblExchange.TabIndex = 0;
            lblExchange.Text = "...";
            // 
            // lblInhouse
            // 
            lblInhouse.AutoSize = true;
            lblInhouse.Location = new Point(34, 163);
            lblInhouse.Name = "lblInhouse";
            lblInhouse.Size = new Size(21, 20);
            lblInhouse.TabIndex = 1;
            lblInhouse.Text = "....";
            lblInhouse.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAcross
            // 
            lblAcross.AutoSize = true;
            lblAcross.Location = new Point(34, 310);
            lblAcross.Name = "lblAcross";
            lblAcross.Size = new Size(18, 20);
            lblAcross.TabIndex = 2;
            lblAcross.Text = "...";
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(82, 420);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(113, 20);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange Rate :";
            // 
            // labelInhouse
            // 
            labelInhouse.AutoSize = true;
            labelInhouse.Location = new Point(377, 420);
            labelInhouse.Name = "labelInhouse";
            labelInhouse.Size = new Size(94, 20);
            labelInhouse.TabIndex = 4;
            labelInhouse.Text = "Inhouse Fee :";
            // 
            // labelAcross
            // 
            labelAcross.AutoSize = true;
            labelAcross.Location = new Point(675, 420);
            labelAcross.Name = "labelAcross";
            labelAcross.Size = new Size(86, 20);
            labelAcross.TabIndex = 5;
            labelAcross.Text = "Across Fee :";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelAcross);
            Controls.Add(labelInhouse);
            Controls.Add(labelExchange);
            Controls.Add(lblAcross);
            Controls.Add(lblInhouse);
            Controls.Add(lblExchange);
            Name = "TerminologiPage";
            Size = new Size(887, 513);
            Load += TerminologiPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExchange;
        private Label lblInhouse;
        private Label lblAcross;
        private Label labelExchange;
        private Label labelInhouse;
        private Label labelAcross;
    }
}
