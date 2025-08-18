using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace mnaMasaustuDeneme
{
    public partial class formSifremiUnuttum : Form
    {
        public formSifremiUnuttum()
        {
            InitializeComponent();
        }

        public static string dogrulamaKodu;
        public static TextBox txtSifremiUnuttum1;

        formSifremiUnuttumDogrulama sifremiUnuttumDogrulama;
        private void btnDogrulamaKoduGonder_Click(object sender, EventArgs e)
        {
            txtSifremiUnuttum1 = txtSifremiUnuttum;

            if(txtSifremiUnuttum.Text != "")
            {
                dogrulamaKodu = "";
                string[] k = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                {
                    dogrulamaKodu += k[random.Next(10)];
                }

                /*
                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("mahmut.kmrs.kmrs@gmail.com");   //gönderici mail adresi
                mesaj.To.Add(txtSifremiUnuttum.Text);  // alici mail adresi
                mesaj.Subject = "e-Mail Dogrulama Kodu";  // mailin konusu
                mesaj.Body = "Lütfen asagidaki kodu Dogrulama Penceresindeki Onay Kutusuna Giriniz..." + "\nDogrulama Kodu : " + dogrulamaKodu;

                SmtpClient a = new SmtpClient();
                a.Credentials = new System.Net.NetworkCredential("mahmut.kmrs.kmrs@gmail.com", "hzxqxbdcyidmepbn"); //gönderici mail adresi ve sifresi
                a.Port = 587;
                a.Host = "smtp.gmail.com";
                a.EnableSsl = true;
                object userState = mesaj;

                try
                {
                    a.SendAsync(mesaj, (object)mesaj);
                }
                catch (SmtpException)
                {
                    MessageBox.Show("e-Mail gönderilemedi, Lütfen e-Mail adresinizi ve internet baglantisini kontrol ediniz.", "Uyari !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    */

                if (sifremiUnuttumDogrulama == null || sifremiUnuttumDogrulama.IsDisposed)
                {
                    sifremiUnuttumDogrulama = new formSifremiUnuttumDogrulama();
                    sifremiUnuttumDogrulama.Show();
                }
            }
            else
            {
                MessageBox.Show("e-Mail adresi bos olamaz, Lütfen gecerli bir e-Mail adresi giriniz.", "Uyari !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            label2.Text = "dogrulama kodu : " + dogrulamaKodu;   

        }
    }
}
