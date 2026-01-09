namespace Corvus.Forms.MemberMenus
{
    partial class SavingPage
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
            buttonReload = new Button();
            label12 = new Label();
            textMinAmount = new TextBox();
            label13 = new Label();
            textMaxAmount = new TextBox();
            label11 = new Label();
            textAdminFee = new TextBox();
            textLoanId = new TextBox();
            labelSavingID = new Label();
            labelId = new Label();
            label10 = new Label();
            buttonShowDocSlip = new Button();
            buttonShowDocKk = new Button();
            buttonShowDocKtp = new Button();
            buttonNewSaving = new Button();
            buttonApply = new Button();
            buttonFileSlip = new Button();
            buttonFileKK = new Button();
            buttonFileKTP = new Button();
            textDocSlip = new TextBox();
            textDocKtp = new TextBox();
            textDocKK = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            textDueDate = new TextBox();
            label5 = new Label();
            textInterestFine = new TextBox();
            label4 = new Label();
            textInterest = new TextBox();
            label3 = new Label();
            textTenor = new TextBox();
            comboSavingMaster = new ComboBox();
            loanMasterBindingSource = new BindingSource(components);
            label2 = new Label();
            installmentBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LoanId = new DataGridViewTextBoxColumn();
            outstanding = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Fine = new DataGridViewTextBoxColumn();
            loanBindingSource = new BindingSource(components);
            dataGridViewSaving = new DataGridView();
            tenorLeft = new DataGridViewTextBoxColumn();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).BeginInit();
            SuspendLayout();
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.Purple;
            buttonReload.ForeColor = Color.White;
            buttonReload.Location = new Point(1198, 849);
            buttonReload.Margin = new Padding(6);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(232, 49);
            buttonReload.TabIndex = 81;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(46, 343);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(149, 32);
            label12.TabIndex = 80;
            label12.Text = "Min Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(41, 382);
            textMinAmount.Margin = new Padding(6);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.ReadOnly = true;
            textMinAmount.Size = new Size(375, 39);
            textMinAmount.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(455, 343);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(152, 32);
            label13.TabIndex = 78;
            label13.Text = "Max Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(449, 382);
            textMaxAmount.Margin = new Padding(6);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.ReadOnly = true;
            textMaxAmount.Size = new Size(375, 39);
            textMaxAmount.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(46, 247);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(129, 32);
            label11.TabIndex = 76;
            label11.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(41, 286);
            textAdminFee.Margin = new Padding(6);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.ReadOnly = true;
            textAdminFee.Size = new Size(375, 39);
            textAdminFee.TabIndex = 75;
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(41, 85);
            textLoanId.Margin = new Padding(6);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(375, 39);
            textLoanId.TabIndex = 74;
            // 
            // labelSavingID
            // 
            labelSavingID.AutoSize = true;
            labelSavingID.ForeColor = Color.White;
            labelSavingID.Location = new Point(46, 49);
            labelSavingID.Margin = new Padding(6, 0, 6, 0);
            labelSavingID.Name = "labelSavingID";
            labelSavingID.Size = new Size(122, 32);
            labelSavingID.TabIndex = 73;
            labelSavingID.Text = " Saving ID";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(282, 49);
            labelId.Margin = new Padding(6, 0, 6, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 32);
            labelId.TabIndex = 72;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(865, 47);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 32);
            label10.TabIndex = 71;
            label10.Text = "Saving";
            // 
            // buttonShowDocSlip
            // 
            buttonShowDocSlip.BackColor = Color.Purple;
            buttonShowDocSlip.ForeColor = Color.White;
            buttonShowDocSlip.Location = new Point(691, 736);
            buttonShowDocSlip.Margin = new Padding(6);
            buttonShowDocSlip.Name = "buttonShowDocSlip";
            buttonShowDocSlip.Size = new Size(137, 49);
            buttonShowDocSlip.TabIndex = 70;
            buttonShowDocSlip.Text = "Show";
            buttonShowDocSlip.UseVisualStyleBackColor = false;
            // 
            // buttonShowDocKk
            // 
            buttonShowDocKk.BackColor = Color.Purple;
            buttonShowDocKk.ForeColor = Color.White;
            buttonShowDocKk.Location = new Point(282, 736);
            buttonShowDocKk.Margin = new Padding(6);
            buttonShowDocKk.Name = "buttonShowDocKk";
            buttonShowDocKk.Size = new Size(137, 49);
            buttonShowDocKk.TabIndex = 69;
            buttonShowDocKk.Text = "Show";
            buttonShowDocKk.UseVisualStyleBackColor = false;
            // 
            // buttonShowDocKtp
            // 
            buttonShowDocKtp.BackColor = Color.Purple;
            buttonShowDocKtp.ForeColor = Color.White;
            buttonShowDocKtp.Location = new Point(691, 538);
            buttonShowDocKtp.Margin = new Padding(6);
            buttonShowDocKtp.Name = "buttonShowDocKtp";
            buttonShowDocKtp.Size = new Size(137, 49);
            buttonShowDocKtp.TabIndex = 68;
            buttonShowDocKtp.Text = "Show";
            buttonShowDocKtp.UseVisualStyleBackColor = false;
            // 
            // buttonNewSaving
            // 
            buttonNewSaving.BackColor = Color.Purple;
            buttonNewSaving.ForeColor = Color.White;
            buttonNewSaving.Location = new Point(449, 849);
            buttonNewSaving.Margin = new Padding(6);
            buttonNewSaving.Name = "buttonNewSaving";
            buttonNewSaving.Size = new Size(232, 49);
            buttonNewSaving.TabIndex = 67;
            buttonNewSaving.Text = "New Saving";
            buttonNewSaving.UseVisualStyleBackColor = false;
            buttonNewSaving.Click += buttonNewSaving_Click;
            // 
            // buttonApply
            // 
            buttonApply.BackColor = Color.Purple;
            buttonApply.ForeColor = Color.White;
            buttonApply.Location = new Point(169, 849);
            buttonApply.Margin = new Padding(6);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(251, 49);
            buttonApply.TabIndex = 66;
            buttonApply.Text = "Apply Saving";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonFileSlip
            // 
            buttonFileSlip.BackColor = Color.Purple;
            buttonFileSlip.ForeColor = Color.White;
            buttonFileSlip.Location = new Point(449, 736);
            buttonFileSlip.Margin = new Padding(6);
            buttonFileSlip.Name = "buttonFileSlip";
            buttonFileSlip.Size = new Size(137, 49);
            buttonFileSlip.TabIndex = 65;
            buttonFileSlip.Text = "Browse";
            buttonFileSlip.UseVisualStyleBackColor = false;
            // 
            // buttonFileKK
            // 
            buttonFileKK.BackColor = Color.Purple;
            buttonFileKK.ForeColor = Color.White;
            buttonFileKK.Location = new Point(41, 736);
            buttonFileKK.Margin = new Padding(6);
            buttonFileKK.Name = "buttonFileKK";
            buttonFileKK.Size = new Size(137, 49);
            buttonFileKK.TabIndex = 64;
            buttonFileKK.Text = "Browse";
            buttonFileKK.UseVisualStyleBackColor = false;
            buttonFileKK.Click += buttonFileKK_Click;
            // 
            // buttonFileKTP
            // 
            buttonFileKTP.BackColor = Color.Purple;
            buttonFileKTP.ForeColor = Color.White;
            buttonFileKTP.Location = new Point(449, 538);
            buttonFileKTP.Margin = new Padding(6);
            buttonFileKTP.Name = "buttonFileKTP";
            buttonFileKTP.Size = new Size(137, 49);
            buttonFileKTP.TabIndex = 63;
            buttonFileKTP.Text = "Browse";
            buttonFileKTP.UseVisualStyleBackColor = false;
            // 
            // textDocSlip
            // 
            textDocSlip.Location = new Point(449, 674);
            textDocSlip.Margin = new Padding(6);
            textDocSlip.Name = "textDocSlip";
            textDocSlip.ReadOnly = true;
            textDocSlip.Size = new Size(375, 39);
            textDocSlip.TabIndex = 62;
            // 
            // textDocKtp
            // 
            textDocKtp.Location = new Point(449, 476);
            textDocKtp.Margin = new Padding(6);
            textDocKtp.Name = "textDocKtp";
            textDocKtp.ReadOnly = true;
            textDocKtp.Size = new Size(375, 39);
            textDocKtp.TabIndex = 61;
            // 
            // textDocKK
            // 
            textDocKK.Location = new Point(41, 674);
            textDocKK.Margin = new Padding(6);
            textDocKK.Name = "textDocKK";
            textDocKK.ReadOnly = true;
            textDocKK.Size = new Size(375, 39);
            textDocKK.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(455, 636);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(219, 32);
            label7.TabIndex = 59;
            label7.Text = "Document Slip Gaji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(455, 437);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(173, 32);
            label8.TabIndex = 58;
            label8.Text = "Document KTP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(46, 636);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(161, 32);
            label9.TabIndex = 57;
            label9.Text = "Document KK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(46, 533);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 56;
            label6.Text = "Due Date";
            // 
            // textDueDate
            // 
            textDueDate.Location = new Point(41, 572);
            textDueDate.Margin = new Padding(6);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(375, 39);
            textDueDate.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 437);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 54;
            label5.Text = "Interest Fine";
            // 
            // textInterestFine
            // 
            textInterestFine.Location = new Point(41, 476);
            textInterestFine.Margin = new Padding(6);
            textInterestFine.Name = "textInterestFine";
            textInterestFine.ReadOnly = true;
            textInterestFine.Size = new Size(375, 39);
            textInterestFine.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(455, 154);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 52;
            label4.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(449, 192);
            textInterest.Margin = new Padding(6);
            textInterest.Name = "textInterest";
            textInterest.ReadOnly = true;
            textInterest.Size = new Size(375, 39);
            textInterest.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(455, 247);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 50;
            label3.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(449, 286);
            textTenor.Margin = new Padding(6);
            textTenor.Name = "textTenor";
            textTenor.ReadOnly = true;
            textTenor.Size = new Size(375, 39);
            textTenor.TabIndex = 49;
            // 
            // comboSavingMaster
            // 
            comboSavingMaster.DataSource = loanMasterBindingSource;
            comboSavingMaster.FormattingEnabled = true;
            comboSavingMaster.Location = new Point(41, 192);
            comboSavingMaster.Margin = new Padding(6);
            comboSavingMaster.Name = "comboSavingMaster";
            comboSavingMaster.Size = new Size(375, 40);
            comboSavingMaster.TabIndex = 48;
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 154);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 47;
            label2.Text = "Saving Type";
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(455, 47);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 46;
            label1.Text = "Amount";
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
            // dataGridViewSaving
            // 
            dataGridViewSaving.AllowUserToAddRows = false;
            dataGridViewSaving.AllowUserToDeleteRows = false;
            dataGridViewSaving.AutoGenerateColumns = false;
            dataGridViewSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaving.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, LoanId, outstanding, tenorLeft, Fine });
            dataGridViewSaving.DataSource = loanBindingSource;
            dataGridViewSaving.Location = new Point(860, 85);
            dataGridViewSaving.Margin = new Padding(6);
            dataGridViewSaving.Name = "dataGridViewSaving";
            dataGridViewSaving.ReadOnly = true;
            dataGridViewSaving.RowHeadersWidth = 82;
            dataGridViewSaving.Size = new Size(912, 719);
            dataGridViewSaving.TabIndex = 45;
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
            // textAmount
            // 
            textAmount.Location = new Point(449, 85);
            textAmount.Margin = new Padding(6);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(375, 39);
            textAmount.TabIndex = 44;
            // 
            // SavingPage
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
            Controls.Add(labelSavingID);
            Controls.Add(labelId);
            Controls.Add(label10);
            Controls.Add(buttonShowDocSlip);
            Controls.Add(buttonShowDocKk);
            Controls.Add(buttonShowDocKtp);
            Controls.Add(buttonNewSaving);
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
            Controls.Add(comboSavingMaster);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewSaving);
            Controls.Add(textAmount);
            Margin = new Padding(6);
            Name = "SavingPage";
            Size = new Size(1813, 943);
            Load += SavingPage_Load;
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReload;
        private Label label12;
        private TextBox textMinAmount;
        private Label label13;
        private TextBox textMaxAmount;
        private Label label11;
        private TextBox textAdminFee;
        private TextBox textLoanId;
        private Label labelSavingID;
        private Label labelId;
        private Label label10;
        private Button buttonShowDocSlip;
        private Button buttonShowDocKk;
        private Button buttonShowDocKtp;
        private Button buttonNewSaving;
        private Button buttonApply;
        private Button buttonFileSlip;
        private Button buttonFileKK;
        private Button buttonFileKTP;
        private TextBox textDocSlip;
        private TextBox textDocKtp;
        private TextBox textDocKK;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private TextBox textDueDate;
        private Label label5;
        private TextBox textInterestFine;
        private Label label4;
        private TextBox textInterest;
        private Label label3;
        private TextBox textTenor;
        private ComboBox comboSavingMaster;
        private BindingSource loanMasterBindingSource;
        private Label label2;
        private BindingSource installmentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LoanId;
        private DataGridViewTextBoxColumn outstanding;
        private Label label1;
        private DataGridViewTextBoxColumn Fine;
        private BindingSource loanBindingSource;
        private DataGridView dataGridViewSaving;
        private DataGridViewTextBoxColumn tenorLeft;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textAmount;
    }
}
