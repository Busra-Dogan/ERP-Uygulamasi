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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7OMCFUUD\\SQLEXPRESS_2017;Initial Catalog=erpUyg;Integrated Security=True");

        private void bilgileriGoster(string bilgiler)
        {
            SqlDataAdapter da = new SqlDataAdapter(bilgiler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            bilgileriGoster("Select *From personeller");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From personeller where adsoyad like '%" + textBox_1ara.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personeller (bolumid,adsoyad,yas,maas) values (@bolumid1,@adsoyad1,@yas1,@maas1)", baglanti);
            komut.Parameters.AddWithValue("@bolumid1",comboBox1.SelectedIndex);
            komut.Parameters.AddWithValue("@adsoyad1", textBox2.Text);
            komut.Parameters.AddWithValue("@yas1", textBox3.Text);
            komut.Parameters.AddWithValue("@maas1", textBox4.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            bilgileriGoster("Select *From personeller"); 
        }

        private void button_prsnlsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personeller where adsoyad=@adsoyadd", baglanti);
            komut.Parameters.AddWithValue("@adsoyadd", textBox_1ara.Text);
            komut.ExecuteNonQuery();
            bilgileriGoster("Select * from personeller");
            baglanti.Close();
            textBox_1ara.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string bolumid = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string adsoyad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string yas = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string maas = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();

            comboBox1.Text = bolumid;
            textBox2.Text = adsoyad;
            textBox3.Text = yas;
            textBox4.Text = maas;

        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
                    }
    }
}
