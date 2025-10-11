namespace Corvus.Forms
{
    partial class ConfigPage
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
            txtExchangeView = new TextBox();
            txtInhouseView = new TextBox();
            txtAcrossView = new TextBox();
            txtExchange = new TextBox();
            txtInhouse = new TextBox();
            txtAcross = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtExchangeView
            // 
            txtExchangeView.Location = new Point(45, 36);
            txtExchangeView.Multiline = true;
            txtExchangeView.Name = "txtExchangeView";
            txtExchangeView.Size = new Size(350, 418);
            txtExchangeView.TabIndex = 0;
            // 
            // txtInhouseView
            // 
            txtInhouseView.Location = new Point(432, 36);
            txtInhouseView.Multiline = true;
            txtInhouseView.Name = "txtInhouseView";
            txtInhouseView.Size = new Size(350, 418);
            txtInhouseView.TabIndex = 1;
            // 
            // txtAcrossView
            // 
            txtAcrossView.Location = new Point(807, 36);
            txtAcrossView.Multiline = true;
            txtAcrossView.Name = "txtAcrossView";
            txtAcrossView.Size = new Size(350, 418);
            txtAcrossView.TabIndex = 2;
            // 
            // txtExchange
            // 
            txtExchange.Location = new Point(45, 485);
            txtExchange.Name = "txtExchange";
            txtExchange.Size = new Size(350, 27);
            txtExchange.TabIndex = 3;
            // 
            // txtInhouse
            // 
            txtInhouse.Location = new Point(432, 485);
            txtInhouse.Name = "txtInhouse";
            txtInhouse.Size = new Size(350, 27);
            txtInhouse.TabIndex = 4;
            // 
            // txtAcross
            // 
            txtAcross.Location = new Point(807, 485);
            txtAcross.Name = "txtAcross";
            txtAcross.Size = new Size(350, 27);
            txtAcross.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 524);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 8);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "Terminologi 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 8);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Terminologi 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(808, 8);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 9;
            label3.Text = "Terminologi 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 461);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 10;
            label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 461);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 11;
            label5.Text = "Inhouse Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(811, 461);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 12;
            label6.Text = "Across Fee";
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(txtAcross);
            Controls.Add(txtInhouse);
            Controls.Add(txtExchange);
            Controls.Add(txtAcrossView);
            Controls.Add(txtInhouseView);
            Controls.Add(txtExchangeView);
            Name = "ConfigPage";
            Size = new Size(1215, 573);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExchangeView;
        private TextBox txtInhouseView;
        private TextBox txtAcrossView;
        private TextBox txtExchange;
        private TextBox txtInhouse;
        private TextBox txtAcross;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
