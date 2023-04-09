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
    public partial class xem : Form
    {
        public xem()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hocphi hp = new hocphi();
            hp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diem d = new diem();
            d.Show();
        }
    }
}
