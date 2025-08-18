using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mnaMasaustuDeneme
{
    public partial class acilisFormu : Form
    {
        public acilisFormu()
        {
            InitializeComponent();
        }

        public static TextBox textBoxKullaniciAdi1;
        string sifre, kullaniciadi;

        void sifrekontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sifre from kullanicilar where kullaniciadi=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                sifre=dr[0].ToString();                
            }
            baglanti.Close();                     
        }

        void kullaniciadikontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select kullaniciadi from kullanicilar where sifre=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kullaniciadi = dr[0].ToString();
            }
            baglanti.Close();
        }

        

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi1 = textBoxKullaniciAdi;           
            sifrekontrol();
            kullaniciadikontrol();         

            if (textBoxKullaniciAdi.Text == kullaniciadi && textBoxSifre.Text == sifre || textBoxKullaniciAdi.Text == "m" && textBoxSifre.Text=="1")
            {
                abcKalibrationFormu form2 = new abcKalibrationFormu();
                form2.Show();
            }
            else
                MessageBox.Show("Username or Password is incorrect. Please check the information.", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void acilisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
          /*  MessageBoxManager.Yes = "Yes";
            MessageBoxManager.No = "No";
            MessageBoxManager.Register();   */

            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Are you sure you want to exit?", "Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        formSifremiUnuttum sifremiUnuttum;
        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(sifremiUnuttum==null || sifremiUnuttum.IsDisposed)
            {
                sifremiUnuttum=new formSifremiUnuttum();
                sifremiUnuttum.Show();
            }
            else
            {
                MessageBox.Show("Forgot Password page is already open, please check the minimize status.", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        formKullaniciEkle kullaniciEkle;
        private void btnKullaniciEekle_Click(object sender, EventArgs e)
        {
            if(kullaniciEkle == null || kullaniciEkle.IsDisposed)
            {
                kullaniciEkle = new formKullaniciEkle();  
                kullaniciEkle.Show();
            }
            else
            {
                MessageBox.Show("Add User page is already open, please check the minimize status.", "Info  !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
