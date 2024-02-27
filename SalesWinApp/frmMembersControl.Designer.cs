namespace SalesWinApp
{
    partial class frmMembersControl
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
            label1 = new Label();
            txtMemberID = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtCompanyName = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 24);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(172, 21);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(244, 27);
            txtMemberID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 101);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(172, 98);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 142);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(172, 139);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(244, 27);
            txtCountry.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 181);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 0;
            label5.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(172, 178);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(244, 27);
            txtCity.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 221);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 0;
            label6.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(172, 218);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(244, 27);
            txtCompanyName.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(172, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(322, 277);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMembersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 347);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMembersControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMembersControl";
            Load += frmMembersControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMemberID;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtCountry;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtCompanyName;
        private Button btnSave;
        private Button btnClose;
    }
}