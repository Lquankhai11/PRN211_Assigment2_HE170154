namespace SalesWinApp
{
    partial class frmOrderDetail
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
            lbProductID = new Label();
            lbDiscount = new Label();
            lbQuantity = new Label();
            cboProductID = new ComboBox();
            txtDiscount = new TextBox();
            nmQuantity = new NumericUpDown();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(33, 36);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(78, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "ProductID:";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(33, 83);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(70, 20);
            lbDiscount.TabIndex = 0;
            lbDiscount.Text = "Discount:";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(33, 130);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(68, 20);
            lbQuantity.TabIndex = 0;
            lbQuantity.Text = "Quantity:";
            // 
            // cboProductID
            // 
            cboProductID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductID.FormattingEnabled = true;
            cboProductID.Location = new Point(132, 33);
            cboProductID.Name = "cboProductID";
            cboProductID.Size = new Size(194, 28);
            cboProductID.TabIndex = 1;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(132, 80);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(194, 27);
            txtDiscount.TabIndex = 2;
            // 
            // nmQuantity
            // 
            nmQuantity.Location = new Point(132, 128);
            nmQuantity.Name = "nmQuantity";
            nmQuantity.Size = new Size(194, 27);
            nmQuantity.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(33, 197);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(232, 197);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 252);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(nmQuantity);
            Controls.Add(txtDiscount);
            Controls.Add(cboProductID);
            Controls.Add(lbQuantity);
            Controls.Add(lbDiscount);
            Controls.Add(lbProductID);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)nmQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductID;
        private Label lbDiscount;
        private Label lbQuantity;
        private ComboBox cboProductID;
        private TextBox txtDiscount;
        private NumericUpDown nmQuantity;
        private Button btnSave;
        private Button btnClose;
    }
}