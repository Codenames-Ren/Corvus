namespace Corvus.Forms.MemberMenus
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
            components = new System.ComponentModel.Container();
            txtAmount = new TextBox();
            txtRate = new TextBox();
            txtFee = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            exchangeBindingSource = new BindingSource(components);
            txtSubTotal = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)exchangeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(199, 175);
            txtAmount.Margin = new Padding(6, 6, 6, 6);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(331, 39);
            txtAmount.TabIndex = 0;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(199, 279);
            txtRate.Margin = new Padding(6, 6, 6, 6);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(331, 39);
            txtRate.TabIndex = 1;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(199, 480);
            txtFee.Margin = new Padding(6, 6, 6, 6);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(331, 39);
            txtFee.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(199, 589);
            txtTotal.Margin = new Padding(6, 6, 6, 6);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(331, 39);
            txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(199, 43);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 51);
            label1.TabIndex = 4;
            label1.Text = "Exchange USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 181);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 286);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 32);
            label3.TabIndex = 6;
            label3.Text = "Rate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 486);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 32);
            label4.TabIndex = 7;
            label4.Text = "Fee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 595);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 8;
            label5.Text = "Total";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Purple;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(199, 695);
            btnSubmit.Margin = new Padding(6, 6, 6, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 49);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Purple;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(394, 695);
            btnClear.Margin = new Padding(6, 6, 6, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 49);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // exchangeBindingSource
            // 
            exchangeBindingSource.DataSource = typeof(Models.Exchange);
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(199, 380);
            txtSubTotal.Margin = new Padding(6, 6, 6, 6);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(331, 39);
            txtSubTotal.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 386);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 32);
            label7.TabIndex = 14;
            label7.Text = "Sub Total";
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            Controls.Add(label7);
            Controls.Add(txtSubTotal);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtFee);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ExchangePage";
            Size = new Size(641, 826);
            Load += ExchangePage_Load;
            ((System.ComponentModel.ISupportInitialize)exchangeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private TextBox txtRate;
        private TextBox txtFee;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
        private Button btnClear;
        private BindingSource exchangeBindingSource;
        private TextBox txtSubTotal;
        private Label label7;
    }
}
