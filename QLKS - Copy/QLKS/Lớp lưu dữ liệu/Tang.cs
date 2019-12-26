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
    class Tang
    {
        public Tang(int iD,string ten,int iDKhachSan)
        {
            this.iD = iD;
            this.ten = ten;
            this.iDKhachSan = iDKhachSan;
        }
        public Tang(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.ten = row["Tên tầng"].ToString();
            this.iDKhachSan=(int)row["ID khách sạn"];
        }
        private int iD;
        private string ten;
        private int iDKhachSan;

        public int ID { get => iD; set => iD = value; }
        public int IDKhachSan { get => iDKhachSan; set => iDKhachSan = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
