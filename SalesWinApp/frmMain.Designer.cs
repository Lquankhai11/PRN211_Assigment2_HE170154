namespace SalesWinApp
{
    partial class frmMain
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
            lbWelcome1 = new Label();
            lbName = new Label();
            lbWelcome2 = new Label();
            btnMembersManagement = new Button();
            btnProductManagement = new Button();
            btnOrderManagement = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // lbWelcome1
            // 
            lbWelcome1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbWelcome1.ForeColor = SystemColors.Highlight;
            lbWelcome1.Location = new Point(285, 9);
            lbWelcome1.Name = "lbWelcome1";
            lbWelcome1.Size = new Size(208, 55);
            lbWelcome1.TabIndex = 0;
            lbWelcome1.Text = "Welcome";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = SystemColors.Highlight;
            lbName.Location = new Point(285, 78);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 46);
            lbName.TabIndex = 0;
            lbName.Text = "?";
            // 
            // lbWelcome2
            // 
            lbWelcome2.AutoSize = true;
            lbWelcome2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbWelcome2.ForeColor = SystemColors.Highlight;
            lbWelcome2.Location = new Point(274, 144);
            lbWelcome2.Name = "lbWelcome2";
            lbWelcome2.Size = new Size(219, 46);
            lbWelcome2.TabIndex = 0;
            lbWelcome2.Text = "to FStore";
            // 
            // btnMembersManagement
            // 
            btnMembersManagement.AutoSize = true;
            btnMembersManagement.Location = new Point(48, 233);
            btnMembersManagement.Name = "btnMembersManagement";
            btnMembersManagement.Size = new Size(167, 30);
            btnMembersManagement.TabIndex = 1;
            btnMembersManagement.Text = "Member Management";
            btnMembersManagement.UseVisualStyleBackColor = true;
            btnMembersManagement.Click += btnMembersManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.AutoSize = true;
            btnProductManagement.Location = new Point(303, 233);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(162, 30);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.AutoSize = true;
            btnOrderManagement.Location = new Point(558, 233);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(149, 30);
            btnOrderManagement.TabIndex = 1;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = true;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(335, 298);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 362);
            Controls.Add(btnLogOut);
            Controls.Add(btnOrderManagement);
            Controls.Add(btnProductManagement);
            Controls.Add(btnMembersManagement);
            Controls.Add(lbWelcome2);
            Controls.Add(lbName);
            Controls.Add(lbWelcome1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWelcome1;
        private Label lbName;
        private Label lbWelcome2;
        private Button btnMembersManagement;
        private Button btnProductManagement;
        private Button btnOrderManagement;
        private Button btnLogOut;
    }
}