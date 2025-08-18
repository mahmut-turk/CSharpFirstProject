namespace mnaMasaustuDeneme
{
    partial class formDogrulama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKullaniciKaydet = new System.Windows.Forms.Button();
            this.txtOnayKutusu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtIsimSoyisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKullaniciKaydet
            // 
            this.btnKullaniciKaydet.Location = new System.Drawing.Point(278, 361);
            this.btnKullaniciKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            this.btnKullaniciKaydet.Size = new System.Drawing.Size(185, 46);
            this.btnKullaniciKaydet.TabIndex = 0;
            this.btnKullaniciKaydet.Text = "Kullaniciyi Kaydet";
            this.btnKullaniciKaydet.UseVisualStyleBackColor = true;
            this.btnKullaniciKaydet.Click += new System.EventHandler(this.btnKullaniciKaydet_Click);
            // 
            // txtOnayKutusu
            // 
            this.txtOnayKutusu.Location = new System.Drawing.Point(278, 308);
            this.txtOnayKutusu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnayKutusu.Name = "txtOnayKutusu";
            this.txtOnayKutusu.Size = new System.Drawing.Size(295, 26);
            this.txtOnayKutusu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dogrulama Kodunu Giriniz : *";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(588, 210);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(134, 24);
            this.checkBox.TabIndex = 19;
            this.checkBox.Text = "Sifreleri Göster";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(594, 265);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(0, 20);
            this.labelSifre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sifre Tekrar : *";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(278, 258);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(295, 26);
            this.txtSifreTekrar.TabIndex = 16;
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sifre : *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kullanici Adi : *";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(278, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(295, 26);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(278, 158);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(295, 26);
            this.txtKullanici.TabIndex = 11;
            // 
            // txtIsimSoyisim
            // 
            this.txtIsimSoyisim.Location = new System.Drawing.Point(278, 108);
            this.txtIsimSoyisim.Name = "txtIsimSoyisim";
            this.txtIsimSoyisim.Size = new System.Drawing.Size(295, 26);
            this.txtIsimSoyisim.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Isim Soyisim : *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "* Doldurulmasi zorunlu alanlar";
            // 
            // formDogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(844, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIsimSoyisim);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOnayKutusu);
            this.Controls.Add(this.btnKullaniciKaydet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "formDogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogrulama Penceresi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnKullaniciKaydet;
        public System.Windows.Forms.TextBox txtOnayKutusu;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.TextBox txtKullanici;
        public System.Windows.Forms.TextBox txtIsimSoyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}