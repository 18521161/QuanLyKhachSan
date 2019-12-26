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
    public partial class AddPhong : Form
    {
        Account login;
        KhachSan KS;
        public AddPhong(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Check("Phong",TB_IDPhong.Text)==true)
            {
                MessageBox.Show("ID đã tồn tại");
            }
            else
            {
                if (CB_LoaiPhong.Text == "Phòng đơn")
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO Phong VALUES('" + TB_IDPhong.Text + "',N'" + TB_TenPhong.Text + "',N'Trống','" + this.KS.ID + "','1','" + TB_Tang.Text + "','1',null,null,'1','1')");
                else if (CB_LoaiPhong.Text == "Phòng đôi 1 giường")
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO Phong VALUES('" + TB_IDPhong.Text + "',N'" + TB_TenPhong.Text + "',N'Trống','" + this.KS.ID + "','2','" + TB_Tang.Text + "','1',null,null,'1','1')");
                else if (CB_LoaiPhong.Text == "Phòng đôi 2 giường")
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO Phong VALUES('" + TB_IDPhong.Text + "',N'" + TB_TenPhong.Text + "',N'Trống','" + this.KS.ID + "','3','" + TB_Tang.Text + "','1',null,null,'1','1')");
                else
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO Phong VALUES('" + TB_IDPhong.Text + "',N'" + TB_TenPhong.Text + "',N'Trống','" + this.KS.ID + "','4','" + TB_Tang.Text + "','1',null,null,'1','1')");
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
