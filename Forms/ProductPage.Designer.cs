namespace Corvus.Forms
{
    partial class ProductPage
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
            name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tenor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmb_mode = new ComboBox();
            submit = new Button();
            baru = new Button();
            minimum_amount = new TextBox();
            interest = new TextBox();
            maximum_amount = new TextBox();
            interest_fine = new TextBox();
            admin_fee = new TextBox();
            label9 = new Label();
            dataGridLoan = new DataGridView();
            dataGridSaving = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSaving).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(16, 47);
            name.Name = "name";
            name.Size = new Size(350, 31);
            name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 4;
            label2.Text = "Tenor";
            // 
            // tenor
            // 
            tenor.Location = new Point(15, 131);
            tenor.Name = "tenor";
            tenor.Size = new Size(351, 31);
            tenor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 99);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 8;
            label3.Text = "Admin Fee";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 15);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 6;
            label4.Text = "Mode";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(728, 99);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 12;
            label5.Text = "Minimum Amount";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(728, 20);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 10;
            label6.Text = "Interest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1083, 20);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 14;
            label8.Text = "Interest Fine";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1083, 99);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 16;
            label7.Text = "Maximum Amount";
            // 
            // cmb_mode
            // 
            cmb_mode.FormattingEnabled = true;
            cmb_mode.Location = new Point(372, 47);
            cmb_mode.Name = "cmb_mode";
            cmb_mode.Size = new Size(350, 33);
            cmb_mode.TabIndex = 17;
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ScrollBar;
            submit.Location = new Point(16, 191);
            submit.Name = "submit";
            submit.Size = new Size(127, 46);
            submit.TabIndex = 0;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            // 
            // baru
            // 
            baru.BackColor = SystemColors.ScrollBar;
            baru.Location = new Point(149, 191);
            baru.Name = "baru";
            baru.Size = new Size(127, 46);
            baru.TabIndex = 18;
            baru.Text = "New";
            baru.UseVisualStyleBackColor = false;
            // 
            // minimum_amount
            // 
            minimum_amount.Location = new Point(727, 133);
            minimum_amount.Name = "minimum_amount";
            minimum_amount.Size = new Size(351, 31);
            minimum_amount.TabIndex = 20;
            // 
            // interest
            // 
            interest.Location = new Point(728, 49);
            interest.Name = "interest";
            interest.Size = new Size(350, 31);
            interest.TabIndex = 19;
            // 
            // maximum_amount
            // 
            maximum_amount.Location = new Point(1083, 133);
            maximum_amount.Name = "maximum_amount";
            maximum_amount.Size = new Size(351, 31);
            maximum_amount.TabIndex = 22;
            // 
            // interest_fine
            // 
            interest_fine.Location = new Point(1084, 49);
            interest_fine.Name = "interest_fine";
            interest_fine.Size = new Size(350, 31);
            interest_fine.TabIndex = 21;
            // 
            // admin_fee
            // 
            admin_fee.Location = new Point(370, 133);
            admin_fee.Name = "admin_fee";
            admin_fee.Size = new Size(351, 31);
            admin_fee.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 263);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 24;
            label9.Text = "Master Loan";
            label9.Click += label9_Click;
            // 
            // dataGridLoan
            // 
            dataGridLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLoan.Location = new Point(23, 302);
            dataGridLoan.Name = "dataGridLoan";
            dataGridLoan.RowHeadersWidth = 62;
            dataGridLoan.Size = new Size(699, 387);
            dataGridLoan.TabIndex = 25;
            // 
            // dataGridSaving
            // 
            dataGridSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSaving.Location = new Point(735, 302);
            dataGridSaving.Name = "dataGridSaving";
            dataGridSaving.RowHeadersWidth = 62;
            dataGridSaving.Size = new Size(699, 387);
            dataGridSaving.TabIndex = 26;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridSaving);
            Controls.Add(dataGridLoan);
            Controls.Add(label9);
            Controls.Add(admin_fee);
            Controls.Add(maximum_amount);
            Controls.Add(interest_fine);
            Controls.Add(minimum_amount);
            Controls.Add(interest);
            Controls.Add(baru);
            Controls.Add(cmb_mode);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tenor);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(submit);
            Name = "ProductPage";
            Size = new Size(1917, 784);
            Load += ProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSaving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox name;
        private Label label1;
        private Label label2;
        private TextBox tenor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private ComboBox cmb_mode;
        private Button submit;
        private Button baru;
        private TextBox minimum_amount;
        private TextBox interest;
        private TextBox maximum_amount;
        private TextBox interest_fine;
        private TextBox admin_fee;
        private Label label9;
        private DataGridView dataGridLoan;
        private DataGridView dataGridSaving;
    }
}
