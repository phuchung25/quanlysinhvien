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

namespace quanlysinhvien
{
    public partial class timkiem : Form
    {
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-SMD1BM0\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True";
        private DataTable table = new DataTable();
        public void Loaddata()
        {
            SqlCommand command = new SqlCommand("select * from thongtin", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        public timkiem()
        {
            InitializeComponent();
        }

        private void timkiem_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            Loaddata();
        }
    }
}
