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
using QLKS.Lớp_truy_cập_dữ_liệu;

namespace QLKS
{
    public partial class ChangeTTChuKS : Form
    {
        Account login;
        public ChangeTTChuKS(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            TB_tenKS.Text = this.login.Ten;
            TB_USN.Text = this.login.Username;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TB_OldPW.Text != this.login.Password)
            {
                MessageBox.Show("Mật khẩu cũ sai");
            }
            else
            {
                if (TB_Check.Text == TB_NewPW.Text)
                {
                    CungCapDuLieu.Instance.Update("update ThongTinTaiKhoan set [Mật khẩu]='" + TB_NewPW.Text + "' where ID='" + this.login.ID + "'");
                    MessageBox.Show("Cập nhật thông tin thành công");
                    this.Hide();
                }
                else
                    MessageBox.Show("Mật khẩu phải trùng nhau");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
