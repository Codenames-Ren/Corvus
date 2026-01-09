namespace Corvus.Forms.PublicMenus
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
            labelTerminologi1 = new Label();
            labelTerminologi2 = new Label();
            labelTerminologi3 = new Label();
            labelExchange = new Label();
            labelInhouse = new Label();
            labelAccross = new Label();
            SuspendLayout();
            // 
            // labelTerminologi1
            // 
            labelTerminologi1.AutoSize = true;
            labelTerminologi1.BackColor = Color.Transparent;
            labelTerminologi1.ForeColor = Color.White;
            labelTerminologi1.Location = new Point(61, 55);
            labelTerminologi1.Margin = new Padding(6, 0, 6, 0);
            labelTerminologi1.Name = "labelTerminologi1";
            labelTerminologi1.Size = new Size(29, 32);
            labelTerminologi1.TabIndex = 0;
            labelTerminologi1.Text = "...";
            // 
            // labelTerminologi2
            // 
            labelTerminologi2.AutoSize = true;
            labelTerminologi2.BackColor = Color.Transparent;
            labelTerminologi2.ForeColor = Color.White;
            labelTerminologi2.Location = new Point(61, 358);
            labelTerminologi2.Margin = new Padding(6, 0, 6, 0);
            labelTerminologi2.Name = "labelTerminologi2";
            labelTerminologi2.Size = new Size(29, 32);
            labelTerminologi2.TabIndex = 1;
            labelTerminologi2.Text = "...";
            // 
            // labelTerminologi3
            // 
            labelTerminologi3.AutoSize = true;
            labelTerminologi3.BackColor = Color.Transparent;
            labelTerminologi3.ForeColor = Color.White;
            labelTerminologi3.Location = new Point(61, 663);
            labelTerminologi3.Margin = new Padding(6, 0, 6, 0);
            labelTerminologi3.Name = "labelTerminologi3";
            labelTerminologi3.Size = new Size(29, 32);
            labelTerminologi3.TabIndex = 2;
            labelTerminologi3.Text = "...";
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(61, 838);
            labelExchange.Margin = new Padding(6, 0, 6, 0);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(181, 32);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange Rate: ";
            // 
            // labelInhouse
            // 
            labelInhouse.AutoSize = true;
            labelInhouse.Location = new Point(440, 838);
            labelInhouse.Margin = new Padding(6, 0, 6, 0);
            labelInhouse.Name = "labelInhouse";
            labelInhouse.Size = new Size(149, 32);
            labelInhouse.TabIndex = 4;
            labelInhouse.Text = "Inhouse Fee:";
            // 
            // labelAccross
            // 
            labelAccross.AutoSize = true;
            labelAccross.Location = new Point(845, 838);
            labelAccross.Margin = new Padding(6, 0, 6, 0);
            labelAccross.Name = "labelAccross";
            labelAccross.Size = new Size(143, 32);
            labelAccross.TabIndex = 5;
            labelAccross.Text = "Accross Fee:";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            Controls.Add(labelAccross);
            Controls.Add(labelInhouse);
            Controls.Add(labelExchange);
            Controls.Add(labelTerminologi3);
            Controls.Add(labelTerminologi2);
            Controls.Add(labelTerminologi1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "TerminologiPage";
            Size = new Size(1233, 1045);
            Load += TerminologiPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTerminologi1;
        private Label labelTerminologi2;
        private Label labelTerminologi3;
        private Label labelExchange;
        private Label labelInhouse;
        private Label labelAccross;
    }
}
