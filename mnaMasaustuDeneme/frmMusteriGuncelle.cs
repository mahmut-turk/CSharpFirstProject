using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mnaMasaustuDeneme
{
    public partial class frmMusteriGuncelle : Form
    {
        public frmMusteriGuncelle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();              
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        private void btnMusteriyiGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update Musteriler set isyeriadi=@p1, sorumlukisi=@p2, isyeritelefon=@p3, caddevenumara=@p4, PZL=@p5, Sehir=@p6, Eyalet=@p7, Ulke=@p8 where musterino=@p9";
            SqlCommand guncelle = new SqlCommand(kayit, baglanti);
            guncelle.Parameters.AddWithValue("@p1", txtIsYeriAdi.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSorumluKisi.Text);
            guncelle.Parameters.AddWithValue("@p3", txtIsYeriTelefon.Text);
            guncelle.Parameters.AddWithValue("@p4", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@p5", txtPZL.Text);
            guncelle.Parameters.AddWithValue("@p6", txtSehir.Text);
            guncelle.Parameters.AddWithValue("@p7", txtEyalet.Text);
            guncelle.Parameters.AddWithValue("@p8", txtUlke.Text);
            guncelle.Parameters.AddWithValue("@p9", txtMusteriNo.Text);
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Güncellerseniz eski veriler geri kurtarilamaz. Secilen verileri güncellemek istediginizden emin misiniz?", "Verilerin Güncellenmesi Onayi !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Kayit basariyla güncellenmistir.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else           
                MessageBox.Show("Verilerin güncellenmesi iptal edildi.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            baglanti.Close();         
            this.Close();         
        }

        private void frmMusteriGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMusteriler f2 = (formMusteriler)Application.OpenForms["formMusteriler"];
            f2.formMusteriler_Load(null, null);
        }
    }
}
