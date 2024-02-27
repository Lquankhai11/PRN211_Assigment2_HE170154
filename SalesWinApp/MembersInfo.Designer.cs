namespace SalesWinApp
{
    partial class frmMembersInfo
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
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCompanyName = new Label();
            txtCompanyName = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            btnViewOrder = new Button();
            lbEmail = new Label();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(99, 27);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(87, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(203, 24);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(299, 27);
            txtMemberID.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(203, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(113, 119);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(203, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 27);
            txtPassword.TabIndex = 3;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(123, 161);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(63, 20);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(203, 158);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(299, 27);
            txtCountry.TabIndex = 4;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(149, 202);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(37, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(203, 199);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(299, 27);
            txtCity.TabIndex = 5;
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(67, 242);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(119, 20);
            lbCompanyName.TabIndex = 0;
            lbCompanyName.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(203, 239);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(299, 27);
            txtCompanyName.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(247, 303);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(408, 303);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.AutoSize = true;
            btnViewOrder.Location = new Point(67, 303);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(126, 30);
            btnViewOrder.TabIndex = 7;
            btnViewOrder.Text = "Member's Order";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(137, 76);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email:";
            // 
            // frmMembersInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 388);
            Controls.Add(btnViewOrder);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbCompanyName);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Name = "frmMembersInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members Information";
            Load += frmMembersInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCountry;
        private TextBox txtCountry;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCompanyName;
        private TextBox txtCompanyName;
        private Button btnSave;
        private Button btnClose;
        private Button btnViewOrder;
        private Label lbEmail;
    }
}