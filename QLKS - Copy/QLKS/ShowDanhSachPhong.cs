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
    public partial class ShowDanhSachPhong : UserControl
    {
        Account login;
        KhachSan KS;
        public ShowDanhSachPhong(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
            List<Phong> Phong_List = DuLieuPhong.Instance.LoadPhongList(KS.ID);
            foreach (Phong item in Phong_List)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = item.Ten + Environment.NewLine + item.TrangThai;
                if(item.TrangThai=="Trống")
                    btn.BackColor = System.Drawing.Color.Aqua;
                else if(item.TrangThai=="Đã đặt")
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
            int PhongID=((sender as Button).Tag as Phong).ID;
            ShowTTPhong show = new ShowTTPhong(PhongID);
            show.ShowDialog();
            AddPhong add = new AddPhong(this.login);
            FL_Phong = new FlowLayoutPanel() { Width = 643, Height = 242, Location = new Point(3, 3) };
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
            panel3.Controls.Add(FL_Phong);
            FL_Phong.BringToFront();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AddPhong add = new AddPhong(this.login);
            FL_Phong = new FlowLayoutPanel() { Width = 643, Height = 242, Location = new Point(3, 3) };
            FL_Phong.AutoScroll = true;
            this.KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
            add.ShowDialog();
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
            panel3.Controls.Add(FL_Phong);
            FL_Phong.BringToFront();
        }
    }
}
