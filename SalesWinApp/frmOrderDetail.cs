﻿using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public List<ProductObject> ListProduct { get; set; }
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                cboProductID.Text = ProductID.ToString();
                txtDiscount.Text = Discount.ToString();
                nmQuantity.Text = Quantity.ToString();
            }
            else
            {
                ListProduct.ForEach(product => cboProductID.Items.Add(product.ProductId));
                cboProductID.DropDownStyle = ComboBoxStyle.DropDownList;
                cboProductID.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate == false)
                {
                    var orderDetail = new OrderDetailObject()
                    {
                        OrderId = OrderID,
                        ProductId = ListProduct.ElementAt(cboProductID.SelectedIndex).ProductId,
                        Quantity = int.Parse(nmQuantity.Text),
                        Discount = double.Parse(txtDiscount.Text),
                        UnitPrice = ListProduct.ElementAt(cboProductID.SelectedIndex).UnitPrice,
                    };
                    OrderDetailRepository.InsertOrderDetail(orderDetail);
                    MessageBox.Show("Add new order detail successfully");
                    Close();
                }
                else
                {
                    int index = ListProduct.FindIndex(product => product.ProductId == int.Parse(cboProductID.Text));
                    var orderDetail = new OrderDetailObject()
                    {
                        OrderId = OrderID,
                        ProductId = ListProduct.ElementAt(index).ProductId,
                        Quantity = int.Parse(nmQuantity.Text),
                        Discount = double.Parse(txtDiscount.Text),
                        UnitPrice = ListProduct.ElementAt(index).UnitPrice,
                    };
                    OrderDetailRepository.UpdateOrderDetail(orderDetail);
                    MessageBox.Show("Update order detail successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Adding orderDetail failed" : "Updating orderDetail failed");
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
