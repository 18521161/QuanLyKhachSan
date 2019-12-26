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
    public partial class BookPhong : Form
    {
        Phong phong;
        LoaiPhong loai;
        KhachHang khach;
        public BookPhong(int IDPhong)
        {
            InitializeComponent();
            this.phong = DuLieuPhong.Instance.GetPhongByIDPhong(IDPhong);
            this.loai = DuLieuLoaiPhong.Instance.GetLoaiPhongByPhongID(phong.IDLoaiPhong);
            label2.Text = "Đặt phòng: "+phong.Ten;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Check("KhachHang",TB_IDKhachHang.Text)==true)
            {
                MessageBox.Show("ID khách hàng đã tồn tại");
            }
            else
            {
                MessageBox.Show("Hoàn thành việc đặt phòng");
                CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO KhachHang VALUES(N'" + TB_IDKhachHang.Text + "',N'" + TB_TenKH.Text + "',N'" + TB_CMND.Text + "',N'" + TB_SDTKH.Text + "')");
                CungCapDuLieu.Instance.ExcuteQuery("UPDATE Phong SET [Trạng thái]=N'Đã đặt',[ID khách hàng]='" + TB_IDKhachHang.Text + "',[Thời gian đến] = '" + dateTimePicker1.Text + "',[Thời gian đi] = '" + dateTimePicker1.Text + "',[Tổng tiền] = '" + loai.GiaPhong1.ToString() + "',[Số tiền đặt cọc] = '" + TB_TienDatCoc.Text + "' WHERE ID='" + this.phong.ID + "'");
                CungCapDuLieu.Instance.ExcuteQuery("insert into Bill values('" + phong.ID + "',N'Tiền phòng','1','" + loai.GiaPhong1 + "','" + loai.GiaPhong1 + "')");
                this.Hide();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public bool Check(string Ten_Bang, string Dulieu)
        {
            DataTable dt_kiemtra = CungCapDuLieu.Instance.ExcuteQuery("SELECT * FROM " + Ten_Bang + " WHERE ID='" + Dulieu + "'");
            if (dt_kiemtra.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
