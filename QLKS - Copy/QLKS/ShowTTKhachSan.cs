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
    public partial class ShowTTKhachSan : UserControl
    {
        Account login;
        public ShowTTKhachSan(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            LoadTTKS(login);
        }
        void LoadTTKS(Account acc)
        {
            KhachSan KS = DuLieuKhachSan.Instance.GetKhachSanByIDBoss(acc.ID);
            LB_Ten.Text = KS.Ten;
            LB_DiaChi.Text = KS.DiaChi;
            LB_SDT.Text = KS.SDT1;
            LB_Email.Text = KS.Email1;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ChangTTKS change = new ChangTTKS(login);
            change.ShowDialog();
        }
    }
}
