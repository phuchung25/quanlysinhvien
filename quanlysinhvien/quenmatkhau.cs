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
    public partial class quenmatkhau : Form
    {
        
        public quenmatkhau()
        {
            InitializeComponent();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxacnhan_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn đã xác nhận cấp lại mật khẩu của mình bạn vui lòng chờ để bộ phận hỗ trờ sẽ phản hồi cho bạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SMD1BM0\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO quenmatkhau values('" + txttk1.Text + "','"+txtmsv.Text+"', '" + txtten.Text + "', '" + txtemail.Text + "')";
            
        }

        private void btthoat5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Thoát CHương Trình Ngay !");
            this.Close();
        }

        private void quenmatkhau_Load(object sender, EventArgs e)
        {
          
        }
    }
}
