namespace SalesWinApp
{
    partial class frmMembersOrder
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
            lbOrderList = new Label();
            lbOrderDetail = new Label();
            dgvOrderList = new DataGridView();
            dgvOrderDetail = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // lbOrderList
            // 
            lbOrderList.AutoSize = true;
            lbOrderList.Location = new Point(180, 9);
            lbOrderList.Name = "lbOrderList";
            lbOrderList.Size = new Size(136, 20);
            lbOrderList.TabIndex = 0;
            lbOrderList.Text = "All member's order";
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Location = new Point(728, 9);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(98, 20);
            lbOrderDetail.TabIndex = 0;
            lbOrderDetail.Text = "Order's detail";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(12, 32);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(511, 465);
            dgvOrderList.TabIndex = 1;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(529, 32);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new Size(511, 400);
            dgvOrderDetail.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(728, 450);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMembersOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 509);
            Controls.Add(btnClose);
            Controls.Add(dgvOrderDetail);
            Controls.Add(dgvOrderList);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrderList);
            Name = "frmMembersOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member's Order";
            Load += frmMembersOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderList;
        private Label lbOrderDetail;
        private DataGridView dgvOrderList;
        private DataGridView dgvOrderDetail;
        private Button btnClose;
    }
}