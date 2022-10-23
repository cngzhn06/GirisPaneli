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
using System.Net;
using System.Net.Mail;

namespace Proje_panel
{
    public partial class SifremiUnuttum : Form
    {
        
        public SifremiUnuttum()
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
            
            SqlCommand komut = new SqlCommand("Select * From proje where username='" + textBox1.Text.ToString() + "' and e_mail='" + textBox2.Text.ToString()
                + "'", bgln.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                sendMail(oku);
        
             
            }
            
        }


        public void sendMail(SqlDataReader oku)
        {


            try
            {
                   String mesaj = "Merhaba, sistemde kayıtlı olan şifreniz; " + "<br><strong>" + oku["password"].ToString() + "</strong><br><br><h3>CENGİZHAN ÇALIŞKAN</h3> ";
            SmtpClient client = new SmtpClient();
            client.Port = 587; 
            client.Host = "smtp.office365.com"; // Hostunuzun smtp için mail domaini.
            client.EnableSsl = true; // Güvenlik ayarları, host'a ve gönderilen server'a göre değişebilir.
            client.Timeout = 10000; // Milisaniye cinsten timeout
            client.DeliveryMethod = SmtpDeliveryMethod.Network; // Mailin yollanma methodu
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("hccoptikaraclar@outlook.com.tr", "1085500c"); // Burada hangi hesabı kullanarak mail yollayacaksanız onun ayarlarını yapmanız gerekiyor
            MailMessage mm = new MailMessage("hccoptikaraclar@outlook.com.tr", oku["e_mail"].ToString(), "Şifre Yenileme",mesaj); // Hangi mail adresinden nereye, konu ve içerik mail ayarlarını yapabilirsiniz
            mm.IsBodyHtml = true; // True: Html olarak Gönderme, False: Text olarak Gönderme
            mm.BodyEncoding = UTF8Encoding.UTF8; // UTF8 encoding ayarı
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; // Hata olduğunda uyarı ver 
            client.Send(mm); // Mail yolla
                MessageBox.Show("Mail kutunuzu kontrol ediniz", "PROGRAM");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex);
            }
            

        }
    }
}
