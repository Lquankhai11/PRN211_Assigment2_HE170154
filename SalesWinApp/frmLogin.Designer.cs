namespace SalesWinApp
{
    partial class frmLogin
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
            lbLogin = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.ForeColor = SystemColors.Highlight;
            lbLogin.Location = new Point(188, 28);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(138, 26);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login here";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.ForeColor = SystemColors.Highlight;
            lbEmail.Location = new Point(91, 95);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = SystemColors.Highlight;
            lbPassword.Location = new Point(67, 144);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "admin@fstore.com";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 141);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "admin@@";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(91, 206);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(305, 206);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 273);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClose;
    }
}