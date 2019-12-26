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
    public partial class BILL : Form
    {
        int Tong_tien;
        Phong Phong;
        public BILL(Phong phong)
        {
            Phong = phong;
            InitializeComponent();
            DTGV_Bill.DataSource = CungCapDuLieu.Instance.ExcuteQuery("select sum([Thành tiền]) from Bill where [ID phòng]='"+Phong.ID+"'");
            TB_TongTien.Text = DTGV_Bill.Rows[0].Cells[0].Value.ToString();
            Tong_tien = int.Parse(TB_TongTien.Text);
            DTGV_Bill.DataSource = CungCapDuLieu.Instance.ExcuteQuery("select [Tên dịch vụ],[Số lượng],[Đơn giá],[Thành tiền]  from Bill where [ID phòng]='" + Phong.ID + "'");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán phòng này", "", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Số tiền khách hàng phải trả là:" + Tong_tien.ToString());
                CungCapDuLieu.Instance.ExcuteQuery("UPDATE Phong SET [Trạng thái]=N'Trống',[ID khách hàng]='1',[Thời gian đến]=null,[Thời gian đi]=null,[Tổng tiền]='1',[Số tiền đặt cọc]='1' WHERE ID='" + Phong.ID + "'");
                CungCapDuLieu.Instance.ExcuteQuery("DELETE FROM Bill WHERE [ID phòng]='" + Phong.ID + "'");
                this.Hide();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
