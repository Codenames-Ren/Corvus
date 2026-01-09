namespace Corvus.Forms.MemberMenus
{
    partial class LoanPage
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
            textAmount = new TextBox();
            installmentBindingSource = new BindingSource(components);
            dataGridViewLoan = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LoanId = new DataGridViewTextBoxColumn();
            outstanding = new DataGridViewTextBoxColumn();
            tenorLeft = new DataGridViewTextBoxColumn();
            Fine = new DataGridViewTextBoxColumn();
            loanBindingSource = new BindingSource(components);
            loanMasterBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            comboLoanMaster = new ComboBox();
            label3 = new Label();
            textTenor = new TextBox();
            label4 = new Label();
            textInterest = new TextBox();
            label5 = new Label();
            textInterestFine = new TextBox();
            label6 = new Label();
            textDueDate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textDocSlip = new TextBox();
            textDocKtp = new TextBox();
            textDocKK = new TextBox();
            buttonFileKTP = new Button();
            buttonFileKK = new Button();
            buttonFileSlip = new Button();
            buttonApply = new Button();
            buttonNewLoan = new Button();
            buttonShowDocKtp = new Button();
            buttonShowDocKk = new Button();
            buttonShowDocSlip = new Button();
            label10 = new Label();
            labelId = new Label();
            labelLoanID = new Label();
            textLoanId = new TextBox();
            label11 = new Label();
            textAdminFee = new TextBox();
            label12 = new Label();
            textMinAmount = new TextBox();
            label13 = new Label();
            textMaxAmount = new TextBox();
            buttonReload = new Button();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textAmount
            // 
            textAmount.Location = new Point(451, 90);
            textAmount.Margin = new Padding(6, 6, 6, 6);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(375, 39);
            textAmount.TabIndex = 0;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.AllowUserToAddRows = false;
            dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewLoan.AutoGenerateColumns = false;
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, LoanId, outstanding, tenorLeft, Fine });
            dataGridViewLoan.DataSource = loanBindingSource;
            dataGridViewLoan.Location = new Point(862, 90);
            dataGridViewLoan.Margin = new Padding(6, 6, 6, 6);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.ReadOnly = true;
            dataGridViewLoan.RowHeadersWidth = 82;
            dataGridViewLoan.Size = new Size(912, 719);
            dataGridViewLoan.TabIndex = 2;
            dataGridViewLoan.CellClick += dataGridViewLoan_CellClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 10;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 200;
            // 
            // LoanId
            // 
            LoanId.DataPropertyName = "LoanId";
            LoanId.HeaderText = "LoanId";
            LoanId.MinimumWidth = 10;
            LoanId.Name = "LoanId";
            LoanId.ReadOnly = true;
            LoanId.Width = 200;
            // 
            // outstanding
            // 
            outstanding.DataPropertyName = "outstanding";
            outstanding.HeaderText = "outstanding";
            outstanding.MinimumWidth = 10;
            outstanding.Name = "outstanding";
            outstanding.ReadOnly = true;
            outstanding.Width = 200;
            // 
            // tenorLeft
            // 
            tenorLeft.DataPropertyName = "tenorLeft";
            tenorLeft.HeaderText = "tenorLeft";
            tenorLeft.MinimumWidth = 10;
            tenorLeft.Name = "tenorLeft";
            tenorLeft.ReadOnly = true;
            tenorLeft.Width = 200;
            // 
            // Fine
            // 
            Fine.DataPropertyName = "Fine";
            Fine.HeaderText = "Fine";
            Fine.MinimumWidth = 10;
            Fine.Name = "Fine";
            Fine.ReadOnly = true;
            Fine.Width = 200;
            // 
            // loanBindingSource
            // 
            loanBindingSource.DataSource = typeof(Models.Loan);
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(457, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 3;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 158);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 4;
            label2.Text = "Loan Type";
            // 
            // comboLoanMaster
            // 
            comboLoanMaster.DataSource = loanMasterBindingSource;
            comboLoanMaster.FormattingEnabled = true;
            comboLoanMaster.Location = new Point(43, 196);
            comboLoanMaster.Margin = new Padding(6, 6, 6, 6);
            comboLoanMaster.Name = "comboLoanMaster";
            comboLoanMaster.Size = new Size(375, 40);
            comboLoanMaster.TabIndex = 5;
            comboLoanMaster.SelectedIndexChanged += comboLoanMaster_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(457, 252);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 7;
            label3.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(451, 290);
            textTenor.Margin = new Padding(6, 6, 6, 6);
            textTenor.Name = "textTenor";
            textTenor.ReadOnly = true;
            textTenor.Size = new Size(375, 39);
            textTenor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(457, 158);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 9;
            label4.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(451, 196);
            textInterest.Margin = new Padding(6, 6, 6, 6);
            textInterest.Name = "textInterest";
            textInterest.ReadOnly = true;
            textInterest.Size = new Size(375, 39);
            textInterest.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 442);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 11;
            label5.Text = "Interest Fine";
            // 
            // textInterestFine
            // 
            textInterestFine.Location = new Point(43, 480);
            textInterestFine.Margin = new Padding(6, 6, 6, 6);
            textInterestFine.Name = "textInterestFine";
            textInterestFine.ReadOnly = true;
            textInterestFine.Size = new Size(375, 39);
            textInterestFine.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 538);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 13;
            label6.Text = "Due Date";
            // 
            // textDueDate
            // 
            textDueDate.Location = new Point(43, 576);
            textDueDate.Margin = new Padding(6, 6, 6, 6);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(375, 39);
            textDueDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(457, 640);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(219, 32);
            label7.TabIndex = 19;
            label7.Text = "Document Slip Gaji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(457, 442);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(173, 32);
            label8.TabIndex = 17;
            label8.Text = "Document KTP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(48, 640);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(161, 32);
            label9.TabIndex = 15;
            label9.Text = "Document KK";
            // 
            // textDocSlip
            // 
            textDocSlip.Location = new Point(451, 678);
            textDocSlip.Margin = new Padding(6, 6, 6, 6);
            textDocSlip.Name = "textDocSlip";
            textDocSlip.ReadOnly = true;
            textDocSlip.Size = new Size(375, 39);
            textDocSlip.TabIndex = 22;
            // 
            // textDocKtp
            // 
            textDocKtp.Location = new Point(451, 480);
            textDocKtp.Margin = new Padding(6, 6, 6, 6);
            textDocKtp.Name = "textDocKtp";
            textDocKtp.ReadOnly = true;
            textDocKtp.Size = new Size(375, 39);
            textDocKtp.TabIndex = 21;
            // 
            // textDocKK
            // 
            textDocKK.Location = new Point(43, 678);
            textDocKK.Margin = new Padding(6, 6, 6, 6);
            textDocKK.Name = "textDocKK";
            textDocKK.ReadOnly = true;
            textDocKK.Size = new Size(375, 39);
            textDocKK.TabIndex = 20;
            // 
            // buttonFileKTP
            // 
            buttonFileKTP.BackColor = Color.Purple;
            buttonFileKTP.ForeColor = Color.White;
            buttonFileKTP.Location = new Point(451, 542);
            buttonFileKTP.Margin = new Padding(6, 6, 6, 6);
            buttonFileKTP.Name = "buttonFileKTP";
            buttonFileKTP.Size = new Size(137, 49);
            buttonFileKTP.TabIndex = 23;
            buttonFileKTP.Text = "Browse";
            buttonFileKTP.UseVisualStyleBackColor = false;
            buttonFileKTP.Click += buttonFileKTP_Click;
            // 
            // buttonFileKK
            // 
            buttonFileKK.BackColor = Color.Purple;
            buttonFileKK.ForeColor = Color.White;
            buttonFileKK.Location = new Point(43, 740);
            buttonFileKK.Margin = new Padding(6, 6, 6, 6);
            buttonFileKK.Name = "buttonFileKK";
            buttonFileKK.Size = new Size(137, 49);
            buttonFileKK.TabIndex = 24;
            buttonFileKK.Text = "Browse";
            buttonFileKK.UseVisualStyleBackColor = false;
            buttonFileKK.Click += buttonFileKK_Click;
            // 
            // buttonFileSlip
            // 
            buttonFileSlip.BackColor = Color.Purple;
            buttonFileSlip.ForeColor = Color.White;
            buttonFileSlip.Location = new Point(451, 740);
            buttonFileSlip.Margin = new Padding(6, 6, 6, 6);
            buttonFileSlip.Name = "buttonFileSlip";
            buttonFileSlip.Size = new Size(137, 49);
            buttonFileSlip.TabIndex = 25;
            buttonFileSlip.Text = "Browse";
            buttonFileSlip.UseVisualStyleBackColor = false;
            buttonFileSlip.Click += buttonFileSlip_Click;
            // 
            // buttonApply
            // 
            buttonApply.BackColor = Color.Purple;
            buttonApply.ForeColor = Color.White;
            buttonApply.Location = new Point(171, 853);
            buttonApply.Margin = new Padding(6, 6, 6, 6);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(251, 49);
            buttonApply.TabIndex = 26;
            buttonApply.Text = "Apply Loan";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonNewLoan
            // 
            buttonNewLoan.BackColor = Color.Purple;
            buttonNewLoan.ForeColor = Color.White;
            buttonNewLoan.Location = new Point(451, 853);
            buttonNewLoan.Margin = new Padding(6, 6, 6, 6);
            buttonNewLoan.Name = "buttonNewLoan";
            buttonNewLoan.Size = new Size(232, 49);
            buttonNewLoan.TabIndex = 27;
            buttonNewLoan.Text = "New Loan";
            buttonNewLoan.UseVisualStyleBackColor = false;
            buttonNewLoan.Click += buttonNewLoan_Click;
            // 
            // buttonShowDocKtp
            // 
            buttonShowDocKtp.BackColor = Color.Purple;
            buttonShowDocKtp.ForeColor = Color.White;
            buttonShowDocKtp.Location = new Point(693, 542);
            buttonShowDocKtp.Margin = new Padding(6, 6, 6, 6);
            buttonShowDocKtp.Name = "buttonShowDocKtp";
            buttonShowDocKtp.Size = new Size(137, 49);
            buttonShowDocKtp.TabIndex = 29;
            buttonShowDocKtp.Text = "Show";
            buttonShowDocKtp.UseVisualStyleBackColor = false;
            // 
            // buttonShowDocKk
            // 
            buttonShowDocKk.BackColor = Color.Purple;
            buttonShowDocKk.ForeColor = Color.White;
            buttonShowDocKk.Location = new Point(284, 740);
            buttonShowDocKk.Margin = new Padding(6, 6, 6, 6);
            buttonShowDocKk.Name = "buttonShowDocKk";
            buttonShowDocKk.Size = new Size(137, 49);
            buttonShowDocKk.TabIndex = 30;
            buttonShowDocKk.Text = "Show";
            buttonShowDocKk.UseVisualStyleBackColor = false;
            // 
            // buttonShowDocSlip
            // 
            buttonShowDocSlip.BackColor = Color.Purple;
            buttonShowDocSlip.ForeColor = Color.White;
            buttonShowDocSlip.Location = new Point(693, 740);
            buttonShowDocSlip.Margin = new Padding(6, 6, 6, 6);
            buttonShowDocSlip.Name = "buttonShowDocSlip";
            buttonShowDocSlip.Size = new Size(137, 49);
            buttonShowDocSlip.TabIndex = 31;
            buttonShowDocSlip.Text = "Show";
            buttonShowDocSlip.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(867, 51);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 32);
            label10.TabIndex = 32;
            label10.Text = "Loan";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(284, 53);
            labelId.Margin = new Padding(6, 0, 6, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 32);
            labelId.TabIndex = 34;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // labelLoanID
            // 
            labelLoanID.AutoSize = true;
            labelLoanID.ForeColor = Color.White;
            labelLoanID.Location = new Point(48, 53);
            labelLoanID.Margin = new Padding(6, 0, 6, 0);
            labelLoanID.Name = "labelLoanID";
            labelLoanID.Size = new Size(95, 32);
            labelLoanID.TabIndex = 35;
            labelLoanID.Text = "Loan ID";
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(43, 90);
            textLoanId.Margin = new Padding(6, 6, 6, 6);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(375, 39);
            textLoanId.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(48, 252);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(129, 32);
            label11.TabIndex = 38;
            label11.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(43, 290);
            textAdminFee.Margin = new Padding(6, 6, 6, 6);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.ReadOnly = true;
            textAdminFee.Size = new Size(375, 39);
            textAdminFee.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(48, 348);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(149, 32);
            label12.TabIndex = 42;
            label12.Text = "Min Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(43, 386);
            textMinAmount.Margin = new Padding(6, 6, 6, 6);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.ReadOnly = true;
            textMinAmount.Size = new Size(375, 39);
            textMinAmount.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(457, 348);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(152, 32);
            label13.TabIndex = 40;
            label13.Text = "Max Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(451, 386);
            textMaxAmount.Margin = new Padding(6, 6, 6, 6);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.ReadOnly = true;
            textMaxAmount.Size = new Size(375, 39);
            textMaxAmount.TabIndex = 39;
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.Purple;
            buttonReload.ForeColor = Color.White;
            buttonReload.Location = new Point(1200, 853);
            buttonReload.Margin = new Padding(6, 6, 6, 6);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(232, 49);
            buttonReload.TabIndex = 43;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // LoanPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            Controls.Add(buttonReload);
            Controls.Add(label12);
            Controls.Add(textMinAmount);
            Controls.Add(label13);
            Controls.Add(textMaxAmount);
            Controls.Add(label11);
            Controls.Add(textAdminFee);
            Controls.Add(textLoanId);
            Controls.Add(labelLoanID);
            Controls.Add(labelId);
            Controls.Add(label10);
            Controls.Add(buttonShowDocSlip);
            Controls.Add(buttonShowDocKk);
            Controls.Add(buttonShowDocKtp);
            Controls.Add(buttonNewLoan);
            Controls.Add(buttonApply);
            Controls.Add(buttonFileSlip);
            Controls.Add(buttonFileKK);
            Controls.Add(buttonFileKTP);
            Controls.Add(textDocSlip);
            Controls.Add(textDocKtp);
            Controls.Add(textDocKK);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(textDueDate);
            Controls.Add(label5);
            Controls.Add(textInterestFine);
            Controls.Add(label4);
            Controls.Add(textInterest);
            Controls.Add(label3);
            Controls.Add(textTenor);
            Controls.Add(comboLoanMaster);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewLoan);
            Controls.Add(textAmount);
            Margin = new Padding(6, 6, 6, 6);
            Name = "LoanPage";
            Size = new Size(1813, 943);
            Load += LoanPage_Load;
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAmount;
        private DataGridView dataGridViewLoan;
        private Label label1;
        private Label label2;
        private ComboBox comboLoanMaster;
        private Label label3;
        private TextBox textTenor;
        private Label label4;
        private TextBox textInterest;
        private Label label5;
        private TextBox textInterestFine;
        private Label label6;
        private TextBox textDueDate;
        private Label label7;
        private Label label8;
        private Label label9;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textDocSlip;
        private TextBox textDocKtp;
        private TextBox textDocKK;
        private Button buttonFileKTP;
        private Button buttonFileKK;
        private Button buttonFileSlip;
        private Button buttonApply;
        private BindingSource loanMasterBindingSource;
        private Button buttonNewLoan;
        private Button buttonShowDocKtp;
        private Button buttonShowDocKk;
        private Button buttonShowDocSlip;
        private Label label10;
        private Label labelId;
        private BindingSource installmentBindingSource;
        private BindingSource loanBindingSource;
        private Label labelLoanID;
        private TextBox textLoanId;
        private Label label11;
        private TextBox textAdminFee;
        private Label label12;
        private TextBox textMinAmount;
        private Label label13;
        private TextBox textMaxAmount;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LoanId;
        private DataGridViewTextBoxColumn outstanding;
        private DataGridViewTextBoxColumn tenorLeft;
        private DataGridViewTextBoxColumn Fine;
        private Button buttonReload;
    }
}
