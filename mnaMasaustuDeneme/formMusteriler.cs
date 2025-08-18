using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mnaMasaustuDeneme
{
    public partial class formMusteriler : Form
    {

        public formMusteriler()
        {
            InitializeComponent();          
        }

        formMusteriEkle musteriEkle;
        private void btnEkle_Click(object sender, EventArgs e)
        {
          
            if (musteriEkle == null || musteriEkle.IsDisposed)
            {
                musteriEkle = new formMusteriEkle();
                musteriEkle.Show();
            }
            else
                MessageBox.Show("Müsteri ekleme sayfasi zaten açık, Lütfen simge durumunu kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteriler  ", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();          
            return tablo;        
        }

        public void formMusteriler_Load(object sender, EventArgs e)
        {
            dataGridViewMusteriler.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            baglanti.Open();
          
            SqlCommand komut = new SqlCommand("select * from musteriler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(1));
                Collection.Add(dr.GetString(2));
                Collection.Add(dr.GetString(3));
                Collection.Add(dr.GetString(4));
                Collection.Add(dr.GetString(5));
                Collection.Add(dr.GetString(6));
                Collection.Add(dr.GetString(7));
                Collection.Add(dr.GetString(8));
            }

            txtAramaKutusu.AutoCompleteCustomSource = Collection;
            baglanti.Close() ;  
            dataGridViewMusteriler.DataSource = yenile();
            label2.Text = "Toplam Kayit Sayisi : " + dataGridViewMusteriler.RowCount.ToString();
        }

        frmMusteriGuncelle formMusteriGuncelle;
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (formMusteriGuncelle == null || formMusteriGuncelle.IsDisposed)
            {
                formMusteriGuncelle = new frmMusteriGuncelle();
                formMusteriGuncelle.Show();
            }
            else
                MessageBox.Show("Müsteri güncelleme sayfasi zaten açık, Lütfen simge durumunu kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            formMusteriGuncelle.txtMusteriNo.Text = dataGridViewMusteriler.CurrentRow.Cells[0].Value.ToString();
            formMusteriGuncelle.txtIsYeriAdi.Text = dataGridViewMusteriler.CurrentRow.Cells[1].Value.ToString();
            formMusteriGuncelle.txtSorumluKisi.Text = dataGridViewMusteriler.CurrentRow.Cells[2].Value.ToString();
            formMusteriGuncelle.txtIsYeriTelefon.Text = dataGridViewMusteriler.CurrentRow.Cells[3].Value.ToString();
            formMusteriGuncelle.txtAdres.Text = dataGridViewMusteriler.CurrentRow.Cells[4].Value.ToString();
            formMusteriGuncelle.txtPZL.Text = dataGridViewMusteriler.CurrentRow.Cells[5].Value.ToString();
            formMusteriGuncelle.txtSehir.Text = dataGridViewMusteriler.CurrentRow.Cells[6].Value.ToString();
            formMusteriGuncelle.txtEyalet.Text = dataGridViewMusteriler.CurrentRow.Cells[7].Value.ToString();
            formMusteriGuncelle.txtUlke.Text = dataGridViewMusteriler.CurrentRow.Cells[8].Value.ToString();          
        }
       
        private void btnTumMusterileriGoster_Click(object sender, EventArgs e)
        {
            dataGridViewMusteriler.DataSource = yenile();
            label2.Text = "Toplam Kayit Sayisi : " + dataGridViewMusteriler.RowCount.ToString();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Silinen veriler geri kurtarilamaz. Secilen verileri silmek istediginizden emin misiniz?", "Verilerin Silinmesi Onayi !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridViewMusteriler.SelectedRows.Count; i++)
                {
                    baglanti.Open();
                    SqlCommand VeriSil = new SqlCommand("Delete from musteriler where musterino=@p1", baglanti);
                    VeriSil.Parameters.AddWithValue("@p1", dataGridViewMusteriler.SelectedRows[i].Cells[0].Value.ToString());
                    VeriSil.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Secilen veriler silindi. Bu islem geri alinamaz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                dataGridViewMusteriler.DataSource = yenile();
            }
            else
            {
                MessageBox.Show("Verilerin silinmesi iptal edildi.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            label2.Text = "Toplam Kayit Sayisi : " + dataGridViewMusteriler.RowCount.ToString();
        }

        private void btnAramaGoster_Click(object sender, EventArgs e)
        {
            if(txtAramaKutusu.Text=="")
            {
                dataGridViewMusteriler.DataSource = yenile();
                label2.Text = "Toplam Kayit Sayisi : " + dataGridViewMusteriler.RowCount.ToString();
            }
            else
            {
                baglanti.Open();
                SqlDataAdapter arama = new SqlDataAdapter("select *from musteriler where isyeriadi=@p1 or sorumlukisi=@p1 or isyeritelefon=@p1 or caddevenumara=@p1 or pzl=@p1 or sehir=@p1 or eyalet=@p1 or ulke=@p1 ", baglanti);
                DataTable tablo = new DataTable();
                arama.SelectCommand.Parameters.AddWithValue("@p1", txtAramaKutusu.Text);
                arama.Fill(tablo);
                dataGridViewMusteriler.DataSource = tablo;
                baglanti.Close();
            }
            label2.Text = "Toplam Kayit Sayisi : " + dataGridViewMusteriler.RowCount.ToString();
        }
    }
}
