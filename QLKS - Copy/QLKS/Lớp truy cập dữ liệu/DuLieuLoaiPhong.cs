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
    class DuLieuLoaiPhong
    {
        private static DuLieuLoaiPhong instance;

        internal static DuLieuLoaiPhong Instance
        {
            get { if (instance == null) instance = new DuLieuLoaiPhong(); return DuLieuLoaiPhong.instance; }
            private set => instance = value;
        }
        private DuLieuLoaiPhong() { }
        public List<LoaiPhong> LoadLoaiPhongList(int iDKhachSan)
        {
            List<LoaiPhong> LoaiPhong_List = new List<LoaiPhong>();
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM LoaiPhong ");
            foreach (DataRow item in data.Rows)
            {
                LoaiPhong loaiPhong = new LoaiPhong(item);
                LoaiPhong_List.Add(loaiPhong);
            }
            return LoaiPhong_List;
        }
        public LoaiPhong GetLoaiPhongByPhongID(int IDLoaiPhong)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM LoaiPhong WHERE ID='" + IDLoaiPhong + "'");
            foreach (DataRow item in data.Rows)
            {
                return new LoaiPhong(item);
            }
            return null;
        }
    }
}
