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
    public partial class ShowTTPhong : Form
    {
        Phong phong;
        LoaiPhong loai;
        KhachHang khach;
        public ShowTTPhong(int idphong)
        {
            InitializeComponent();
            this.phong = DuLieuPhong.Instance.GetPhongByIDPhong(idphong);
            this.loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(phong.IDLoaiPhong);
            this.khach = DuLieuKhachHang.Instance.GetKhachHangByID(phong.IDKhachHang);
            LoadTT(this.phong);
        }
        void LoadTT(Phong phong)
        {
            label2.Text = "Tên phòng: "+phong.Ten;
            TB_IDPhong.Text = phong.ID.ToString();
            TB_TenPhong.Text = phong.Ten;
            TB_TrangThai.Text = phong.TrangThai;
            TB_LoaiPhong.Text = loai.Ten;
            TB_Gia.Text = loai.GiaPhong1.ToString();
            if(phong.TrangThai=="Đã đặt")
            {
                TB_TimeDen.Text = phong.NgayDen1;
                TB_TimeDi.Text = phong.NgayDi1;
                TB_TienDatCoc.Text = phong.DatCoc1.ToString();
                TB_TongTien.Text = phong.TongTien1.ToString();
                TB_TenKH.Text = khach.Ten1;
                TB_CMND.Text = khach.CMND1;
                TB_SDTKH.Text = khach.SDT1;
            }
            else
            {
                TB_TimeDen.Text = "";
                TB_TimeDi.Text = "";
                TB_TienDatCoc.Text = "";
                TB_TongTien.Text = "";
                TB_TenKH.Text = "";
                TB_CMND.Text = "";
                TB_SDTKH.Text = "";

            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt phòng này", "", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (TB_TrangThai.Text == "Trống")
                {
                    BookPhong book = new BookPhong(phong.ID);
                    this.Hide();
                    book.ShowDialog();
                    this.phong = DuLieuPhong.Instance.GetPhongByIDPhong(phong.ID);
                    this.loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(phong.IDLoaiPhong);
                    this.khach = DuLieuKhachHang.Instance.GetKhachHangByID(phong.IDKhachHang);
                    LoadTT(this.phong);
                    this.Show();
                }
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if(TB_TrangThai.Text!="Đang sữa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sữa chữa phòng này", "", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    CungCapDuLieu.Instance.ExcuteQuery("UPDATE Phong SET [Trạng thái]=N'Đang sữa',[ID khách hàng]='1',[Thời gian đến]=null,[Thời gian đi]=null,[Tổng tiền]='1',[Số tiền đặt cọc]='1' WHERE ID='" + this.phong.ID + "'");
                    MessageBox.Show("Đã đưa phòng vào giai đoạn sữa chữa");
                }
                this.phong = DuLieuPhong.Instance.GetPhongByIDPhong(this.phong.ID);
                this.loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(phong.IDLoaiPhong);
                this.khach = DuLieuKhachHang.Instance.GetKhachHangByID(phong.IDKhachHang);
                LoadTT(phong);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hoàn thành  việc sữa chữa không", "", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    CungCapDuLieu.Instance.ExcuteQuery("UPDATE Phong SET [Trạng thái]=N'Trống',[ID khách hàng]='1',[Thời gian đến]=null,[Thời gian đi]=null,[Tổng tiền]='1',[Số tiền đặt cọc]='1' WHERE ID='" + this.phong.ID + "'");
                    MessageBox.Show("Đã hoàn thành việc sữa chữa");
                }
                this.phong = DuLieuPhong.Instance.GetPhongByIDPhong(this.phong.ID);
                this.loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(phong.IDLoaiPhong);
                this.khach = DuLieuKhachHang.Instance.GetKhachHangByID(phong.IDKhachHang);
                LoadTT(phong);
            }
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if(phong.TrangThai=="Đã đặt"||phong.TrangThai=="Bận")
            {
                BILL bill = new BILL(this.phong);
                this.Hide();
                bill.ShowDialog();
                this.phong = DuLieuPhong.Instance.GetPhongByIDPhong(phong.ID);
                this.loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(phong.IDLoaiPhong);
                this.khach = DuLieuKhachHang.Instance.GetKhachHangByID(phong.IDKhachHang);
                LoadTT(this.phong);
                this.Show();
            }
            else
            {
                MessageBox.Show("Hiện phòng không có ai ở nên không thể thanh toán");
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AddDichVU dv = new AddDichVU(phong);
            this.Hide();
            dv.ShowDialog();
            this.Show();
        }
    }
}
