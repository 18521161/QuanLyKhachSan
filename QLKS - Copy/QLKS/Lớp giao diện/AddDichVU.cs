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
    public partial class AddDichVU : Form
    {
        Phong Phong;
        public AddDichVU(Phong phong)
        {
            InitializeComponent();
            Phong = phong;
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

        private void DTGV_DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DTGV_DV.CurrentRow.Index;
            DialogResult result = MessageBox.Show("Bạn có muốn thêm dịch vụ này", "", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                CungCapDuLieu.Instance.ExcuteQuery("insert into Bill values('"+Phong.ID+"',N'"+DTGV_DV.Rows[i].Cells[1].Value+ "','1','"+DTGV_DV.Rows[i].Cells[2].Value+ "','" + DTGV_DV.Rows[i].Cells[2].Value + "')");
            }
        }
    }
}
