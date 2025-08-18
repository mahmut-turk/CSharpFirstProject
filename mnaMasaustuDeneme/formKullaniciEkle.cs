using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;


namespace mnaMasaustuDeneme
{
    
    public partial class formKullaniciEkle : Form
    {
        
        public formKullaniciEkle()
        {
            InitializeComponent();
        }

        public static string sifre;
        public static TextBox txtEmail1;
        
        formDogrulama dogrulama;
        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            txtEmail1 = txtEmail;
            if(txtEmail.Text != "")
            {
                sifre = "";
                string[] k = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                {
                    sifre += k[random.Next(10)];
                }

                label2.Text = sifre;


               /*

                 MailMessage mesaj = new MailMessage();
                 mesaj.From = new MailAddress("mahmut.kmrs.kmrs@gmail.com");   //gönderici mail adresi
                 mesaj.To.Add(txtEmail.Text);  // alici mail adresi
                 mesaj.Subject = "e-Mail Dogrulama Kodu";  // mailin konusu
                 mesaj.Body = "Lütfen asagidaki kodu Dogrulama Penceresindeki Onay Kutusuna Giriniz..."  + "\nDogrulama Kodu : " + sifre;

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
                }

                */

                if (dogrulama == null || dogrulama.IsDisposed)
                {
                    dogrulama = new formDogrulama();
                    dogrulama.Show();
                }
            }
            else
            {
                MessageBox.Show("e-Mail adresi bos olamaz, Lütfen gecerli bir e-Mail adresi giriniz.", "Uyari !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }
    }
}
