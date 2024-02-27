namespace SalesWinApp
{
    partial class frmMembers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbMemberID = new Label();
            txtMemberID = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCountry = new Label();
            lbCity = new Label();
            lbCompanyName = new Label();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtCompanyName = new TextBox();
            btnLoad = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvMember = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(43, 38);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(87, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(138, 35);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(230, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(81, 84);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(57, 127);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 27);
            txtPassword.TabIndex = 3;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(504, 38);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(63, 20);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country:";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(530, 81);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(37, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City:";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(448, 127);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(119, 20);
            lbCompanyName.TabIndex = 0;
            lbCompanyName.Text = "Company Name:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(573, 35);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(249, 27);
            txtCountry.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(573, 81);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(249, 27);
            txtCity.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(573, 124);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(249, 27);
            txtCompanyName.TabIndex = 6;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(43, 189);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(274, 189);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(494, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(742, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(406, 605);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 233);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(880, 366);
            dgvMember.TabIndex = 11;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 646);
            Controls.Add(dgvMember);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCompanyName);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(lbCompanyName);
            Controls.Add(txtMemberID);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private TextBox txtMemberID;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCountry;
        private Label lbCity;
        private Label lbCompanyName;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private Button btnLoad;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvMember;
    }
}