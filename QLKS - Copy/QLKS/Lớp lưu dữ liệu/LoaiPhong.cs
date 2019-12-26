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
    class LoaiPhong
    {
        public LoaiPhong(int iD, string ten, int SLN,int GiaPhong,int iDKhachSan)
        {
            this.iD = iD;
            this.ten = ten;
            this.SLN = SLN;
            this.GiaPhong = GiaPhong;
            this.iDKhachSan = iDKhachSan;
        }
        public LoaiPhong(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.ten = row["Tên loại phòng"].ToString();
            this.SLN = (int)row["Số lượng người ở"];
            this.GiaPhong = (int)row["Giá phòng"];
            this.iDKhachSan = (int)row["ID khách sạn"];
        }
        private int iD;
        private string ten;
        private int SLN;
        private int GiaPhong;
        private int iDKhachSan;


        public int ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public int SLN1 { get => SLN; set => SLN = value; }
        public int GiaPhong1 { get => GiaPhong; set => GiaPhong = value; }
        public int IDKhachSan { get => iDKhachSan; set => iDKhachSan = value; }
    }
}
