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

namespace QLKS.Lớp_lưu_dữ_liệu
{
    class KhachHang
    {
        public KhachHang(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.Ten = row["Họ tên"].ToString();
            this.SDT = row["Số điện thoại"].ToString();
            this.CMND = row["CMND"].ToString();
        }

        public KhachHang() { }
        private int iD;
        private string Ten;
        private string CMND;
        private string SDT;

        public int ID { get => iD; set => iD = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }

}
