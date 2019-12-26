using System;
using System.Collections.Generic;
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
    public partial class AddNhanVien : Form
    {
        Account login;
        KhachSan KS;
        public AddNhanVien(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Check("NhanVien",TB_IDNV.Text)==true)
            {
                MessageBox.Show("ID đã tồn tại");
            }
            else
            {
                CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO NhanVien VALUES('" + TB_IDNV.Text + "',N'" + TB_TenNhanVien.Text + "','" + TB_SDT.Text + "',N'" + CB_ChucVu.Text + "','" + this.KS.ID + "')");
                MessageBox.Show("Thêm thành công");
                this.Hide();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public bool Check(string Ten_Bang, string Dulieu)
        {
            DataTable dt_kiemtra = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM " + Ten_Bang + " WHERE ID='" + Dulieu + "'");
            if (dt_kiemtra.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
