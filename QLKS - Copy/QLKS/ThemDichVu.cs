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
    public partial class ThemDichVu : Form
    {
        public ThemDichVu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO LoaiDichVu VALUES ('"+TB_ID.Text+"','"+TB_TenDV.Text+"','"+TB_Tien.Text+"','"+CB_Loai.Text+"')");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
