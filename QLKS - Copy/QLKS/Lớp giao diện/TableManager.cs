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

namespace QLKS
{
    public partial class TableManager : Form
    {
        private Account login;
        public TableManager(Account acc)
        {
            InitializeComponent();
            this.login = acc;
        }
        #region TTCKS_CLick
        private void Button1_Click_1(object sender, EventArgs e)
        {
            SetUp();
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            ShowTTCKS TTCKS = new ShowTTCKS(login);
            panel1.Controls.Add(TTCKS);
            TTCKS.BringToFront();
        }
        private void Pnl_TTCKS_Click(object sender, EventArgs e)
        {
            SetUp();
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            ShowTTCKS TTCKS = new ShowTTCKS(login);
            panel1.Controls.Add(TTCKS);
            TTCKS.BringToFront();
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            SetUp();
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            ShowTTCKS TTCKS = new ShowTTCKS(login);
            panel1.Controls.Add(TTCKS);
            TTCKS.BringToFront();
        }
        private void Label3_Click(object sender, EventArgs e)
        {
            SetUp();
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            ShowTTCKS TTCKS = new ShowTTCKS(login);
            panel1.Controls.Add(TTCKS);
            TTCKS.BringToFront();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SetUp();
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            ShowTTCKS TTCKS = new ShowTTCKS(login);
            panel1.Controls.Add(TTCKS);
            TTCKS.BringToFront();
        }
        private void Label25_Click(object sender, EventArgs e)
        {
            SetUp();
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            ShowTTCKS TTCKS = new ShowTTCKS(login);
            panel1.Controls.Add(TTCKS);
            TTCKS.BringToFront();
        }
        #endregion
        #region DST_Click
        private void Button4_Click(object sender, EventArgs e)
        {
            SetUp();
            button4.BackColor = System.Drawing.Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachTang DST = new ShowDanhSachTang(login);
            panel1.Controls.Add(DST);
            DST.BringToFront();
        }

        private void Pnl_DST_Click(object sender, EventArgs e)
        {
            SetUp();
            button4.BackColor = System.Drawing.Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachTang DST = new ShowDanhSachTang(login);
            panel1.Controls.Add(DST);
            DST.BringToFront();
        }
        private void Label7_Click(object sender, EventArgs e)
        {
            SetUp();
            button4.BackColor = System.Drawing.Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachTang DST = new ShowDanhSachTang(login);
            panel1.Controls.Add(DST);
            DST.BringToFront();
        }
        private void Label6_Click(object sender, EventArgs e)
        {
            SetUp();
            button4.BackColor = System.Drawing.Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachTang DST = new ShowDanhSachTang(login);
            panel1.Controls.Add(DST);
            DST.BringToFront();
        }
        private void Label5_Click(object sender, EventArgs e)
        {
            SetUp();
            button4.BackColor = System.Drawing.Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachTang DST = new ShowDanhSachTang(login);
            panel1.Controls.Add(DST);
            DST.BringToFront();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SetUp();
            button4.BackColor = System.Drawing.Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachTang DST = new ShowDanhSachTang(login);
            panel1.Controls.Add(DST);
            DST.BringToFront();
        }

        #endregion
        #region DSNV_Click

