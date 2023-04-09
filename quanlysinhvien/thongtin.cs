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
    public partial class thongtin : Form
    {
        string str = @"Data Source=DESKTOP-SMD1BM0\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True";
        SqlConnection conn;
        string tk = "", tennguoidung = "", mk = "", quyen = "";
        public thongtin()
        {
            InitializeComponent();
        }
        public thongtin(string tk, string tennguoidung, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.tennguoidung = tennguoidung;
            this.mk = mk;
            this.quyen = quyen;
        }
        public void Loaddata()
        {
            SqlCommand command = new SqlCommand("select * from thongtin", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        public void loaddata()
        {
            SqlCommand command = new SqlCommand("select * from diem", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView2.DataSource = tb;
            dataGridView2.Refresh();
        }
        public void loaddata1()
        {
            SqlCommand command = new SqlCommand("select * from hocphi", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView3.DataSource = tb;
            dataGridView3.Refresh();
        }
        public void loaddata2()
        {
            SqlCommand command = new SqlCommand("select * from monhoc", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView4.DataSource = tb;
            dataGridView4.Refresh();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            quyen = "Admin";
            quyen = "User";
            txtmsv1.Text = "";
            txthoten.Text = "";
            dateTimePicker1.Text = "";
            cbgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txthotenph.Text = "";
            txtsdtph.Text = "";
            txtnn.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
          
                SqlCommand comand = conn.CreateCommand();
                comand.CommandText = "delete from thongtin where msv1='" + txtmsv1.Text + "'";
                comand.ExecuteNonQuery();
                Loaddata();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.ExecuteNonQuery();
            conn.Open();
            Loaddata();
        }

        private void thongtin_Load_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            Loaddata();
            loaddata();
            loaddata1();
            loaddata2();
        }

        private void btthoat1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
       
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata1();
        }

        private void btthoat3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }

        private void btreset3_Click(object sender, EventArgs e)
        {
            txtmsv3.Text = "";
            txtten3.Text = "";
            txthocphi.Text = "";
        }

        private void btxoa3_Click(object sender, EventArgs e)
        {
           
                SqlCommand comand = conn.CreateCommand();
                comand.CommandText = "delete from hocphi where msv3='" + txtmsv3.Text + "'";
                comand.ExecuteNonQuery();
                loaddata1();
            
        }

        private void btsua3_Click(object sender, EventArgs e)
        {
                SqlCommand comand = conn.CreateCommand();
                comand.CommandText = "update hocphi set msv2='" + txtmsv3.Text + "',hoten='" + txtten3.Text + "', hocphi='" + txthocphi + "'";
                comand.ExecuteNonQuery();
                loaddata1();
           
        }

        private void btthem3_Click(object sender, EventArgs e)
        {
           
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO hocphi values('" + txtmsv3.Text + "', '" + txtten3.Text + "', '" + txthocphi.Text + "')";
                command.ExecuteNonQuery();
                loaddata1();
           
        }
 

      
        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            txtmsv3.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txtten3.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            txthocphi.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            
        }

        private void btxem_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.Show();
        }

        private void btxem1_Click(object sender, EventArgs e)
        {
            diem d = new diem();
            d.Show();
        }

        private void btxem2_Click(object sender, EventArgs e)
        {
            hocphi hp = new hocphi();
            hp.Show();
        }

        

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbmamon.Items.Clear();
            txttenmon.Text = "";
            txtstc.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO monhoc values('" + cbmonhoc.Text + "', '" + txttenmon.Text + "', '" + txtstc.Text + "')";
            command.ExecuteNonQuery();
            loaddata2();
        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata2();
        }

        private void btthem1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO diem values('" + txtmsv2.Text + "', '" + cbmamon.Text + "','" + cblanthi.Text + "', '" + txtdiem.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btthoat1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }

        private void btreset1_Click_1(object sender, EventArgs e)
        {
            txtmsv2.Text = "";
            cblanthi.Items.Clear();
            cbmamon.Items.Clear();
            txtdiem.Text = "";
        }

        private void btsua1_Click_1(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "update diem set msv2='" + txtmsv2.Text + "',lanthi='" + cblanthi.Text + "',mamon='"+cbmamon.Text+"', diem='" + txtdiem + "'";
            comand.ExecuteNonQuery();
            loaddata();
        }

        private void btxoa1_Click_1(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from diem where msv2='" + txtmsv2.Text + "'";
            comand.ExecuteNonQuery();
            loaddata();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "update thongtin set msv1='" + txtmsv1.Text + "',hoten='" + txthoten.Text + "',ngaysinh='" + dateTimePicker1.Text + "',gioitinh='" + cbgioitinh.Text + "',diachi='" + txtdiachi.Text + "',SDT='" + txtsdt.Text + "',hotenph='" + txthotenph.Text + "',sdtph='" + txtsdtph.Text + "',quequan='" + txtnn.Text + "'  where msv1 = '" + txtmsv1.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from thongtin where msv1='" + txtmsv1.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txtmsv1.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtdt.Text = "";
            txttg.Text = "";
            txtsdt.Text = "";
            txtsdtph.Text = "";
            txthotenph.Text = "";
            txtnn.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            monhoc m = new monhoc();
            m.Show();
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txttenmon.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtstc.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
        }

        private void btxem_Click_1(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.Show();
        }

        private void btxem1_Click_1(object sender, EventArgs e)
        {
            diem d = new diem();
            d.Show();
        }

        private void btthoat_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from monhoc where mamon='" + cbmonhoc.Text + "'";
            comand.ExecuteNonQuery();
            loaddata2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtmsv2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            cbmamon.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cblanthi.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtdiem.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            loaddata();
        }

        private void btthem_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO thongtin values('" + txtmsv1.Text + "','" + txthoten.Text + "','"+cbmalop.Text+"' , '" + dateTimePicker1.Text + "', '" + cbgioitinh.Text + "', '" + txtdiachi.Text + "','" + txtdt.Text + "','" + txttg.Text + "', '" + txtsdt.Text + "', '" + txthotenph.Text + "', '" + txtsdtph.Text + "', '" + txtnn.Text + "')";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtmsv1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbmalop.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            cbgioitinh.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtdt.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txttg.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txthotenph.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txtsdtph.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            txtnn.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
        }

        

       
    }
}
