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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void Label22_Click(object sender, EventArgs e)
        {
            if(Check("ThongTinTaiKhoan",TB_IDCKS.Text)==true)
            {
                MessageBox.Show("ID tài khoảng đã tồn tại");
            }
            else
            {
                if(Check("ThongTinKhachSan",TB_IDKS.Text)==true)
                {
                    MessageBox.Show("ID khách sạn đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Đăng kí thành công");
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO ThongTinTaiKhoan VALUES ('" + TB_IDCKS.Text + "','" + TB_TK.Text + "','" + TB_MK.Text + "','" + TB_TenCKS.Text + "','" + TB_DCCKS.Text + "','" + TB_SDTCKS.Text + "')");
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO ThongTinKhachSan VALUES ('" + TB_IDKS.Text + "','" + TB_TenKS.Text + "','" + TB_DCKS.Text + "','" + TB_SDTKS.Text + "','" + TB_IDCKS.Text + "','" + TB_Email.Text + "')");
                    this.Hide();
                }
            }
        }

        private void Panel14_Click(object sender, EventArgs e)
        {
            if (Check("ThongTinTaiKhoang", TB_IDCKS.Text) == true)
            {
                MessageBox.Show("ID tài khoảng đã tồn tại");
            }
            else
            {
                if (Check("ThongTinKhachSan", TB_IDKS.Text) == true)
                {
                    MessageBox.Show("ID khách sạn đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Đăng kí thành công");
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO ThongTinTaiKhoan VALUES ('" + TB_IDCKS.Text + "','" + TB_TK.Text + "','" + TB_MK.Text + "','" + TB_TenCKS.Text + "','" + TB_DCCKS.Text + "','" + TB_SDTCKS.Text + "')");
                    CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO ThongTinKhachSan VALUES ('" + TB_IDKS.Text + "','" + TB_TenKS.Text + "','" + TB_DCKS.Text + "','" + TB_SDTKS.Text + "','" + TB_IDCKS.Text + "','" + TB_Email.Text + "')");
                    this.Hide();
                }
            }
        }
        public bool Check(string Ten_Bang,string Dulieu)
        {
            DataTable dt_kiemtra = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM "+Ten_Bang+" WHERE ID='"+Dulieu+"'");
            if (dt_kiemtra.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
