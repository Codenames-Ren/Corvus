namespace Corvus.Forms
{
    partial class ExchangePage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            txtAmount = new TextBox();
            txtRate = new TextBox();
            txtSubTotal = new TextBox();
            txtFee = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 67);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 0;
            label1.Text = "Exchange USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 188);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 299);
            label3.Name = "label3";
            label3.Size = new Size(61, 32);
            label3.TabIndex = 2;
            label3.Text = "Rate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 403);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 3;
            label4.Text = "Sub Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 502);
            label5.Name = "label5";
            label5.Size = new Size(52, 32);
            label5.TabIndex = 4;
            label5.Text = "Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 609);
            label6.Name = "label6";
            label6.Size = new Size(65, 32);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(214, 707);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(440, 707);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 7;
            btnClear.Text = "button2";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(214, 185);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(376, 39);
            txtAmount.TabIndex = 8;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(214, 296);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(376, 39);
            txtRate.TabIndex = 9;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(214, 396);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(376, 39);
            txtSubTotal.TabIndex = 10;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(214, 495);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(376, 39);
            txtFee.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(214, 602);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(376, 39);
            txtTotal.TabIndex = 12;
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTotal);
            Controls.Add(txtFee);
            Controls.Add(txtSubTotal);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExchangePage";
            Size = new Size(685, 860);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSubmit;
        private Button btnClear;
        private TextBox txtAmount;
        private TextBox txtRate;
        private TextBox txtSubTotal;
        private TextBox txtFee;
        private TextBox txtTotal;
    }
}
