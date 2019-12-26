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
    public partial class AddTang : Form
    {
        Account login;
        public AddTang()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(Check("Tang",TB_ID.Text)==true)
            {
                MessageBox.Show("ID đã tồn tại");
            }
            else
            {
                CungCapDuLieu.Instance.ExcuteQuery("INSERT INTO Tang VALUES('" + TB_ID.Text + "',N'" + TB_Ten.Text + "','" + TB_IDKS.Text + "')");
                MessageBox.Show("Thêm thành công");
                this.Hide();
            }
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
