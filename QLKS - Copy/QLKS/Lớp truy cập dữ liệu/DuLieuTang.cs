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
    class DuLieuTang
    {
        private static DuLieuTang instance;
        internal static DuLieuTang Instance
        {
            get { if (instance == null) instance = new DuLieuTang(); return DuLieuTang.instance; }
            private set => instance = value;
        }
        private DuLieuTang() { }
        public List<Tang> LoadLoaiPhongList(int iDKhachSan)
        {
            List<Tang> Tang_List = new List<Tang>();
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM Tang WHERE [ID khách sạn]='" + iDKhachSan + "'");
            foreach (DataRow item in data.Rows)
            {
                Tang tang = new Tang(item);
                Tang_List.Add(tang);
            }
            return Tang_List;
        }
        public Tang LoadTang(int iDTang)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM Tang WHERE ID='" + iDTang + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Tang(item);
            }
            return null;
        }

    }
}
