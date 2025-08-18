using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace mnaMasaustuDeneme
{
    public partial class formKalibrasyonaBasla : Form
    {
        public formKalibrasyonaBasla()
        {
            InitializeComponent();
        }
        public static string dosyaYolu = @"C:\Users\mahmu\Desktop";
        public static StreamReader sr = new StreamReader(dosyaYolu + "\\sayac.txt");
        public static int i = Convert.ToInt32(sr.ReadLine());
        public string isimsoyisim;

        private void kalibrasyonaBasla_Load(object sender, EventArgs e)
        {
            sehirler();
            comboBoxSehirler.SelectedIndex = -1;     
            comboBoxIsYerleri.SelectedIndex = -1;
            comboBoxZimmerNo.SelectedIndex = -1;
            comboBoxCihazlar.SelectedIndex = -1;
            comboBoxCihazSeriNo.SelectedIndex = -1;
            comboBoxSonuc.Text = "Lütfen Kalibrasyon Sonucunu Seciniz...";
            // comboBoxSonuc.Width = 500;
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            sr.Close();
            iTextSharp.text.Document mahmutPDF = new iTextSharp.text.Document();

            PdfWriter.GetInstance(mahmutPDF, new FileStream(dosyaYolu + "\\Son Rapor.pdf", FileMode.Create));
            mahmutPDF.Open();

            // sütun eklemem lazim

            iTextSharp.text.Image imza = iTextSharp.text.Image.GetInstance(dosyaYolu + "\\Bild11.png");
            imza.ScalePercent(30);
            imza.Alignment = 1;
            // imza.ScaleToFit(300,100);
            mahmutPDF.Add(imza);
            mahmutPDF.AddCreationDate();
            Paragraph eklenecekMetin = new Paragraph(richTextBox1.Text);
            mahmutPDF.Add(new Paragraph("Kalibrasyonu Yapan Firma : ABC Kalibrasyon"));
            mahmutPDF.Add(new Paragraph("Kalibrasyon Tarihi : " + DateTime.Now.ToShortDateString())); // tarihe saat eklemez
            //mahmutPDF.Add(new Paragraph("Kalibrasyon Tarihi : " + DateTime.Now.ToString("g")));   // tarihe saati saat ve dakika olarak saniyesiz olarak ekler
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select isimsoyisim from kullanicilar where kullaniciadi=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", acilisFormu.textBoxKullaniciAdi1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                isimsoyisim = dr[0].ToString();
            }
            baglanti.Close();

            mahmutPDF.Add(new Paragraph("kalibrasyon personeli : " + isimsoyisim));
            mahmutPDF.Add(new Paragraph("Sehir : " + comboBoxSehirler.SelectedItem));
            //mahmutPDF.Add(new Paragraph("sehir : " + abcKalibrationFormu.secilenSehir.ToString()));  public static string secilenSehir ; tanimlamasi yapilmali
            mahmutPDF.Add(new Paragraph("Is Yeri : " + comboBoxIsYerleri.SelectedItem));
            mahmutPDF.Add(new Paragraph("Cihaz Adi ve Modeli : " + comboBoxCihazlar.SelectedItem));
            mahmutPDF.Add(new Paragraph("Cihaz Seri No : " + comboBoxCihazSeriNo.SelectedItem));
            if(radioButtonEvet.Checked)
            {
                mahmutPDF.Add(new Paragraph("Kacak akim testi uygulandi mi? : " + radioButtonEvet.Text));
            }
            if (radioButtonHayir.Checked)
            {
                mahmutPDF.Add(new Paragraph("Kacak akim testi uygulandi mi? : " + radioButtonHayir.Text));
            }
            mahmutPDF.Add(new Paragraph("\n\n" + "Eklenmesi Gereken Notlar : \n"));
            mahmutPDF.Add(eklenecekMetin);
            mahmutPDF.Add(new Paragraph("\n\n"));
            mahmutPDF.Add(new Paragraph("Kalibrasyon Sonucu : " + comboBoxSonuc.SelectedItem));
            StreamWriter sw = new StreamWriter(dosyaYolu + "\\sayac.txt");
            i = i + 1;
            sw.WriteLine(i);
            sw.Close();
            if (comboBoxSonuc.SelectedIndex == 0)
            {
                DateTime sonrakiKalibrasyon = new DateTime();
                sonrakiKalibrasyon = DateTime.Now.AddYears(1);
                mahmutPDF.Add(new Paragraph("Sonraki Kalibrasyon Tarihi : " + sonrakiKalibrasyon.ToShortDateString()));
            }
            else
            {
                mahmutPDF.Add(new Paragraph("Sonraki Kalibrasyon Tarihi : Bu cihaz kalibrasyonu gectiginde sonraki kalibrasyon tarihi verilecektir.\n"));
                // i=i-1;  // eger cihaz kalibrasyondan gecemezse ucret yine de aliniyorsa bu kod silinecek, ucret alinmiyorsa bu kod kalacak
            }
            mahmutPDF.Add(new Paragraph("Alinan Rapor Sayisi : " + i));
            mahmutPDF.Close();
            MessageBox.Show("Raporunuz masaüstüne olusturulmustur.", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        void sehirler()
        {
            baglanti.Open();
            SqlCommand sehir = new SqlCommand("select distinct sehir from Musteriler", baglanti);  
            SqlDataReader dr = sehir.ExecuteReader();
            while (dr.Read())
            {
                comboBoxSehirler.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void comboBoxSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIsYerleri.Items.Clear();
            comboBoxIsYerleri.Text = "";
            comboBoxZimmerNo.Items.Clear();
            comboBoxZimmerNo.Text = "";
            comboBoxUreticiFirma.Items.Clear();
            comboBoxUreticiFirma.Text = "";
            comboBoxCihazlar.Items.Clear();
            comboBoxCihazlar.Text = "";
            comboBoxCihazSeriNo.Items.Clear();
            comboBoxCihazSeriNo.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct isyeriadi from cihazlar where sehir = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBoxSehirler.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxIsYerleri.Items.Add(dr[0]);
            }
            baglanti.Close();

        }

        private void comboBoxIsYerleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxZimmerNo.Items.Clear();
            comboBoxZimmerNo.Text = "";
            comboBoxUreticiFirma.Items.Clear();
            comboBoxUreticiFirma.Text = "";
            comboBoxCihazlar.Items.Clear();
            comboBoxCihazlar.Text = "";
            comboBoxCihazSeriNo.Items.Clear();
            comboBoxCihazSeriNo.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct zimmerno from cihazlar where isyeriadi=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBoxIsYerleri.SelectedItem);   
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            { 
                comboBoxZimmerNo.Items.Add(dr[0]);
            }
            baglanti.Close();

        }
        private void comboBoxZimmerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUreticiFirma.Items.Clear();
            comboBoxUreticiFirma.Text = "";
            comboBoxCihazlar.Items.Clear();
            comboBoxCihazlar.Text = "";
            comboBoxCihazSeriNo.Items.Clear();
            comboBoxCihazSeriNo.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct ureticifirma from cihazlar where isyeriadi=@p1 and zimmerno=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBoxIsYerleri.SelectedItem);
            komut.Parameters.AddWithValue("@p2", comboBoxZimmerNo.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxUreticiFirma.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void comboBoxUreticiFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCihazlar.Items.Clear();
            comboBoxCihazlar.Text = "";
            comboBoxCihazSeriNo.Items.Clear();
            comboBoxCihazSeriNo.Text = "";
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct cihazadivemodeli from cihazlar where isyeriadi=@p1 and zimmerno=@p2 and ureticifirma=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBoxIsYerleri.SelectedItem);
            komut.Parameters.AddWithValue("@p2", comboBoxZimmerNo.SelectedItem);
            komut.Parameters.AddWithValue("@p3", comboBoxUreticiFirma.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCihazlar.Items.Add(dr[0]);
            }
            baglanti.Close();
           
        }

        private void comboBoxCihazlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCihazSeriNo.Items.Clear();
            comboBoxCihazSeriNo.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from cihazlar where isyeriadi=@p1 and zimmerno=@p2 and ureticifirma=@p3 and cihazadivemodeli=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBoxIsYerleri.SelectedItem);
            komut.Parameters.AddWithValue("@p2", comboBoxZimmerNo.SelectedItem);
            komut.Parameters.AddWithValue("@p3", comboBoxUreticiFirma.SelectedItem);
            komut.Parameters.AddWithValue("@p4", comboBoxCihazlar.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCihazSeriNo.Items.Add(dr[5]);
            }
            baglanti.Close();  
        }
    }
}
