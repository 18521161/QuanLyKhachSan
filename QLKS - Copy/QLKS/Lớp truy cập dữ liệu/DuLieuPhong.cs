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
    class DuLieuPhong
    {
        private static DuLieuPhong instance;

        internal static DuLieuPhong Instance
        {
            get { if (instance == null) instance = new DuLieuPhong();return DuLieuPhong.instance; }
            private set => instance = value;
        }
        private DuLieuPhong() { }
        public List<Phong> LoadPhongList(int iDKhachSan)
        {
            List<Phong> Phong_List = new List<Phong>();
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM Phong WHERE [ID khách sạn]='" + iDKhachSan + "'");
            foreach(DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                Phong_List.Add(phong);
            }
            return Phong_List;
        }
        public Phong GetPhongByIDPhong(int IDphong)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM Phong WHERE ID='" + IDphong + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Phong(item);
            }
            return null;
        }
        public List<Phong> LoadPhongListbyIDLoaiPhong(int iDKhachSan,int IDLoaiPhong)
        {
            List<Phong> Phong_List = new List<Phong>();
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM Phong WHERE [ID khách sạn]='" + iDKhachSan + "' AND [ID loại phòng]='" + IDLoaiPhong+"'");
            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                Phong_List.Add(phong);
            }
            return Phong_List;
        }
        public List<Phong> LoadPhongListbyIDTang(int iDKhachSan, int IDTang)
        {
            List<Phong> Phong_List = new List<Phong>();
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM Phong WHERE [ID khách sạn]='" + iDKhachSan + "' AND [ID tầng]='" + IDTang + "'");
            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                Phong_List.Add(phong);
            }
            return Phong_List;
        }

    }
}
