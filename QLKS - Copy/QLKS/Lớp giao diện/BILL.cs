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
using System.IO;

namespace QLKS
{
    public partial class BILL : Form
    {
        int Tong_tien;
        Phong Phong;
        KhachHang KH;
        public BILL(Phong phong)
        {
            Phong = phong;
            InitializeComponent();
            KH = DuLieuKhachHang.Instance.GetKhachHangByID(Phong.IDKhachHang);
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
                MessageBox.Show("Số tiền khách hàng phải trả là:" + (Tong_tien-Phong.DatCoc1).ToString());
                CungCapDuLieu.Instance.ExcuteQuery("UPDATE Phong SET [Trạng thái]=N'Trống',[ID khách hàng]='1',[Thời gian đến]=null,[Thời gian đi]=null,[Tổng tiền]='1',[Số tiền đặt cọc]='1' WHERE ID='" + Phong.ID + "'");
                CungCapDuLieu.Instance.ExcuteQuery("DELETE FROM Bill WHERE [ID phòng]='" + Phong.ID + "'");
                this.Hide();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            TextWriter writer = new StreamWriter(@TB_link.Text);
            writer.WriteLine("Tên phòng: "+Phong.Ten);
            writer.WriteLine("Tên khách hàng: " + KH.Ten1);
            writer.WriteLine("Thời gian: " + dateTime);
            for(int i=0;i<DTGV_Bill.Rows.Count-1;i++)
            {
                for(int j=0;j<DTGV_Bill.Columns.Count;j++)
                {
                    writer.Write(DTGV_Bill.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------------------");
            }
            writer.WriteLine("Tổng tiền: " + TB_TongTien.Text);
            writer.WriteLine("Đã đặt cọc: " + Phong.DatCoc1.ToString());
            writer.WriteLine("Số tiền thanh toán: " + (int.Parse( TB_TongTien.Text)-Phong.DatCoc1).ToString());
            writer.Close();
            MessageBox.Show("Xuất bill thành công");
        }
    }
}
