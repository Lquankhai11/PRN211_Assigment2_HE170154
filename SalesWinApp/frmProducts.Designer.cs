namespace SalesWinApp
{
    partial class frmProducts
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
            lbProductName = new Label();
            txtProductName = new TextBox();
            lbCategoryID = new Label();
            txtCategoryID = new TextBox();
            lbWeight = new Label();
            txtWeight = new TextBox();
            lbPrice = new Label();
            txtPrice = new TextBox();
            lbUnitsInStock = new Label();
            txtUnitsInStock = new TextBox();
            lbSearch = new Label();
            txtSearch = new TextBox();
            lbSearchT = new Label();
            cbTypeSearch = new ComboBox();
            btnSearch = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(37, 23);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(82, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(125, 20);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(232, 27);
            txtProductID.TabIndex = 1;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(12, 64);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(107, 20);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(125, 61);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(232, 27);
            txtProductName.TabIndex = 2;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(28, 102);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(91, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(125, 99);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(232, 27);
            txtCategoryID.TabIndex = 3;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(553, 23);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(59, 20);
            lbWeight.TabIndex = 0;
            lbWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(623, 20);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(232, 27);
            txtWeight.TabIndex = 4;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(568, 64);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(44, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(623, 61);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(232, 27);
            txtPrice.TabIndex = 5;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(524, 102);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(87, 20);
            lbUnitsInStock.TabIndex = 0;
            lbUnitsInStock.Text = "UnitsInStock:";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(623, 99);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(232, 27);
            txtUnitsInStock.TabIndex = 6;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(77, 170);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(28, 20);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "By:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(403, 167);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 27);
            txtSearch.TabIndex = 8;
            // 
            // lbSearchT
            // 
            lbSearchT.AutoSize = true;
            lbSearchT.Location = new Point(341, 170);
            lbSearchT.Name = "lbSearchT";
            lbSearchT.Size = new Size(56, 20);
            lbSearchT.TabIndex = 0;
            lbSearchT.Text = "Search:";
            // 
            // cbTypeSearch
            // 
            cbTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeSearch.FormattingEnabled = true;
            cbTypeSearch.Location = new Point(111, 167);
            cbTypeSearch.Name = "cbTypeSearch";
            cbTypeSearch.Size = new Size(175, 28);
            cbTypeSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(649, 165);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(25, 223);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(270, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(518, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(745, 223);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(442, 599);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 258);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(843, 335);
            dgvProducts.TabIndex = 4;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 640);
            Controls.Add(dgvProducts);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(cbTypeSearch);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtSearch);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbSearchT);
            Controls.Add(lbSearch);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductName);
            Controls.Add(lbProductID);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductID;
        private TextBox txtProductID;
        private Label lbProductName;
        private TextBox txtProductName;
        private Label lbCategoryID;
        private TextBox txtCategoryID;
        private Label lbWeight;
        private TextBox txtWeight;
        private Label lbPrice;
        private TextBox txtPrice;
        private Label lbUnitsInStock;
        private TextBox txtUnitsInStock;
        private Label lbSearch;
        private TextBox txtSearch;
        private Label lbSearchT;
        private ComboBox cbTypeSearch;
        private Button btnSearch;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvProducts;
    }
}