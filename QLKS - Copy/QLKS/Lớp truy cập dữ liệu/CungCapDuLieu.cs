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

namespace QLKS.Lớp_truy_cập_dữ_liệu
{
    public class CungCapDuLieu
    {
        private static CungCapDuLieu instance;
        String str = @"Data Source=DESKTOP-BAK169M\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public static CungCapDuLieu Instance
        {
            get { if (instance == null) instance = new CungCapDuLieu();return CungCapDuLieu.instance; }
            private set { CungCapDuLieu.instance = value; }
        }
        private CungCapDuLieu() { }
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void Update(string query)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
        }
    }
}
