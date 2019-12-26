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

namespace QLKS.Lớp_truy_cập_dữ_liệu
{
    class DuLieuTaiKhoang
    {
        private static DuLieuTaiKhoang instance;
        public static DuLieuTaiKhoang Instance
        {
            get { if (instance == null) instance = new DuLieuTaiKhoang(); return DuLieuTaiKhoang.instance; }
            private set { DuLieuTaiKhoang.instance = value; }
        }
        public bool Check_login(string username,string password)
        {
            string query = "SELECT * FROM ThongTinTaiKhoan WHERE [Tên đăng nhập]='"+username+ "'and [Mật khẩu]='"+password+"' ";
            DataTable dt_kiemtra = new DataTable();
            dt_kiemtra = CungCapDuLieu.Instance.ExcuteQuery(query);
            if (dt_kiemtra.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public Account GetAccountByUserName(string username)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM ThongTinTaiKhoan WHERE [Tên đăng nhập]='" + username + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
