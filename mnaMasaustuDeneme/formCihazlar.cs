using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mnaMasaustuDeneme
{
    public partial class formCihazlar : Form
    {
        public formCihazlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from cihazlar order by sonrakikalibrasyontarihi asc", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            abcKalibrationFormu form2 = (abcKalibrationFormu)Application.OpenForms["abcKalibrationFormu"];
            form2.dataGridViewABC.DataSource= tablo;
            DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
            rowColor.BackColor = Color.Tomato;
            DateTime sonrakiTarih = new DateTime();
            for (int i = 0; i < form2.dataGridViewABC.Rows.Count; i++)
            {
                sonrakiTarih = (DateTime)form2.dataGridViewABC.Rows[i].Cells[7].Value;
                TimeSpan span = sonrakiTarih.Subtract(DateTime.Today.Date);
                if (span.TotalDays < 30)
                {
                    form2.dataGridViewABC.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            form2.labelCihazSayisi.Text = "Toplam Cihaz Sayisi : " + form2.dataGridViewABC.Rows.Count.ToString();         
            baglanti.Close();
            return tablo;
        }

        DataTable yenile1()
        {
            baglanti.Open();
            string sorgu1 = "SELECT *FROM cihazlar WHERE isyeriadi=@p1";
            SqlDataAdapter adtr1 = new SqlDataAdapter(sorgu1, baglanti);
            adtr1.SelectCommand.Parameters.AddWithValue("@p1", comboBoxIsYerleri.SelectedItem);
            DataTable tablo1 = new DataTable();
            adtr1.Fill(tablo1);
            dataGridViewCihazlar.DataSource = tablo1;
            baglanti.Close();
            return tablo1;
        }

        void yenile2()
        {
            baglanti.Open();
            SqlDataAdapter adtr2 = new SqlDataAdapter("select *from cihazlar order by kalibrasyontarihi asc", baglanti);
            DataTable tablo2 = new DataTable();  
            adtr2.Fill(tablo2);
            dataGridViewCihazlar.DataSource = tablo2;
            baglanti.Close();          
        }

        void sehirler()
        {
            baglanti.Open();
            SqlCommand sehir = new SqlCommand("select distinct sehir from musteriler", baglanti);
            SqlDataReader dr = sehir.ExecuteReader();
            while (dr.Read())
            {
                comboBoxSehirler.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void formCihazlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musterilerYeniDataSet1.cihazlar' table. You can move, or remove it, as needed.
            // this.cihazlarTableAdapter.Fill(this.musterilerYeniDataSet1.cihazlar);
            sehirler();
            comboBoxIsYerleri.SelectedIndex = -1;
        }
        private void comboBoxSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIsYerleri.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriler where sehir = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBoxSehirler.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxIsYerleri.Items.Add(dr[1]);
            }
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (comboBoxIsYerleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce Is Yeri secimi yapiniz...", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }             
            else
            {
                baglanti.Open();
                string sorgu = "SELECT *FROM cihazlar WHERE isyeriadi=@p1";
                DataTable tablo = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                adapter.SelectCommand.Parameters.AddWithValue("@p1", comboBoxIsYerleri.SelectedItem);
                adapter.Fill(tablo);
                baglanti.Close();
                dataGridViewCihazlar.DataSource = tablo;              
            }          
            label7.Text = "Toplam Cihaz Sayisi : " + dataGridViewCihazlar.RowCount.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (comboBoxIsYerleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce Is Yeri secimi yapiniz...", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult secim = new DialogResult();
                secim = MessageBox.Show("Silinen veriler geri kurtarilamaz. Secilen verileri silmek istediginizden emin misiniz?", "Verilerin Silinmesi Onayi !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewCihazlar.SelectedRows.Count; i++)
                    {
                        baglanti.Open();
                        SqlCommand VeriSil = new SqlCommand("Delete from cihazlar where cihazserino=@p1", baglanti);
                        VeriSil.Parameters.AddWithValue("@p1", dataGridViewCihazlar.SelectedRows[i].Cells[5].Value.ToString());
                        VeriSil.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    MessageBox.Show("Secilen veriler basariyla silindi. Bu islem geri alinamaz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewCihazlar.DataSource = yenile1();                   
                    label7.Text = "Toplam Cihaz Sayisi : " + dataGridViewCihazlar.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Verilerin silinmesi iptal edildi.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridViewCihazlar.DataSource = yenile1();
                label7.Text = "Toplam Cihaz Sayisi : " + dataGridViewCihazlar.RowCount.ToString();
            }
            abcKalibrationFormu form2 = (abcKalibrationFormu)Application.OpenForms["abcKalibrationFormu"];
            form2.dataGridViewABC.DataSource = yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxIsYerleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce Is Yeri secimi yapiniz...", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update cihazlar set sehir=@p1, isyeriadi=@p2, zimmerno=@p3, ureticifirma=@p4, cihazadivemodeli=@p5, kalibrasyontarihi=@p7, sonrakikalibrasyontarihi=@p8 where cihazserino=@p6", baglanti);
                guncelle.Parameters.AddWithValue("@p1", comboBoxSehirler.SelectedItem);
                guncelle.Parameters.AddWithValue("@p2", comboBoxIsYerleri.SelectedItem);
                guncelle.Parameters.AddWithValue("@p3", txtZimmerNo.Text);
                guncelle.Parameters.AddWithValue("@p4", txtUreticiFirma.Text);
                guncelle.Parameters.AddWithValue("@p5", txtCihazAdiveModeli.Text);
                guncelle.Parameters.AddWithValue("@p6", txtCihazSeriNo.Text);
                guncelle.Parameters.AddWithValue("@p7", dateTimePicker.Value.Date);
                guncelle.Parameters.AddWithValue("@p8", dateTimePicker.Value.AddYears(1).Date);
               

                DialogResult secim = new DialogResult();
                secim = MessageBox.Show("Cihaz bilgilerini güncellerseniz eski veriler geri kurtarilamaz. Secilen verileri güncellemek istediginizden emin misiniz?", "Verilerin Güncellenmesi Onayi !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();
                    dataGridViewCihazlar.DataSource = yenile1();
                    MessageBox.Show("Kayit basariyla güncellenmistir.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Verilerin güncellenmesi iptal edildi.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
            }         
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxSehirler.SelectedItem = dataGridViewCihazlar.CurrentRow.Cells[0].Value.ToString();
            comboBoxIsYerleri.SelectedItem = dataGridViewCihazlar.CurrentRow.Cells[1].Value.ToString();
            txtZimmerNo.Text = dataGridViewCihazlar.CurrentRow.Cells[2].Value.ToString();
            txtUreticiFirma.Text = dataGridViewCihazlar.CurrentRow.Cells[3].Value.ToString();
            txtCihazAdiveModeli.Text = dataGridViewCihazlar.CurrentRow.Cells[4].Value.ToString();
            txtCihazSeriNo.Text = dataGridViewCihazlar.CurrentRow.Cells[5].Value.ToString();
            MessageBox.Show("Lütfen kalibrasyon tarihine dikkat ediniz ! ", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTumCihazlariGoster_Click(object sender, EventArgs e)
        {
            yenile2();
            // this.cihazlarTableAdapter.Fill(this.musterilerYeniDataSet1.cihazlar);
            label7.Text = "Toplam Cihaz Sayisi : " + dataGridViewCihazlar.RowCount.ToString();
        }

        private void btnCihazEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxIsYerleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce Is Yeri secimi yapiniz...", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into cihazlar values(@sehir, @isyeriadi, @zimmerno, @ureticifirma, @cihazadivemodeli, @cihazserino, @kalibrasyontarihi, @sonrakikalibrasyontarihi)", baglanti);
                ekle.Parameters.AddWithValue("@sehir", comboBoxSehirler.SelectedItem);
                ekle.Parameters.AddWithValue("@isyeriadi", comboBoxIsYerleri.SelectedItem);
                ekle.Parameters.AddWithValue("@zimmerno", txtZimmerNo.Text);
                ekle.Parameters.AddWithValue("@ureticifirma", txtUreticiFirma.Text);
                ekle.Parameters.AddWithValue("@cihazadivemodeli", txtCihazAdiveModeli.Text);
                ekle.Parameters.AddWithValue("@cihazserino", txtCihazSeriNo.Text);
                ekle.Parameters.AddWithValue("@kalibrasyontarihi", dateTimePicker.Value.Date);
                ekle.Parameters.AddWithValue("@sonrakikalibrasyontarihi", dateTimePicker.Value.AddYears(1).Date);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                dataGridViewCihazlar.DataSource = yenile1();
                label7.Text = "Toplam Cihaz Sayisi : " + dataGridViewCihazlar.RowCount.ToString();
                MessageBox.Show("Cihaz basariyla eklendi...", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            abcKalibrationFormu form2 = (abcKalibrationFormu)Application.OpenForms["abcKalibrationFormu"];
            //form2.dataGridViewABC.Rows.Clear();
            form2.dataGridViewABC.DataSource = yenile();
        }
    }
}
