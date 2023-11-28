using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon huy dang nhap? ", "Thong bao", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassWord.Text == "")
            {
                labelThongBaoLogin.Text = "Vui lòng nhập đủ thông tin !";
                labelThongBaoLogin.Visible = true;
            }
            else if(txtUserName.Text == "Admin" && txtPassWord.Text == "UTC@123")
            {
                this.Hide();
                FormTrangChu trangchu= new FormTrangChu();
                trangchu.ShowDialog();
                this.Close();
            }
            else labelThongBaoLogin.Text = "Tài khoản hoặc mật khẩu chưa đúng !";
            labelThongBaoLogin.Visible = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Admin";
            txtPassWord.Text = "UTC@123";
        }

        
    }
}
