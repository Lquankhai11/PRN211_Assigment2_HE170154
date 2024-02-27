namespace SalesWinApp
{
    partial class frmOrder
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
            lbOrderID = new Label();
            txtOrderID = new TextBox();
            lbMemberID = new Label();
            txtMemberID = new TextBox();
            lbFreight = new Label();
            txtFreight = new TextBox();
            lbOrderDate = new Label();
            lbRequiredDate = new Label();
            lbShippedDate = new Label();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(34, 15);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(69, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(109, 12);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(215, 27);
            txtOrderID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(16, 55);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(87, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(109, 52);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(215, 27);
            txtMemberID.TabIndex = 2;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(45, 95);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(58, 20);
            lbFreight.TabIndex = 0;
            lbFreight.Text = "Freight:";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(109, 92);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(215, 27);
            txtFreight.TabIndex = 3;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(404, 15);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(86, 20);
            lbOrderDate.TabIndex = 0;
            lbOrderDate.Text = "Order Date:";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(382, 55);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(108, 20);
            lbRequiredDate.TabIndex = 0;
            lbRequiredDate.Text = "Required Date:";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(387, 95);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(103, 20);
            lbShippedDate.TabIndex = 0;
            lbShippedDate.Text = "Shipped Date:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(496, 12);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 4;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(496, 52);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(250, 27);
            dtpRequiredDate.TabIndex = 5;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(496, 92);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(250, 27);
            dtpShippedDate.TabIndex = 6;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(25, 151);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(350, 151);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(652, 151);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(350, 539);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 199);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(776, 334);
            dgvOrder.TabIndex = 11;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(dgvOrder);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbShippedDate);
            Controls.Add(lbFreight);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderID;
        private TextBox txtOrderID;
        private Label lbMemberID;
        private TextBox txtMemberID;
        private Label lbFreight;
        private TextBox txtFreight;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvOrder;
    }
}