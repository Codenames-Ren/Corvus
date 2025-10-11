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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 420);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Exchange Rate :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 420);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Inhouse Fee :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 420);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Across Fee :";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAcross);
            Controls.Add(lblInhouse);
            Controls.Add(lblExchange);
            Name = "TerminologiPage";
            Size = new Size(887, 513);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExchange;
        private Label lblInhouse;
        private Label lblAcross;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
