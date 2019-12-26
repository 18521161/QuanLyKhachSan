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
    public class Account
    {
        public Account(int iD, string username, string password, string ten, string DiaChi, string SDT)
        {
            this.iD = iD;
            this.username = username;
            this.password = password;
            this.ten = ten;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
        public Account(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.username = row["Tên đăng nhập"].ToString();
            this.password = row["Mật khẩu"].ToString();
            this.ten = row["Họ và tên"].ToString();
            this.DiaChi= row["Địa chỉ"].ToString();
            this.SDT= row["Số điện thoại"].ToString();
        }
        public Account() { }
        private int iD;
        private string username;
        private string password;
        private string ten;
        private string DiaChi;
        private string SDT;
        public int ID { get => iD; set => iD = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        
    }
}
