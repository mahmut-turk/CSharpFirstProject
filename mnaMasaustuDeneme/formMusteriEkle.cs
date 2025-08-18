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
using Org.BouncyCastle.Pqc.Crypto.Frodo;

namespace mnaMasaustuDeneme
{
    public partial class formMusteriEkle : Form
    {
        public formMusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");
        
        private void btnMusteriyiKaydet_Click_1(object sender, EventArgs e)
        {           
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into Musteriler values(@isyeriadi, @sorumlukisi, @telefon, @adres, @postakodu, @sehir, @eyalet, @ulke, @tarih)", baglanti);          
            ekle.Parameters.AddWithValue("@isyeriadi", txtIsYeriAdi.Text);
            ekle.Parameters.AddWithValue("@sorumlukisi", txtSorumluKisi.Text);
            ekle.Parameters.AddWithValue("@telefon", txtIsYeriTelefon.Text);
            ekle.Parameters.AddWithValue("@adres", txtAdres.Text);
            ekle.Parameters.AddWithValue("@postakodu", txtPZL.Text);
            ekle.Parameters.AddWithValue("@sehir", txtSehir.Text);
            ekle.Parameters.AddWithValue("@eyalet", txtEyalet.Text);
            ekle.Parameters.AddWithValue("@ulke", txtUlke.Text);
            ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit basariyla tamamlanmistir. Girilen son kayit bilgilerini listenin en altinda bulabilirsiniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Musteriler  ", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();     
           
        }

        private void formMusteriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMusteriler f1 = (formMusteriler)Application.OpenForms["formMusteriler"];
            f1.formMusteriler_Load(null,null);
        }
    }
}
