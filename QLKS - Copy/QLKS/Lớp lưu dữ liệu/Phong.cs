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
    public class Phong
    {
        public Phong(int id,string ten,string trangthai,int idtang,int idloaiphong,int idkhachsan, int iDKhachHang,string NgayDen,string NgayDi,int DatCoc,int TongTien )
        {
            this.iD = id;
            this.ten = ten;
            this.trangThai = trangthai;
            this.iDTang = idtang;
            this.iDLoaiPhong = idloaiphong;
            this.iDKhachSan = idkhachsan;
            this.iDKhachHang = iDKhachHang;
            this.NgayDen = NgayDen;
            this.NgayDi = NgayDi;
            this.DatCoc = DatCoc;
            this.TongTien = TongTien;
        } 
        public Phong(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.ten = row["Tên Phòng"].ToString();
            this.trangThai= row["Trạng thái"].ToString();
            this.iDLoaiPhong = (int)row["ID loại phòng"];
            this.iDTang = (int)row["ID tầng"];
            this.iDKhachSan = (int)row["ID khách sạn"];
            this.iDKhachHang= (int)row["ID khách hàng"];
            this.NgayDen = row["Thời gian đến"].ToString();
            this.NgayDi = row["Thời gian đi"].ToString();
            this.DatCoc = (int)row["Số tiền đặt cọc"];
            this.TongTien = (int)row["Tổng tiền"];
        }
        private int iD;
        private string ten;
        private string trangThai;
        private int iDTang;
        private int iDLoaiPhong;
        private int iDKhachSan;
        private int iDKhachHang;
        private string NgayDen;
        private string NgayDi;
        private int DatCoc;
        private int TongTien;

        public int ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int IDTang { get => iDTang; set => iDTang = value; }
        public int IDLoaiPhong { get => iDLoaiPhong; set => iDLoaiPhong = value; }
        public int IDKhachSan { get => iDKhachSan; set => iDKhachSan = value; }
        public int IDKhachHang { get => iDKhachHang; set => iDKhachHang = value; }
        public string NgayDen1 { get => NgayDen; set => NgayDen = value; }
        public string NgayDi1 { get => NgayDi; set => NgayDi = value; }
        public int DatCoc1 { get => DatCoc; set => DatCoc = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