        #endregion
        #region TTC_Click
        private void Button2_Click(object sender, EventArgs e)
        {
            SetUp();
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            ShowTTKhachSan TTKS = new ShowTTKhachSan(login);
            panel1.Controls.Add(TTKS);
            TTKS.BringToFront();
        }
        private void Pnl_TTC_Click(object sender, EventArgs e)
        {
            SetUp();
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            ShowTTKhachSan TTKS = new ShowTTKhachSan(login);
            panel1.Controls.Add(TTKS);
            TTKS.BringToFront();
        }
        private void Label12_Click(object sender, EventArgs e)
        {
            SetUp();
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            ShowTTKhachSan TTKS = new ShowTTKhachSan(login);
            panel1.Controls.Add(TTKS);
            TTKS.BringToFront();
        }
        private void Label11_Click(object sender, EventArgs e)
        {
            SetUp();
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            ShowTTKhachSan TTKS = new ShowTTKhachSan(login);
            panel1.Controls.Add(TTKS);
            TTKS.BringToFront();
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            SetUp();
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            ShowTTKhachSan TTKS = new ShowTTKhachSan(login);
            panel1.Controls.Add(TTKS);
            TTKS.BringToFront();
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            SetUp();
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
            ShowTTKhachSan TTKS = new ShowTTKhachSan(login);
            panel1.Controls.Add(TTKS);
            TTKS.BringToFront();
        }
        #endregion
        #region DSP_Click
        private void Pnl_DSP_Click(object sender, EventArgs e)
        {
            SetUp();
            button5.BackColor = System.Drawing.Color.White;
            button5.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachPhong DSP = new ShowDanhSachPhong(login);
            panel1.Controls.Add(DSP);
            DSP.BringToFront();
        }
        private void Label15_Click(object sender, EventArgs e)
        {
            SetUp();
            button5.BackColor = System.Drawing.Color.White;
            button5.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachPhong DSP = new ShowDanhSachPhong(login);
            panel1.Controls.Add(DSP);
            DSP.BringToFront();
        }
        private void Label14_Click(object sender, EventArgs e)
        {
            SetUp();
            button5.BackColor = System.Drawing.Color.White;
            button5.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachPhong DSP = new ShowDanhSachPhong(login);
            panel1.Controls.Add(DSP);
            DSP.BringToFront();
        }
        private void Label13_Click(object sender, EventArgs e)
        {
            SetUp();
            button5.BackColor = System.Drawing.Color.White;
            button5.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachPhong DSP = new ShowDanhSachPhong(login);
            panel1.Controls.Add(DSP);
            DSP.BringToFront();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            SetUp();
            button5.BackColor = System.Drawing.Color.White;
            button5.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachPhong DSP = new ShowDanhSachPhong(login);
            panel1.Controls.Add(DSP);
            DSP.BringToFront();
        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            SetUp();
            button5.BackColor = System.Drawing.Color.White;
            button5.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachPhong DSP = new ShowDanhSachPhong(login);
            panel1.Controls.Add(DSP);
            DSP.BringToFront();
        }
        #endregion
        #region DVMR_Click
        private void Pnl_DVMR_Click(object sender, EventArgs e)
        {
            SetUp();
            button7.BackColor = System.Drawing.Color.White;
            button7.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachDichVu DSDV = new ShowDanhSachDichVu(login);
            panel1.Controls.Add(DSDV);
            DSDV.BringToFront();
        }
        private void Label24_Click(object sender, EventArgs e)
        {
            SetUp();
            button7.BackColor = System.Drawing.Color.White;
            button7.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachDichVu DSDV = new ShowDanhSachDichVu(login);
            panel1.Controls.Add(DSDV);
            DSDV.BringToFront();
        }
        private void Label23_Click(object sender, EventArgs e)
        {
            SetUp();
            button7.BackColor = System.Drawing.Color.White;
            button7.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachDichVu DSDV = new ShowDanhSachDichVu(login);
            panel1.Controls.Add(DSDV);
            DSDV.BringToFront();
        }
        private void Label22_Click(object sender, EventArgs e)
        {
            SetUp();
            button7.BackColor = System.Drawing.Color.White;
            button7.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachDichVu DSDV = new ShowDanhSachDichVu(login);
            panel1.Controls.Add(DSDV);
            DSDV.BringToFront();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            SetUp();
            button7.BackColor = System.Drawing.Color.White;
            button7.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachDichVu DSDV = new ShowDanhSachDichVu(login);
            panel1.Controls.Add(DSDV);
            DSDV.BringToFront();
        }

        #endregion
        #region LP_Click
        private void PictureBox8_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }

        private void Pnl_LP_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }
        private void Label21_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }

        private void Label19_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }
        private void PictureBox7_Click(object sender, EventArgs e)
        {
            SetUp();
            button3.BackColor = System.Drawing.Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
            ShowDanhSachLoaiPhong DSLP = new ShowDanhSachLoaiPhong(login);
            panel1.Controls.Add(DSLP);
            DSLP.BringToFront();
        }
        #endregion
        void SetUp()
        {
            button1.BackColor = System.Drawing.Color.Black;
            button1.ForeColor = System.Drawing.Color.White;

            button2.BackColor = System.Drawing.Color.Black;
            button2.ForeColor = System.Drawing.Color.White;

            button3.BackColor = System.Drawing.Color.Black;
            button3.ForeColor = System.Drawing.Color.White;

            button4.BackColor = System.Drawing.Color.Black;
            button4.ForeColor = System.Drawing.Color.White;

            button5.BackColor = System.Drawing.Color.Black;
            button5.ForeColor = System.Drawing.Color.White;

            button7.BackColor = System.Drawing.Color.Black;
            button7.ForeColor = System.Drawing.Color.White;

            button8.BackColor = System.Drawing.Color.Black;
            button8.ForeColor = System.Drawing.Color.White;
        }
        private void PictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableManager TB_MNG = new TableManager(login);
            TB_MNG.ShowDialog();
        }
    }
}
