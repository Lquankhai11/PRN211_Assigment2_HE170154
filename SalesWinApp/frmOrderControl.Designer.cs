namespace SalesWinApp
{
    partial class frmOrderControl
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
            lbFreight = new Label();
            txtFreight = new TextBox();
            lbOrderDate = new Label();
            lbRequiredDate = new Label();
            lbShippedDate = new Label();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            dgvOrderControl = new DataGridView();
            btnCreate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            cboMemberID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).BeginInit();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(41, 24);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(69, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID:";
            lbOrderID.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(116, 21);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(205, 27);
            txtOrderID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(23, 67);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(87, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID:";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(52, 110);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(58, 20);
            lbFreight.TabIndex = 0;
            lbFreight.Text = "Freight:";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(116, 107);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(205, 27);
            txtFreight.TabIndex = 3;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(446, 21);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(86, 20);
            lbOrderDate.TabIndex = 0;
            lbOrderDate.Text = "Order Date:";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(424, 67);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(108, 20);
            lbRequiredDate.TabIndex = 0;
            lbRequiredDate.Text = "Required Date:";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(429, 110);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(103, 20);
            lbShippedDate.TabIndex = 0;
            lbShippedDate.Text = "Shipped Date:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(538, 19);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 4;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(538, 62);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(250, 27);
            dtpRequiredDate.TabIndex = 5;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(538, 105);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(250, 27);
            dtpShippedDate.TabIndex = 6;
            // 
            // dgvOrderControl
            // 
            dgvOrderControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderControl.Location = new Point(12, 196);
            dgvOrderControl.Name = "dgvOrderControl";
            dgvOrderControl.RowHeadersWidth = 51;
            dgvOrderControl.RowTemplate.Height = 29;
            dgvOrderControl.Size = new Size(776, 328);
            dgvOrderControl.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 148);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(344, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 148);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(344, 531);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cboMemberID
            // 
            cboMemberID.FormattingEnabled = true;
            cboMemberID.Location = new Point(116, 64);
            cboMemberID.Name = "cboMemberID";
            cboMemberID.Size = new Size(205, 28);
            cboMemberID.TabIndex = 2;
            // 
            // frmOrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(cboMemberID);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(dgvOrderControl);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtFreight);
            Controls.Add(txtOrderID);
            Controls.Add(lbShippedDate);
            Controls.Add(lbFreight);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Name = "frmOrderControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrderControl";
            Load += frmOrderControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderID;
        private TextBox txtOrderID;
        private Label lbMemberID;
        private Label lbFreight;
        private TextBox txtFreight;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private DataGridView dgvOrderControl;
        private Button btnCreate;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private ComboBox cboMemberID;
    }
}