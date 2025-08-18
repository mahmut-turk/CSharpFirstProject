using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.interfaces;
using Org.BouncyCastle.Crypto.Prng;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mnaMasaustuDeneme
{
    
    public partial class abcKalibrationFormu : Form
    {
        public abcKalibrationFormu()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            formMusteriler formMusteriler = new formMusteriler();
            formMusteriler.ShowDialog();
        }

        formSorunBildir formSorunBildir;
        private void btnSorunBildir_Click(object sender, EventArgs e)
        {
            if(formSorunBildir == null || formSorunBildir.IsDisposed)
            {
                formSorunBildir = new formSorunBildir();
                formSorunBildir.Show();
            }
            else
                MessageBox.Show("Sorun bildirme platformu zaten açık, Lütfen simge durumunu kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        formKalibrasyonaBasla formKalibrasyonaBasla;
        private void btnKalibrasyonaBasla_Click(object sender, EventArgs e)
        {   
           if(formKalibrasyonaBasla == null || formKalibrasyonaBasla.IsDisposed)
            {
                formKalibrasyonaBasla = new formKalibrasyonaBasla();
                formKalibrasyonaBasla.Show();
            }
            else
                MessageBox.Show("Kalibrasyona baslama sayfasi zaten açık, Lütfen simge durumunu kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }
        
        public DataTable yenile2()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from cihazlar order by sonrakikalibrasyontarihi asc", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridViewABC.DataSource = tablo;
            baglanti.Close();
            return tablo;
        }  

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        private void abcKalibrationFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musterilerYeniDataSet2.cihazlar' table. You can move, or remove it, as needed.
            this.cihazlarTableAdapter.Fill(this.musterilerYeniDataSet2.cihazlar);

            /* baglanti.Open();
             SqlCommand komut = new SqlCommand("select sehir, IsYeriAdi, ureticifirma, cihazadivemodeli, cihazserino, kalibrasyontarihi, sonrakikalibrasyontarihi from cihazlar order by sonrakikalibrasyontarihi asc", baglanti);
             SqlDataReader dr = komut.ExecuteReader(); 
             while (dr.Read())
             {
                 dataGridViewABC.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);      
             }
             baglanti.Close(); */

            dataGridViewABC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewABC.DataSource = yenile2();
            DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
            rowColor.BackColor = Color.Tomato;
            DateTime sonrakiTarih = new DateTime();
            for (int i =0; i < dataGridViewABC.Rows.Count;i++)
            {
                sonrakiTarih = (DateTime)dataGridViewABC.Rows[i].Cells[7].Value;
                TimeSpan span = sonrakiTarih.Subtract(DateTime.Today.Date);
                if(span.TotalDays < 30)
                {
                    dataGridViewABC.Rows[i].DefaultCellStyle=rowColor;
                }
            }       
            labelCihazSayisi.Text= "Toplam Cihaz Sayisi : " + dataGridViewABC.Rows.Count.ToString();
        }

        formCihazlar formCihazlar;
        private void btnCihazlar_Click(object sender, EventArgs e)
        {
            if(formCihazlar == null || formCihazlar.IsDisposed)
            {
                formCihazlar = new formCihazlar();
                formCihazlar.Show();
            }
            else
                MessageBox.Show("Cihazlar sayfasi zaten açık, Lütfen simge durumunu kontrol ediniz.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
