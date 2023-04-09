using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class giaodien : Form
    {
        public int i = 10;
        string tk = "", tennguoidung = "", mk = "", quyen = "";
        public giaodien(string tk, string tennguoidung, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.tennguoidung = tennguoidung;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                giangvien gv = new giangvien();
                gv.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
             
        
            label1.Left += i;
            if (label1.Left >= this.Width - label1.Width || label1.Left <= 0)
                i = -i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(quyen == "Admin")
            {
                thongtin tt = new thongtin();
                tt.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xem x = new xem();
            x.Show();
        }
    }
}
