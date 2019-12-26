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
using QLKS.Lớp_lưu_dữ_liệu;
using QLKS.Lớp_truy_cập_dữ_liệu;

namespace QLKS
{
    public partial class ShowDanhSachTang : UserControl
    {
        Account login;
        KhachSan KS;
        public ShowDanhSachTang(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            this.KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
            List<Tang> Tang_List = DuLieuTang.Instance.LoadLoaiPhongList(this.KS.ID);
            foreach (Tang item in Tang_List)
            {
                Button btn = new Button() { Width = 380, Height = 50 };
                btn.Text = item.Ten;
                FL_Tang.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Tag = item;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int IDTang = ((sender as Button).Tag as Tang).ID;
            ShowTTTang show = new ShowTTTang(IDTang, this.login);
            show.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AddTang add = new AddTang();
            FL_Tang = new FlowLayoutPanel() {Width= 440,Height= 242,Location=new Point(108,3) };
            FL_Tang.AutoScroll = true;
            add.ShowDialog();
            this.KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(this.login.ID);
            List<Tang> Tang_List = DuLieuTang.Instance.LoadLoaiPhongList(this.KS.ID);
            foreach (Tang item in Tang_List)
            {
                Button btn = new Button() { Width = 380, Height = 50 };
                btn.Text = item.Ten;
                FL_Tang.Controls.Add(btn);
                btn.Click += Btn_Click1;
                btn.Tag = item;
            }
            panel3.Controls.Add(FL_Tang);
            FL_Tang.BringToFront();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            int IDTang = ((sender as Button).Tag as Tang).ID;
            ShowTTTang show = new ShowTTTang(IDTang, this.login);
            show.ShowDialog();
        }
    }
}
