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
    class DuLieuKhachSan
    {
        private static DuLieuKhachSan instance;
        public static DuLieuKhachSan Instance
        {
            get { if (instance == null) instance = new DuLieuKhachSan(); return DuLieuKhachSan.instance; }
            private set { DuLieuKhachSan.instance = value; }
        }
        public KhachSan GetKhachSanByIDBoss(int IDChuKhachSan)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM ThongTinKhachSan WHERE [ID chủ khách sạn]='" + IDChuKhachSan + "'");
            foreach (DataRow item in data.Rows)
            {
                return new KhachSan(item);
            }
            return null;
        }
        public KhachSan GetKhachSanByID(int IDKhachSan)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM ThongTinKhachSan WHERE ID='" + IDKhachSan + "'");
            foreach (DataRow item in data.Rows)
            {
                return new KhachSan(item);
            }
            return null;
        }

    }
}
