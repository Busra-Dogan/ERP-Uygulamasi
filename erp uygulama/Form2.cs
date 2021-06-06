using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp_uygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 urunler = new Form3();
            urunler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 personel = new Form4();
            personel.Show();
        }
    }
}
