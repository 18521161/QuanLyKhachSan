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
using QLKS.Lớp_truy_cập_dữ_liệu;
using QLKS.Lớp_lưu_dữ_liệu;

namespace QLKS
{
    public partial class ShowDanhSachDichVu : UserControl
    {
        Account login;
        public ShowDanhSachDichVu(Account acc)
        {
            InitializeComponent();
            this.login = acc;
        }
        private void BT_MNB_Click(object sender, EventArgs e)
        {
            load(BT_MNB.Text);
        }

        private void BT_GL_Click(object sender, EventArgs e)
        {
            load(BT_GL.Text);
        }

        private void BT_DVK_Click(object sender, EventArgs e)
        {
            load(BT_DVK.Text);
        }
        private void load(string NhomDichVu)
        {
            DTGV_DV.DataSource = CungCapDuLieu.Instance.ExcuteQuery("select ID,[Tên dịch vụ],[Giá dịch vụ] from LoaiDichVu where [Group dịch vụ]=N'" + NhomDichVu + "'");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ThemDichVu add = new ThemDichVu();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }
    }
}
