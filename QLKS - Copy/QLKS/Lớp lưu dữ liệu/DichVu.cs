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

namespace QLKS.Lớp_lưu_dữ_liệu
{
    class DichVu
    {
        public DichVu(int id,string ten,int gia,string nhomDichVu)
        {
            this.iD = id;
            this.ten = ten;
            this.gia = gia;
            this.nhomDichVu = nhomDichVu;
        }
        public DichVu(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.ten = row["Tên dịch vụ"].ToString();
            this.gia = (int)row["Giá dịch vụ"];
            this.nhomDichVu = row["Group dịch vụ"].ToString();
        }
        private int iD;
        private string ten;
        private int gia;
        private string nhomDichVu;

        public int ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public string NhomDichVu { get => nhomDichVu; set => nhomDichVu = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
