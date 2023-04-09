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
    public partial class giangvien : Form
    {
        string str = @"Data Source=DESKTOP-SMD1BM0\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True";
        SqlConnection conn;
        public giangvien()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            SqlCommand command = new SqlCommand("select * from giangvien", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtmgv.Text = "";
            txtten.Text = "";
            txtmk.Text = "";
            txthv.Text = "";
            txtdt.Text = "";
            txtdc.Text = "";
            txtcn.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gv g = new gv();
            g.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giangvien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            Loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtmgv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtdc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtdt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txthv.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtcn.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtmk.Text = dataGridView1.Rows[i].Cells[7].Value.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO giangvien values('" + txtmgv.Text + "','" + txtten.Text + "','" + txtdc.Text + "' , '" + txtdt.Text + "', '" + txthv.Text + "', '" + txtcn.Text + "','" + txtmk.Text + "')";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "update giangvien set mgv='" + txtmgv.Text + "',hoten='" + txtten.Text + "',diachi='" + txtdt.Text + "',sdt='" + txtdt.Text + "',hocvi='" + txthv.Text + "',chuyennganh='" + txtcn.Text + "',makhoa='" + txtmk.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from giangvien where mgv='" + txtmgv.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }
    }
}
