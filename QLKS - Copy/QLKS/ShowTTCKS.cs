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
    public partial class ShowTTCKS : UserControl
    {
        Account login;
        public ShowTTCKS(Account acc)
        {
            InitializeComponent();
            this.login = acc;
            LoadTTCKS(this.login);
        }
        void LoadTTCKS(Account acc)
        {
            LB_TTK.Text = acc.Username;
            LB_Ten.Text = acc.Ten;
            LB_SDT.Text = acc.SDT1;
            LB_DC.Text = acc.DiaChi1;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ChangeTTChuKS change = new ChangeTTChuKS(login);
            change.ShowDialog();
        }
    }
}
