using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Lớp_truy_cập_dữ_liệu
{
    public class DuLieuTaiKhoang
    {
        private static DuLieuTaiKhoang instance;
        public static DuLieuTaiKhoang Instance
        {
            get { if (instance == null) instance = new DuLieuTaiKhoang();return instance; }
            set => instance = value;
        }
        private DuLieuTaiKhoang() {  }
        public bool Check_login(string username,string password)
        {
            string query = "Select * from ThongTinTaiKhoang where [Tên đăng nhập]='" + username + "'AND [Mật khẩu]='"+password+"'";
            DataTable Check_table = new DataTable();
            Check_table = CungCapDuLieu.Instance.ExcuteQuery(query);
            if(Check_table.Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        
    }
}
