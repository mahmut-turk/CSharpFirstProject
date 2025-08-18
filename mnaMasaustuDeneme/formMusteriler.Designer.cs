namespace mnaMasaustuDeneme
{
    partial class formMusteriler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMusteriler));
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isYeriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorumluKisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isYeriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caddeveNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pZLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eyaletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklenmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeniMusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerYeniDataSet = new mnaMasaustuDeneme.musterilerYeniDataSet();
            this.btnTumMusterileriGoster = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniMusterilerTableAdapter = new mnaMasaustuDeneme.musterilerYeniDataSetTableAdapters.yeniMusterilerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaKutusu = new System.Windows.Forms.TextBox();
            this.btnAramaGoster = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniMusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerYeniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AllowUserToAddRows = false;
            this.dataGridViewMusteriler.AllowUserToDeleteRows = false;
            this.dataGridViewMusteriler.AutoGenerateColumns = false;
            this.dataGridViewMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewMusteriler.ColumnHeadersHeight = 40;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriNoDataGridViewTextBoxColumn,
            this.isYeriAdiDataGridViewTextBoxColumn,
            this.sorumluKisiDataGridViewTextBoxColumn,
            this.isYeriTelefonDataGridViewTextBoxColumn,
            this.caddeveNumaraDataGridViewTextBoxColumn,
            this.pZLDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.eyaletDataGridViewTextBoxColumn,
            this.ulkeDataGridViewTextBoxColumn,
            this.eklenmeTarihiDataGridViewTextBoxColumn});
            this.dataGridViewMusteriler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridViewMusteriler.DataSource = this.yeniMusterilerBindingSource;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMusteriler.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewMusteriler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMusteriler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(0, 212);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.ReadOnly = true;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusteriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewMusteriler.RowHeadersVisible = false;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMusteriler.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(1722, 640);
            this.dataGridViewMusteriler.TabIndex = 42;
            this.dataGridViewMusteriler.VirtualMode = true;
            this.dataGridViewMusteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // musteriNoDataGridViewTextBoxColumn
            // 
            this.musteriNoDataGridViewTextBoxColumn.DataPropertyName = "MusteriNo";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriNoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.musteriNoDataGridViewTextBoxColumn.HeaderText = "Müşteri No";
            this.musteriNoDataGridViewTextBoxColumn.Name = "musteriNoDataGridViewTextBoxColumn";
            this.musteriNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isYeriAdiDataGridViewTextBoxColumn
            // 
            this.isYeriAdiDataGridViewTextBoxColumn.DataPropertyName = "IsYeriAdi";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isYeriAdiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.isYeriAdiDataGridViewTextBoxColumn.HeaderText = "İş Yeri Adı";
            this.isYeriAdiDataGridViewTextBoxColumn.Name = "isYeriAdiDataGridViewTextBoxColumn";
            this.isYeriAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sorumluKisiDataGridViewTextBoxColumn
            // 
            this.sorumluKisiDataGridViewTextBoxColumn.DataPropertyName = "SorumluKisi";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorumluKisiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.sorumluKisiDataGridViewTextBoxColumn.HeaderText = "Sorumlu Kişi";
            this.sorumluKisiDataGridViewTextBoxColumn.Name = "sorumluKisiDataGridViewTextBoxColumn";
            this.sorumluKisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isYeriTelefonDataGridViewTextBoxColumn
            // 
            this.isYeriTelefonDataGridViewTextBoxColumn.DataPropertyName = "IsYeriTelefon";
            this.isYeriTelefonDataGridViewTextBoxColumn.HeaderText = "İş Yeri Telefon";
            this.isYeriTelefonDataGridViewTextBoxColumn.Name = "isYeriTelefonDataGridViewTextBoxColumn";
            this.isYeriTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caddeveNumaraDataGridViewTextBoxColumn
            // 
            this.caddeveNumaraDataGridViewTextBoxColumn.DataPropertyName = "CaddeveNumara";
            this.caddeveNumaraDataGridViewTextBoxColumn.HeaderText = "Cadde ve Numara";
            this.caddeveNumaraDataGridViewTextBoxColumn.Name = "caddeveNumaraDataGridViewTextBoxColumn";
            this.caddeveNumaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pZLDataGridViewTextBoxColumn
            // 
            this.pZLDataGridViewTextBoxColumn.DataPropertyName = "PZL";
            this.pZLDataGridViewTextBoxColumn.HeaderText = "PZL";
            this.pZLDataGridViewTextBoxColumn.Name = "pZLDataGridViewTextBoxColumn";
            this.pZLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Şehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eyaletDataGridViewTextBoxColumn
            // 
            this.eyaletDataGridViewTextBoxColumn.DataPropertyName = "Eyalet";
            this.eyaletDataGridViewTextBoxColumn.HeaderText = "Eyalet";
            this.eyaletDataGridViewTextBoxColumn.Name = "eyaletDataGridViewTextBoxColumn";
            this.eyaletDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulkeDataGridViewTextBoxColumn
            // 
            this.ulkeDataGridViewTextBoxColumn.DataPropertyName = "Ulke";
            this.ulkeDataGridViewTextBoxColumn.HeaderText = "Ülke";
            this.ulkeDataGridViewTextBoxColumn.Name = "ulkeDataGridViewTextBoxColumn";
            this.ulkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eklenmeTarihiDataGridViewTextBoxColumn
            // 
            this.eklenmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "EklenmeTarihi";
            this.eklenmeTarihiDataGridViewTextBoxColumn.HeaderText = "Eklenme Tarihi";
            this.eklenmeTarihiDataGridViewTextBoxColumn.Name = "eklenmeTarihiDataGridViewTextBoxColumn";
            this.eklenmeTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yeniMusterilerBindingSource
            // 
            this.yeniMusterilerBindingSource.DataMember = "yeniMusteriler";
            this.yeniMusterilerBindingSource.DataSource = this.musterilerYeniDataSet;
            // 
            // musterilerYeniDataSet
            // 
            this.musterilerYeniDataSet.DataSetName = "musterilerYeniDataSet";
            this.musterilerYeniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTumMusterileriGoster
            // 
            this.btnTumMusterileriGoster.BackColor = System.Drawing.Color.White;
            this.btnTumMusterileriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTumMusterileriGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnTumMusterileriGoster.Image")));
            this.btnTumMusterileriGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTumMusterileriGoster.Location = new System.Drawing.Point(321, 12);
            this.btnTumMusterileriGoster.Name = "btnTumMusterileriGoster";
            this.btnTumMusterileriGoster.Size = new System.Drawing.Size(262, 70);
            this.btnTumMusterileriGoster.TabIndex = 10;
            this.btnTumMusterileriGoster.Text = "Tüm Müşterileri Göster";
            this.btnTumMusterileriGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumMusterileriGoster.UseVisualStyleBackColor = false;
            this.btnTumMusterileriGoster.Click += new System.EventHandler(this.btnTumMusterileriGoster_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Image = global::mnaMasaustuDeneme.Properties.Resources.sil11;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(616, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(255, 70);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(30, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(255, 70);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "  Müşteri Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 100);
            this.label1.TabIndex = 43;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // yeniMusterilerTableAdapter
            // 
            this.yeniMusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(1650, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Toplam Kayit Sayisi : ";
            // 
            // txtAramaKutusu
            // 
            this.txtAramaKutusu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAramaKutusu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAramaKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAramaKutusu.Location = new System.Drawing.Point(174, 379);
            this.txtAramaKutusu.Name = "txtAramaKutusu";
            this.txtAramaKutusu.Size = new System.Drawing.Size(409, 26);
            this.txtAramaKutusu.TabIndex = 46;
            this.txtAramaKutusu.TextAlignChanged += new System.EventHandler(this.btnTumMusterileriGoster_Click);
            this.txtAramaKutusu.TextChanged += new System.EventHandler(this.btnAramaGoster_Click);
            this.txtAramaKutusu.Enter += new System.EventHandler(this.btnAramaGoster_Click);
            // 
            // btnAramaGoster
            // 
            this.btnAramaGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAramaGoster.Location = new System.Drawing.Point(616, 335);
            this.btnAramaGoster.Name = "btnAramaGoster";
            this.btnAramaGoster.Size = new System.Drawing.Size(255, 70);
            this.btnAramaGoster.TabIndex = 47;
            this.btnAramaGoster.Text = "Arama Sonucunu Göster";
            this.btnAramaGoster.UseVisualStyleBackColor = true;
            this.btnAramaGoster.Enter += new System.EventHandler(this.btnAramaGoster_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Arama Kutusu :";
            // 
            // formMusteriler
            // 
            this.AccessibleName = "formMusterilerName";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1722, 852);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAramaGoster);
            this.Controls.Add(this.txtAramaKutusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMusteriler);
            this.Controls.Add(this.btnTumMusterileriGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "formMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Müsteriler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniMusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerYeniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewMusteriler;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnTumMusterileriGoster;
        public System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private musterilerYeniDataSet musterilerYeniDataSet;
        private System.Windows.Forms.BindingSource yeniMusterilerBindingSource;
        private musterilerYeniDataSetTableAdapters.yeniMusterilerTableAdapter yeniMusterilerTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaKutusu;
        private System.Windows.Forms.Button btnAramaGoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorumluKisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caddeveNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pZLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eyaletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eklenmeTarihiDataGridViewTextBoxColumn;
    }
}