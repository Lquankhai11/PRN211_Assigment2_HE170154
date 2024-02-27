using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string _adminName;
        public string adminName
        {
            get { return _adminName; }
            set { _adminName = value; }
        }
        //Load tên người đăng nhập
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_adminName != null)
            {
                lbName.Text = _adminName;
            }
        }
        //Log out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Chuyển trang Member Managment
        private void btnMembersManagement_Click(object sender, EventArgs e)
        {
            frmMembers frmmenber = new frmMembers();
            this.Hide();
            frmmenber.ShowDialog();
            this.Show();
        }
        //Chuyển trang Product Managment
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProducts frmproduct = new frmProducts();
            this.Hide();
            frmproduct.ShowDialog();
            this.Show();
        }
        //Chuyển trang Order Managment
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrder frmorder = new frmOrder();
            this.Hide();
            frmorder.ShowDialog();
            this.Show();
        }
    }
}
