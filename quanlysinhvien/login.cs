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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SMD1BM0\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.taikhoan WHERE tk ='" + txttk.Text + "' AND mk = '" + txtmk.Text + "'", conn);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("Login SuccessFully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                giaodien gd = new giaodien(tb.Rows[0][0].ToString(), tb.Rows[0][1].ToString(), tb.Rows[0][2].ToString(), tb.Rows[0][3].ToString());
                gd.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            quenmatkhau quenmk = new quenmatkhau();
            quenmk.Show();
        }
    }
}
