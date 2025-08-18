using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mnaMasaustuDeneme
{
    public partial class formDogrulama : Form
    {
        public formDogrulama()
        {
            InitializeComponent();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if(txtSifre.Text == "" || txtSifreTekrar.Text == "")
            {
                labelSifre.Text = "Sifre eslesmesi saglanamadi !";
                labelSifre.ForeColor = Color.Red;
            }
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    labelSifre.Text = "Sifre eslesmesi saglandi !";
                    labelSifre.ForeColor = Color.Green;             
                }
                else
                {
                    labelSifre.Text = "Sifre eslesmesi saglanamadi !";
                    labelSifre.ForeColor = Color.Red;
                }
            }           
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if(txtSifre.Text == "" || txtSifreTekrar.Text == "")
            {
                labelSifre.Text = "Sifre eslesmesi saglanamadi !";
                labelSifre.ForeColor = Color.Red;
            }
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    labelSifre.Text = "Sifre eslesmesi saglandi !";
                    labelSifre.ForeColor = Color.Green;
                }
                else
                {
                    labelSifre.Text = "Sifre eslesmesi saglanamadi !";
                    labelSifre.ForeColor = Color.Red;
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                txtSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifreTekrar.UseSystemPasswordChar = true;
            }
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        { 
            if (txtSifre.Text == "" || txtSifreTekrar.Text == "" || txtIsimSoyisim.Text == "" || txtKullanici.Text == "")
            {
                MessageBox.Show("Kullanici kaydedilemedi, Lütfen bilgileri kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    if (txtOnayKutusu.Text == formKullaniciEkle.sifre)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into kullanicilar values(@isimsoyisim, @email, @kullaniciadi, @sifre)", baglanti);
                        komut.Parameters.AddWithValue("@isimsoyisim", txtIsimSoyisim.Text);
                        komut.Parameters.AddWithValue("@email", formKullaniciEkle.txtEmail1.Text);
                        komut.Parameters.AddWithValue("@kullaniciadi", txtKullanici.Text);
                        komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kullanici kaydedildi. Sisteme giris yapabilirsiniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();                      
                    }
                    else
                    {
                        MessageBox.Show("Kullanici kaydedilemedi, Lütfen bilgileri kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Kullanici kaydedilemedi, Lütfen bilgileri kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }
    }
}
