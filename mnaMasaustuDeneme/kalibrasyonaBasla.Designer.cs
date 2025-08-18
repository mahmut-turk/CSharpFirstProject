namespace mnaMasaustuDeneme
{
    partial class formKalibrasyonaBasla
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
            this.comboBoxSonuc = new System.Windows.Forms.ComboBox();
            this.comboBoxCihazSeriNo = new System.Windows.Forms.ComboBox();
            this.comboBoxCihazlar = new System.Windows.Forms.ComboBox();
            this.comboBoxIsYerleri = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.comboBoxSehirler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUreticiFirma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonEvet = new System.Windows.Forms.RadioButton();
            this.radioButtonHayir = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxZimmerNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSonuc
            // 
            this.comboBoxSonuc.DropDownWidth = 5;
            this.comboBoxSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSonuc.FormattingEnabled = true;
            this.comboBoxSonuc.Items.AddRange(new object[] {
            "Bu cihaz kalibrasyon testini gecti.",
            "Bu cihaz kalibrasyon testini gecemedi. Teknik servise gönderilmeli."});
            this.comboBoxSonuc.Location = new System.Drawing.Point(113, 562);
            this.comboBoxSonuc.Name = "comboBoxSonuc";
            this.comboBoxSonuc.Size = new System.Drawing.Size(488, 28);
            this.comboBoxSonuc.TabIndex = 15;
            // 
            // comboBoxCihazSeriNo
            // 
            this.comboBoxCihazSeriNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCihazSeriNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCihazSeriNo.DisplayMember = "cihazserino";
            this.comboBoxCihazSeriNo.DropDownWidth = 480;
            this.comboBoxCihazSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCihazSeriNo.FormattingEnabled = true;
            this.comboBoxCihazSeriNo.Location = new System.Drawing.Point(114, 216);
            this.comboBoxCihazSeriNo.Name = "comboBoxCihazSeriNo";
            this.comboBoxCihazSeriNo.Size = new System.Drawing.Size(488, 28);
            this.comboBoxCihazSeriNo.TabIndex = 6;
            this.comboBoxCihazSeriNo.ValueMember = "cihazserino";
            // 
            // comboBoxCihazlar
            // 
            this.comboBoxCihazlar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCihazlar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCihazlar.DisplayMember = "cihazadi";
            this.comboBoxCihazlar.DropDownWidth = 480;
            this.comboBoxCihazlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCihazlar.FormattingEnabled = true;
            this.comboBoxCihazlar.Location = new System.Drawing.Point(114, 182);
            this.comboBoxCihazlar.Name = "comboBoxCihazlar";
            this.comboBoxCihazlar.Size = new System.Drawing.Size(488, 28);
            this.comboBoxCihazlar.TabIndex = 5;
            this.comboBoxCihazlar.ValueMember = "cihazadi";
            this.comboBoxCihazlar.SelectedIndexChanged += new System.EventHandler(this.comboBoxCihazlar_SelectedIndexChanged);
            // 
            // comboBoxIsYerleri
            // 
            this.comboBoxIsYerleri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxIsYerleri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxIsYerleri.DisplayMember = "IsYeriAdi";
            this.comboBoxIsYerleri.DropDownWidth = 480;
            this.comboBoxIsYerleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIsYerleri.FormattingEnabled = true;
            this.comboBoxIsYerleri.Location = new System.Drawing.Point(114, 80);
            this.comboBoxIsYerleri.Name = "comboBoxIsYerleri";
            this.comboBoxIsYerleri.Size = new System.Drawing.Size(489, 28);
            this.comboBoxIsYerleri.TabIndex = 2;
            this.comboBoxIsYerleri.ValueMember = "IsYeriAdi";
            this.comboBoxIsYerleri.SelectedIndexChanged += new System.EventHandler(this.comboBoxIsYerleri_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(115, 422);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(488, 121);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporOlustur.Location = new System.Drawing.Point(113, 608);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(250, 61);
            this.btnRaporOlustur.TabIndex = 16;
            this.btnRaporOlustur.Text = "Rapor Olustur";
            this.btnRaporOlustur.UseVisualStyleBackColor = true;
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // comboBoxSehirler
            // 
            this.comboBoxSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSehirler.DisplayMember = "Sehir";
            this.comboBoxSehirler.DropDownWidth = 480;
            this.comboBoxSehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSehirler.FormattingEnabled = true;
            this.comboBoxSehirler.Location = new System.Drawing.Point(114, 46);
            this.comboBoxSehirler.Name = "comboBoxSehirler";
            this.comboBoxSehirler.Size = new System.Drawing.Size(488, 28);
            this.comboBoxSehirler.TabIndex = 1;
            this.comboBoxSehirler.ValueMember = "Sehir";
            this.comboBoxSehirler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSehirler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Is Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cihaz :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cihaz Seri No :";
            // 
            // comboBoxUreticiFirma
            // 
            this.comboBoxUreticiFirma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUreticiFirma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUreticiFirma.DisplayMember = "cihazserino";
            this.comboBoxUreticiFirma.DropDownWidth = 480;
            this.comboBoxUreticiFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUreticiFirma.FormattingEnabled = true;
            this.comboBoxUreticiFirma.Location = new System.Drawing.Point(114, 148);
            this.comboBoxUreticiFirma.Name = "comboBoxUreticiFirma";
            this.comboBoxUreticiFirma.Size = new System.Drawing.Size(488, 28);
            this.comboBoxUreticiFirma.TabIndex = 4;
            this.comboBoxUreticiFirma.ValueMember = "cihazserino";
            this.comboBoxUreticiFirma.SelectedIndexChanged += new System.EventHandler(this.comboBoxUreticiFirma_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Uretici Firma :";
            // 
            // radioButtonEvet
            // 
            this.radioButtonEvet.AutoSize = true;
            this.radioButtonEvet.Location = new System.Drawing.Point(405, 266);
            this.radioButtonEvet.Name = "radioButtonEvet";
            this.radioButtonEvet.Size = new System.Drawing.Size(59, 24);
            this.radioButtonEvet.TabIndex = 7;
            this.radioButtonEvet.TabStop = true;
            this.radioButtonEvet.Text = "Evet";
            this.radioButtonEvet.UseVisualStyleBackColor = true;
            // 
            // radioButtonHayir
            // 
            this.radioButtonHayir.AutoSize = true;
            this.radioButtonHayir.Location = new System.Drawing.Point(488, 266);
            this.radioButtonHayir.Name = "radioButtonHayir";
            this.radioButtonHayir.Size = new System.Drawing.Size(63, 24);
            this.radioButtonHayir.TabIndex = 8;
            this.radioButtonHayir.TabStop = true;
            this.radioButtonHayir.Text = "Hayir";
            this.radioButtonHayir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Zimmer No :";
            // 
            // comboBoxZimmerNo
            // 
            this.comboBoxZimmerNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxZimmerNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxZimmerNo.DisplayMember = "IsYeriAdi";
            this.comboBoxZimmerNo.DropDownWidth = 480;
            this.comboBoxZimmerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxZimmerNo.FormattingEnabled = true;
            this.comboBoxZimmerNo.Location = new System.Drawing.Point(114, 114);
            this.comboBoxZimmerNo.Name = "comboBoxZimmerNo";
            this.comboBoxZimmerNo.Size = new System.Drawing.Size(489, 28);
            this.comboBoxZimmerNo.TabIndex = 3;
            this.comboBoxZimmerNo.ValueMember = "IsYeriAdi";
            this.comboBoxZimmerNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxZimmerNo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cihaz Prize Takiliyor mu ?";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DisplayMember = "Sehir";
            this.comboBox1.DropDownWidth = 480;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Klasse 1",
            "Klasse 2A",
            "Klasse 2B",
            "Klasse 3"});
            this.comboBox1.Location = new System.Drawing.Point(886, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(488, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Sehir";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(969, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hayir";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(886, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Evet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(785, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Cihaz Sinifi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(764, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ölcüm Teknigi :";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DisplayMember = "Sehir";
            this.comboBox2.DropDownWidth = 480;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Klasse 1",
            "Klasse 2A",
            "Klasse 2B",
            "Klasse 3"});
            this.comboBox2.Location = new System.Drawing.Point(886, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(488, 28);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "Sehir";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Elektrik Güvenlik Testleri Uygulandi mi ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Kacak Akim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "mA olarak ölcüldü.";
            // 
            // formKalibrasyonaBasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1407, 692);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxZimmerNo);
            this.Controls.Add(this.radioButtonHayir);
            this.Controls.Add(this.radioButtonEvet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxUreticiFirma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSehirler);
            this.Controls.Add(this.comboBoxSonuc);
            this.Controls.Add(this.comboBoxCihazSeriNo);
            this.Controls.Add(this.comboBoxCihazlar);
            this.Controls.Add(this.comboBoxIsYerleri);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnRaporOlustur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "formKalibrasyonaBasla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalibrasyona Başlama Sayfasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kalibrasyonaBasla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSonuc;
        public System.Windows.Forms.ComboBox comboBoxCihazSeriNo;
        public System.Windows.Forms.ComboBox comboBoxCihazlar;
        public System.Windows.Forms.ComboBox comboBoxIsYerleri;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRaporOlustur;
        public System.Windows.Forms.ComboBox comboBoxSehirler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxUreticiFirma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonEvet;
        private System.Windows.Forms.RadioButton radioButtonHayir;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBoxZimmerNo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}