using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proje_panel
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgln = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Insert into proje (username,password,repass,e_mail,phone) values ('"+txtKA.Text.ToString()+ "','" + txtPS.Text.ToString() + "'," +
                "'" + txtPSS.Text.ToString() + "','" + txtEM.Text.ToString() + "','" + txtPH.Text.ToString() + "')",bgln.baglanti());
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Kayıt Oldunuz", "PROGRAM");

        }
    }
}
