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
    class DuLieuKhachHang
    {
        private static DuLieuKhachHang instance;
        public static DuLieuKhachHang Instance
        {
            get { if (instance == null) instance = new DuLieuKhachHang(); return DuLieuKhachHang.instance; }
            private set { DuLieuKhachHang.instance = value; }
        }
        public KhachHang GetKhachHangByID(int ID)
        {
            DataTable data = CungCapDuLieu.Instance.ExcuteQuery(" SELECT * FROM KhachHang WHERE ID='" + ID + "'");
            foreach (DataRow item in data.Rows)
            {
                return new KhachHang(item);
            }
            return null;
        }


    }
}
