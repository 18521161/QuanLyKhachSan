using QLKS.Lớp_truy_cập_dữ_liệu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using QLKS.Lớp_lưu_dữ_liệu;

namespace QLKS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
bool Check_Login(string username, string password)
{
     return DuLieuTaiKhoang.Instance.Check_login(username, password);
}

private void BT_Exit_Click(object sender, EventArgs e)
{
    Application.Exit();
}

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            string username = TB_UserName.Text;
            string password = TB_PassWord.Text;
            if (Check_Login(username, password))
            {
                Account login = DuLieuTaiKhoang.Instance.GetAccountByUserName(username);
                TableManager TB_MNG = new TableManager(login);
                this.Hide();
                TB_MNG.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoảng hoặc mật khẩu!");
            }

        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            string username = TB_UserName.Text;
            string password = TB_PassWord.Text;
            if (Check_Login(username, password))
            {
                Account login = DuLieuTaiKhoang.Instance.GetAccountByUserName(username);
                TableManager TB_MNG = new TableManager(login);
                this.Hide();
                TB_MNG.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoảng hoặc mật khẩu!");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            DangKi DK = new DangKi();
            this.Hide();
            DK.ShowDialog();
            this.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
