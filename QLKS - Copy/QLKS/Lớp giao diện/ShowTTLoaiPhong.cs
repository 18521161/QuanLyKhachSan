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
    public partial class ShowTTLoaiPhong : Form
    {
        Account login;
        KhachSan KS;
        LoaiPhong loai;
        public ShowTTLoaiPhong(int IDLoaiPhong,Account acc)
        {
            InitializeComponent();
            login = acc;
            loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(IDLoaiPhong);
            KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(login.ID);
            TB_TenLoaiPhong.Text = loai.Ten;
            TB_Gia.Text = loai.GiaPhong1.ToString();
            TB_Sl.Text = loai.SLN1.ToString();
            List<Phong> Phong_List = DuLieuPhong.Instance.LoadPhongListbyIDLoaiPhong(this.KS.ID, this.loai.ID);
            foreach (Phong item in Phong_List)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = item.Ten + Environment.NewLine + item.TrangThai;
                if (item.TrangThai == "Trống")
                    btn.BackColor = System.Drawing.Color.Aqua;
                else if (item.TrangThai == "Đã đặt")
                    btn.BackColor = System.Drawing.Color.Yellow;
                else
                    btn.BackColor = System.Drawing.Color.Red;

                FL_Phong.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Tag = item;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int PhongID = ((sender as Button).Tag as Phong).ID;
            ShowTTPhong show = new ShowTTPhong(PhongID);
            show.ShowDialog();
            AddPhong add = new AddPhong(this.login);
            FL_Phong = new FlowLayoutPanel() { Width = 320, Height = 225, Location = new Point(322, 59) };
            FL_Phong.AutoScroll = true;
            List<Phong> Phong_List = DuLieuPhong.Instance.LoadPhongList(KS.ID);
            foreach (Phong item in Phong_List)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = item.Ten + Environment.NewLine + item.TrangThai;
                if (item.TrangThai == "Trống")
                    btn.BackColor = System.Drawing.Color.Aqua;
                else if (item.TrangThai == "Đã đặt")
                    btn.BackColor = System.Drawing.Color.Yellow;
                else
                    btn.BackColor = System.Drawing.Color.Red;

                FL_Phong.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Tag = item;
            }
            FL_Phong.BringToFront();
        }
    }
}
