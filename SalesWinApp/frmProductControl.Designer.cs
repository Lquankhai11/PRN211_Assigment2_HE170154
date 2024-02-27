namespace SalesWinApp
{
    partial class frmProductControl
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
            txtProductID = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            lbCategoryID = new Label();
            txtCategoryID = new TextBox();
            lbWeight = new Label();
            txtWeight = new TextBox();
            lbUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lbUnitsInStock = new Label();
            txtUnitsInStock = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(35, 15);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(82, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(123, 12);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(288, 27);
            txtProductID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 0;
            label2.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(123, 56);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(288, 27);
            txtProductName.TabIndex = 2;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(29, 102);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(91, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(123, 99);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(288, 27);
            txtCategoryID.TabIndex = 3;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(57, 142);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(59, 20);
            lbWeight.TabIndex = 0;
            lbWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(123, 139);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(288, 27);
            txtWeight.TabIndex = 4;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(41, 184);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(75, 20);
            lbUnitPrice.TabIndex = 0;
            lbUnitPrice.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(123, 181);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(288, 27);
            txtUnitPrice.TabIndex = 5;
            // 
            // lbUnitInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(29, 232);
            lbUnitsInStock.Name = "lbUnitInStock";
            lbUnitsInStock.Size = new Size(87, 20);
            lbUnitsInStock.TabIndex = 0;
            lbUnitsInStock.Text = "UnitsInStock:";
            // 
            // txtUnitInStock
            // 
            txtUnitsInStock.Location = new Point(123, 225);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(288, 27);
            txtUnitsInStock.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(123, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(317, 277);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProductControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 324);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryID);
            Controls.Add(label2);
            Controls.Add(lbProductID);
            Name = "frmProductControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductControl";
            Load += frmProductControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductID;
        private TextBox txtProductID;
        private Label label2;
        private TextBox txtProductName;
        private Label lbCategoryID;
        private TextBox txtCategoryID;
        private Label lbWeight;
        private TextBox txtWeight;
        private Label lbUnitPrice;
        private TextBox txtUnitPrice;
        private Label lbUnitsInStock;
        private TextBox txtUnitsInStock;
        private Button btnSave;
        private Button btnClose;
    }
}