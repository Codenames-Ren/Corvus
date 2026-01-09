namespace Corvus.Forms.AdminMenus
{
    partial class AccessPage
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
            dataGridViewAccess = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            memberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessListDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updateOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessBindingSource = new BindingSource(components);
            comboMember = new ComboBox();
            memberBindingSource = new BindingSource(components);
            listBoxAccess = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            labelAddress = new Label();
            labelPhoneAlt = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelJoinDate = new Label();
            labelFullName = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAccess
            // 
            dataGridViewAccess.AllowUserToAddRows = false;
            dataGridViewAccess.AllowUserToDeleteRows = false;
            dataGridViewAccess.AllowUserToOrderColumns = true;
            dataGridViewAccess.AutoGenerateColumns = false;
            dataGridViewAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccess.Columns.AddRange(new DataGridViewColumn[] { Id, memberDataGridViewTextBoxColumn, accessListDataGridViewTextBoxColumn, updateOnDataGridViewTextBoxColumn });
            dataGridViewAccess.DataSource = accessBindingSource;
            dataGridViewAccess.Location = new Point(492, 81);
            dataGridViewAccess.Margin = new Padding(6, 6, 6, 6);
            dataGridViewAccess.Name = "dataGridViewAccess";
            dataGridViewAccess.ReadOnly = true;
            dataGridViewAccess.RowHeadersWidth = 82;
            dataGridViewAccess.Size = new Size(884, 734);
            dataGridViewAccess.TabIndex = 0;
            dataGridViewAccess.CellContentClick += dataGridViewAccess_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 200;
            // 
            // memberDataGridViewTextBoxColumn
            // 
            memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            memberDataGridViewTextBoxColumn.HeaderText = "Member";
            memberDataGridViewTextBoxColumn.MinimumWidth = 10;
            memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            memberDataGridViewTextBoxColumn.ReadOnly = true;
            memberDataGridViewTextBoxColumn.Width = 200;
            // 
            // accessListDataGridViewTextBoxColumn
            // 
            accessListDataGridViewTextBoxColumn.DataPropertyName = "AccessList";
            accessListDataGridViewTextBoxColumn.HeaderText = "AccessList";
            accessListDataGridViewTextBoxColumn.MinimumWidth = 10;
            accessListDataGridViewTextBoxColumn.Name = "accessListDataGridViewTextBoxColumn";
            accessListDataGridViewTextBoxColumn.ReadOnly = true;
            accessListDataGridViewTextBoxColumn.Width = 200;
            // 
            // updateOnDataGridViewTextBoxColumn
            // 
            updateOnDataGridViewTextBoxColumn.DataPropertyName = "updateOn";
            updateOnDataGridViewTextBoxColumn.HeaderText = "updateOn";
            updateOnDataGridViewTextBoxColumn.MinimumWidth = 10;
            updateOnDataGridViewTextBoxColumn.Name = "updateOnDataGridViewTextBoxColumn";
            updateOnDataGridViewTextBoxColumn.ReadOnly = true;
            updateOnDataGridViewTextBoxColumn.Width = 200;
            // 
            // accessBindingSource
            // 
            accessBindingSource.DataSource = typeof(Models.Access);
            // 
            // comboMember
            // 
            comboMember.DataSource = memberBindingSource;
            comboMember.DisplayMember = "memberId";
            comboMember.FormattingEnabled = true;
            comboMember.Location = new Point(6, 81);
            comboMember.Margin = new Padding(6, 6, 6, 6);
            comboMember.Name = "comboMember";
            comboMember.Size = new Size(322, 40);
            comboMember.TabIndex = 1;
            comboMember.SelectedIndexChanged += comboMember_SelectedIndexChanged;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // listBoxAccess
            // 
            listBoxAccess.BackColor = Color.FromArgb(64, 0, 64);
            listBoxAccess.ForeColor = Color.White;
            listBoxAccess.FormattingEnabled = true;
            listBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            listBoxAccess.Location = new Point(6, 143);
            listBoxAccess.Margin = new Padding(6, 6, 6, 6);
            listBoxAccess.Name = "listBoxAccess";
            listBoxAccess.Size = new Size(472, 220);
            listBoxAccess.TabIndex = 2;
            listBoxAccess.SelectedIndexChanged += listBoxAccess_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 43);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 3;
            label1.Text = "Member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(498, 43);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 4;
            label2.Text = "Access";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAddress);
            groupBox1.Controls.Add(labelPhoneAlt);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelJoinDate);
            groupBox1.Controls.Add(labelFullName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(9, 395);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(472, 420);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.ForeColor = Color.White;
            labelAddress.Location = new Point(195, 322);
            labelAddress.Margin = new Padding(6, 0, 6, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(29, 32);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "...";
            // 
            // labelPhoneAlt
            // 
            labelPhoneAlt.AutoSize = true;
            labelPhoneAlt.ForeColor = Color.White;
            labelPhoneAlt.Location = new Point(195, 267);
            labelPhoneAlt.Margin = new Padding(6, 0, 6, 0);
            labelPhoneAlt.Name = "labelPhoneAlt";
            labelPhoneAlt.Size = new Size(29, 32);
            labelPhoneAlt.TabIndex = 10;
            labelPhoneAlt.Text = "...";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(195, 213);
            labelPhone.Margin = new Padding(6, 0, 6, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(29, 32);
            labelPhone.TabIndex = 9;
            labelPhone.Text = "...";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(195, 158);
            labelEmail.Margin = new Padding(6, 0, 6, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(29, 32);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "...";
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.ForeColor = Color.White;
            labelJoinDate.Location = new Point(195, 105);
            labelJoinDate.Margin = new Padding(6, 0, 6, 0);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(29, 32);
            labelJoinDate.TabIndex = 7;
            labelJoinDate.Text = "...";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.ForeColor = Color.White;
            labelFullName.Location = new Point(195, 49);
            labelFullName.Margin = new Padding(6, 0, 6, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(29, 32);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 322);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 32);
            label7.TabIndex = 5;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(11, 267);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(118, 32);
            label8.TabIndex = 4;
            label8.Text = "Phone Alt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 213);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 3;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 158);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 2;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 105);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 1;
            label4.Text = "Join Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 49);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Purple;
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(342, 81);
            buttonSubmit.Margin = new Padding(6, 6, 6, 6);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(139, 49);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            Controls.Add(buttonSubmit);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxAccess);
            Controls.Add(comboMember);
            Controls.Add(dataGridViewAccess);
            Margin = new Padding(6, 6, 6, 6);
            Name = "AccessPage";
            Size = new Size(1382, 849);
            Load += AccessPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAccess;
        private ComboBox comboMember;
        private CheckedListBox listBoxAccess;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label labelAddress;
        private Label labelPhoneAlt;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelJoinDate;
        private Label labelFullName;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private BindingSource accessBindingSource;
        private Button buttonSubmit;
        private BindingSource memberBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessListDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateOnDataGridViewTextBoxColumn;
    }
}
