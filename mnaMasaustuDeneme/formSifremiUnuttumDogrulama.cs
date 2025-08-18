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

namespace mnaMasaustuDeneme
{
    public partial class formSifremiUnuttumDogrulama : Form
    {
        public formSifremiUnuttumDogrulama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MN-Mahmut;Initial Catalog=musterilerYeni;Integrated Security=True");

        private void btnKoduDogrula_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from kullanicilar where email=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", formSifremiUnuttum.txtSifremiUnuttum1.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if(textBox1.Text == formSifremiUnuttum.dogrulamaKodu)
            {
                while (dr.Read())
                {
                    label2.Text = "Kullanici Adi : " + dr[2].ToString();
                    label3.Text = "Sifre : " + dr[3].ToString();
                    label4.Text = "Personel Adi ve Soyadi : " + dr[0].ToString();
                }
            }

            baglanti.Close();
        }
    }
}
