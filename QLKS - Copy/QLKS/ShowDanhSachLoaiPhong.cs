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
using QLKS.Lớp_lưu_dữ_liệu;

namespace QLKS
{
    public partial class ShowDanhSachLoaiPhong : UserControl
    {
        Account login;
        KhachSan KS;
        public ShowDanhSachLoaiPhong(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            this.KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
            List<LoaiPhong> LoaiPhong_List = DuLieuLoaiPhong.Instance.LoadLoaiPhongList(this.KS.ID);
            foreach (LoaiPhong item in LoaiPhong_List)
            {
                Button btn = new Button() { Width = 380, Height = 50 };
                btn.Text = item.Ten + Environment.NewLine + "Giá phòng: " + item.GiaPhong1 + "VNĐ";
                FL_LoaiPhong.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Tag = item;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int idloaiphong = ((sender as Button).Tag as LoaiPhong).ID;
            ShowTTLoaiPhong show = new ShowTTLoaiPhong(idloaiphong,login) ;
            show.ShowDialog();
        }
    }
}
