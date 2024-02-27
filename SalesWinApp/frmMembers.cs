using BusinessObject;
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
    public partial class frmMembers : Form
    {
        public IMemberRepository MemberRepository = new MemberRepository();
        BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
        }
        private void ClearText()
        {
            txtMemberID.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtCompanyName.Text = "";
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMember.CellDoubleClick += DvgUserList_CellDoubleClick;
        }
        private void DvgUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMembersControl member = new frmMembersControl
            {
                Text = "Update User",
                InsertOrUpdate = true,
                UserProfile = GetUser(),
                MemberRepository = MemberRepository,
            };
            if (member.ShowDialog() == DialogResult.Cancel)
            {
                LoadUsers();
                source.Position = source.Count - 1;
            }
        }
        private void dgvMember_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
        public void LoadUsers()
        {
            var users = MemberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = users;

                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;

                if (users.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading users failed");
            }
        }
        private MemberObject GetUser()
        {
            MemberObject user = null;
            try
            {
                user = new MemberObject
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    CompanyName = txtCompanyName.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Getting user Faied");
            }
            return user;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMembersControl member = new frmMembersControl
            {
                InsertOrUpdate = false,
                Text = "Create User",
                MemberRepository = MemberRepository,
            };
            if (member.ShowDialog() == DialogResult.Cancel)
            {
                LoadUsers();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMembersControl member = new frmMembersControl
            {
                Text = "Update User",
                InsertOrUpdate = true,
                UserProfile = GetUser(),
                MemberRepository = MemberRepository,
            };
            if (member.ShowDialog() == DialogResult.Cancel)
            {
                LoadUsers();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetUser();
                DialogResult isDeleted = MessageBox.Show("Do you really want to delete?", "Deleting", MessageBoxButtons.YesNo);
                if (isDeleted == DialogResult.Yes)
                {
                    MemberRepository.DeleteMember(user.MemberId);
                    MessageBox.Show("Delete user successfully");
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleting user failed");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
