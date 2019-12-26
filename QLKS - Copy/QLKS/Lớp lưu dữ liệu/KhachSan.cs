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
    class KhachSan
    {
        public KhachSan(int iD, string ten, string diaChi, string SDT,int iDChuKhachSan,string email)
        {
            this.iD = iD;
            this.ten = ten;
            this.diaChi = diaChi;
            this.SDT = SDT;
            this.iDChuKhachSan = iDChuKhachSan;
            this.Email = email;
        }
        public KhachSan(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.ten = row["Tên khách sạn"].ToString();
            this.DiaChi = row["Địa chỉ khách sạn"].ToString();
            this.SDT = row["Số điện thoại khách sạn"].ToString();
            this.Email = row["Email"].ToString();
            this.iDChuKhachSan = (int)row["ID chủ khách sạn"];
        }
        public KhachSan() { }
        private int iD;
        private string ten;
        private string diaChi;
        private string SDT;
        private string Email;
        private int iDChuKhachSan;

        public int ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public int IDChuKhachSan { get => iDChuKhachSan; set => iDChuKhachSan = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
