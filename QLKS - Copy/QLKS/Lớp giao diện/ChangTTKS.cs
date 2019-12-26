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
    public partial class ChangTTKS : Form
    {
        Account login;
        KhachSan KS;
        public ChangTTKS(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            this.KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            CungCapDuLieu.Instance.Update("update ThongTinKhachSan set [Tên khách sạn]='" + TB_Ten.Text + "',[Địa chỉ khách sạn]='"+TB_DC.Text+ "',[Số điện thoại khách sạn] ='"+TB_SDT.Text+"',Email='"+TB_Email.Text+"' where ID='" + this.KS.ID + "'");
            MessageBox.Show("Cập nhật thông tin thành công");
            this.Hide();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
