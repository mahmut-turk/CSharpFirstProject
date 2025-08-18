using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mnaMasaustuDeneme
{
    public partial class formSorunBildir : Form
    {
        
        public formSorunBildir()
        {
            InitializeComponent();
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSorunuGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("mahmut.kmrs.kmrs@gmail.com");   //gönderici mail adresi
            mesaj.To.Add("mturk464646@gmail.com");  // alici mail adresi
            mesaj.Subject = "ABC Kalibrasyon Sorun Bildirimi -  " + textBoxKonu.Text;  // mailin konusu
            mesaj.Body = richTextBoxSorunBilgileri.Text;  // mailin kendisi yani mailin icerigi

            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("mahmut.kmrs.kmrs@gmail.com", "hzxqxbdcyidmepbn"); //gönderici mail adresi ve sifresi
            a.Port = 587;
            a.Host = "smtp.gmail.com";
            a.EnableSsl = true;
            object userState = mesaj;

            try
            {
                a.SendAsync(mesaj, (object)mesaj);
                MessageBox.Show("Sorun Bildirilmiştir", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SmtpException)
            {
                MessageBox.Show("Sorun Bildirme Hatasi", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
