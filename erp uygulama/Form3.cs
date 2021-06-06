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

namespace erp_uygulama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        SqlConnection bagla = new SqlConnection("Data Source=LAPTOP-7OMCFUUD\\SQLEXPRESS_2017;Initial Catalog=erpUyg;Integrated Security=True");

        private void verileriListele()
        {
            listView1.Items.Clear();
            bagla.Open();

            SqlCommand komut = new SqlCommand("Select *From profiller", bagla);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["profilid"].ToString();
                ekle.SubItems.Add(oku["kısakod"].ToString());
                ekle.SubItems.Add(oku["aramakelimesi"].ToString());
                ekle.SubItems.Add(oku["aramagenisletimi"].ToString());

                listView1.Items.Add(ekle);
            }
            bagla.Close();
        } //cerceveler tablosu için listeleme fonksiyonu
 
        private void button_kaydet_Click(object sender, EventArgs e)
        {

            bagla.Open();


            SqlCommand komut = new SqlCommand("insert into profiller(profilid,kısakod,aramakelimesi,aramagenisletimi) values('" +textBox6.Text.ToString()+ "','" +  textBox2.Text.ToString() + "','" +
                textBox3.Text.ToString() + "','" + textBox4.Text.ToString()+"')", bagla);


            komut.ExecuteNonQuery();
            bagla.Close();
            verileriListele();

        }


        private void button_ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bagla.Open();

            SqlCommand komut = new SqlCommand("Select * From profiller where aramakelimesi like '%" + textBox1.Text + "%'", bagla);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["profilid"].ToString();
                ekle.SubItems.Add(oku["kısakod"].ToString());
                ekle.SubItems.Add(oku["aramakelimesi"].ToString());
                ekle.SubItems.Add(oku["aramagenisletimi"].ToString());

                listView1.Items.Add(ekle);
            }
            bagla.Close();
            
        }

        int id = 0;
        private void button_sil_Click(object sender, EventArgs e)
        {
            bagla.Open();

            SqlCommand komut = new SqlCommand("Delete from profiller where profilid=(" + id + ")", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
            verileriListele();
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            bagla.Open();

            SqlCommand komut = new SqlCommand("update profiller set profilid='" + textBox6.Text.ToString() +
                "',kısakod='" + textBox2.Text.ToString() + "',aramakelimesi='" + textBox3.Text.ToString() +
                "',aramagenisletimi='" + textBox4.Text.ToString() + "'", bagla);


            komut.ExecuteNonQuery();
            bagla.Close();
            verileriListele();
                }

       
    }


}
