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
    class DuLieuDichVu
    {
        private static DuLieuDichVu instance;
        internal static DuLieuDichVu Instance
        {
            get { if (instance == null) instance = new DuLieuDichVu(); return DuLieuDichVu.instance; }
            private set => instance = value;
        }
        private DuLieuDichVu() { }
        public List<DichVu> LoadDichVuList(string NhomDichVu)
        {
            List<DichVu> DichVu_List = new List<DichVu>();
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM LoaiDichVu WHERE [Group dịch vụ]=N'" + NhomDichVu + "'");
            foreach (DataRow item in data.Rows)
            {
                DichVu dichvu = new DichVu(item);
                DichVu_List.Add(dichvu);
            }
            return DichVu_List;
        }
    }
}
