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

namespace Proje_panel
{
    public partial class GirisPanel : Form
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=CENGIZHAN\\SQLEXPRESS; Initial Catalog=master; Integrated Security=TRUE");
        public GirisPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Silver;
            }
        }
        bool isThere;
        private void button2_Click(object sender, EventArgs e)
        {
            String kullaniciadi = textBox1.Text;
            String sifre = textBox2.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from proje", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (kullaniciadi == reader["username"].ToString() && sifre==reader["password"].ToString())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            baglanti.Close();
            if (isThere == true)
            {
                MessageBox.Show("Başarıyla giriş yaptınız !", "Program");
            }
            else
            {
                MessageBox.Show("Hatalı giriş !", "Program");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifremiUnuttum sifremiunuttum = new SifremiUnuttum();
            sifremiunuttum.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            KayitOl kayitol = new KayitOl();
            kayitol.Show();
        }
    }
}
    

