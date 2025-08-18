namespace mnaMasaustuDeneme
{
    partial class abcKalibrationFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnKalibrasyonaBasla = new System.Windows.Forms.Button();
            this.btnSorunBildir = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnCihazlar = new System.Windows.Forms.Button();
            this.dataGridViewABC = new System.Windows.Forms.DataGridView();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isyeriadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zimmernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ureticifirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazadivemodeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazserinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalibrasyontarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerYeniDataSet2 = new mnaMasaustuDeneme.musterilerYeniDataSet2();
            this.labelCihazSayisi = new System.Windows.Forms.Label();
            this.cihazlarTableAdapter = new mnaMasaustuDeneme.musterilerYeniDataSet2TableAdapters.cihazlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewABC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cihazlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerYeniDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Tomato;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Location = new System.Drawing.Point(1640, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(250, 80);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.White;
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRaporlar.Location = new System.Drawing.Point(998, 12);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(250, 80);
            this.btnRaporlar.TabIndex = 14;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            // 
            // btnKalibrasyonaBasla
            // 
            this.btnKalibrasyonaBasla.BackColor = System.Drawing.Color.White;
            this.btnKalibrasyonaBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKalibrasyonaBasla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKalibrasyonaBasla.Location = new System.Drawing.Point(673, 12);
            this.btnKalibrasyonaBasla.Name = "btnKalibrasyonaBasla";
            this.btnKalibrasyonaBasla.Size = new System.Drawing.Size(250, 80);
            this.btnKalibrasyonaBasla.TabIndex = 15;
            this.btnKalibrasyonaBasla.Text = "Kalibrasyona Basla ";
            this.btnKalibrasyonaBasla.UseVisualStyleBackColor = false;
            this.btnKalibrasyonaBasla.Click += new System.EventHandler(this.btnKalibrasyonaBasla_Click);
            // 
            // btnSorunBildir
            // 
            this.btnSorunBildir.BackColor = System.Drawing.Color.White;
            this.btnSorunBildir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorunBildir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSorunBildir.Location = new System.Drawing.Point(1323, 12);
            this.btnSorunBildir.Name = "btnSorunBildir";
            this.btnSorunBildir.Size = new System.Drawing.Size(250, 80);
            this.btnSorunBildir.TabIndex = 16;
            this.btnSorunBildir.Text = "Sorun Bildir";
            this.btnSorunBildir.UseVisualStyleBackColor = false;
            this.btnSorunBildir.Click += new System.EventHandler(this.btnSorunBildir_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.White;
            this.btnMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMusteriler.Location = new System.Drawing.Point(23, 12);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(250, 80);
            this.btnMusteriler.TabIndex = 17;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnCihazlar
            // 
            this.btnCihazlar.BackColor = System.Drawing.Color.White;
            this.btnCihazlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCihazlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCihazlar.Location = new System.Drawing.Point(348, 12);
            this.btnCihazlar.Name = "btnCihazlar";
            this.btnCihazlar.Size = new System.Drawing.Size(250, 80);
            this.btnCihazlar.TabIndex = 18;
            this.btnCihazlar.Text = "Cihazlar";
            this.btnCihazlar.UseVisualStyleBackColor = false;
            this.btnCihazlar.Click += new System.EventHandler(this.btnCihazlar_Click);
            // 
            // dataGridViewABC
            // 
            this.dataGridViewABC.AllowUserToAddRows = false;
            this.dataGridViewABC.AllowUserToDeleteRows = false;
            this.dataGridViewABC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewABC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewABC.AutoGenerateColumns = false;
            this.dataGridViewABC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewABC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewABC.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewABC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewABC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewABC.ColumnHeadersHeight = 40;
            this.dataGridViewABC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewABC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sehirDataGridViewTextBoxColumn,
            this.isyeriadiDataGridViewTextBoxColumn,
            this.zimmernoDataGridViewTextBoxColumn,
            this.ureticifirmaDataGridViewTextBoxColumn,
            this.cihazadivemodeliDataGridViewTextBoxColumn,
            this.cihazserinoDataGridViewTextBoxColumn,
            this.kalibrasyontarihiDataGridViewTextBoxColumn,
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn});
            this.dataGridViewABC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridViewABC.DataSource = this.cihazlarBindingSource;
            this.dataGridViewABC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewABC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewABC.Location = new System.Drawing.Point(0, 92);
            this.dataGridViewABC.Name = "dataGridViewABC";
            this.dataGridViewABC.ReadOnly = true;
            this.dataGridViewABC.RowHeadersVisible = false;
            this.dataGridViewABC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewABC.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewABC.Size = new System.Drawing.Size(1320, 742);
            this.dataGridViewABC.TabIndex = 19;
            this.dataGridViewABC.VirtualMode = true;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "sehir";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isyeriadiDataGridViewTextBoxColumn
            // 
            this.isyeriadiDataGridViewTextBoxColumn.DataPropertyName = "isyeriadi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isyeriadiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.isyeriadiDataGridViewTextBoxColumn.HeaderText = "Is Yeri Adi";
            this.isyeriadiDataGridViewTextBoxColumn.Name = "isyeriadiDataGridViewTextBoxColumn";
            this.isyeriadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zimmernoDataGridViewTextBoxColumn
            // 
            this.zimmernoDataGridViewTextBoxColumn.DataPropertyName = "zimmerno";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zimmernoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.zimmernoDataGridViewTextBoxColumn.HeaderText = "Zimmer No";
            this.zimmernoDataGridViewTextBoxColumn.Name = "zimmernoDataGridViewTextBoxColumn";
            this.zimmernoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ureticifirmaDataGridViewTextBoxColumn
            // 
            this.ureticifirmaDataGridViewTextBoxColumn.DataPropertyName = "ureticifirma";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ureticifirmaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ureticifirmaDataGridViewTextBoxColumn.HeaderText = "Üretici Firma";
            this.ureticifirmaDataGridViewTextBoxColumn.Name = "ureticifirmaDataGridViewTextBoxColumn";
            this.ureticifirmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazadivemodeliDataGridViewTextBoxColumn
            // 
            this.cihazadivemodeliDataGridViewTextBoxColumn.DataPropertyName = "cihazadivemodeli";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cihazadivemodeliDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.cihazadivemodeliDataGridViewTextBoxColumn.HeaderText = "Cihaz Adi ve Modeli";
            this.cihazadivemodeliDataGridViewTextBoxColumn.Name = "cihazadivemodeliDataGridViewTextBoxColumn";
            this.cihazadivemodeliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazserinoDataGridViewTextBoxColumn
            // 
            this.cihazserinoDataGridViewTextBoxColumn.DataPropertyName = "cihazserino";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cihazserinoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.cihazserinoDataGridViewTextBoxColumn.HeaderText = "Cihaz Seri No";
            this.cihazserinoDataGridViewTextBoxColumn.Name = "cihazserinoDataGridViewTextBoxColumn";
            this.cihazserinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalibrasyontarihiDataGridViewTextBoxColumn
            // 
            this.kalibrasyontarihiDataGridViewTextBoxColumn.DataPropertyName = "kalibrasyontarihi";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalibrasyontarihiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.kalibrasyontarihiDataGridViewTextBoxColumn.HeaderText = "Kalibrasyon Tarihi";
            this.kalibrasyontarihiDataGridViewTextBoxColumn.Name = "kalibrasyontarihiDataGridViewTextBoxColumn";
            this.kalibrasyontarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sonrakikalibrasyontarihiDataGridViewTextBoxColumn
            // 
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.DataPropertyName = "sonrakikalibrasyontarihi";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.HeaderText = "Sonraki Kalibrasyon Tarihi";
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.Name = "sonrakikalibrasyontarihiDataGridViewTextBoxColumn";
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazlarBindingSource
            // 
            this.cihazlarBindingSource.DataMember = "cihazlar";
            this.cihazlarBindingSource.DataSource = this.musterilerYeniDataSet2;
            // 
            // musterilerYeniDataSet2
            // 
            this.musterilerYeniDataSet2.DataSetName = "musterilerYeniDataSet2";
            this.musterilerYeniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCihazSayisi
            // 
            this.labelCihazSayisi.AutoSize = true;
            this.labelCihazSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCihazSayisi.ForeColor = System.Drawing.Color.Tomato;
            this.labelCihazSayisi.Location = new System.Drawing.Point(1640, 200);
            this.labelCihazSayisi.Name = "labelCihazSayisi";
            this.labelCihazSayisi.Size = new System.Drawing.Size(184, 20);
            this.labelCihazSayisi.TabIndex = 20;
            this.labelCihazSayisi.Text = "Toplam Cihaz Sayisi : ";
            // 
            // cihazlarTableAdapter
            // 
            this.cihazlarTableAdapter.ClearBeforeFill = true;
            // 
            // abcKalibrationFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1320, 834);
            this.ControlBox = false;
            this.Controls.Add(this.labelCihazSayisi);
            this.Controls.Add(this.dataGridViewABC);
            this.Controls.Add(this.btnCihazlar);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnSorunBildir);
            this.Controls.Add(this.btnKalibrasyonaBasla);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "abcKalibrationFormu";
            this.Text = "ABC Kalibration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.abcKalibrationFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewABC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cihazlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerYeniDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnSorunBildir;
        private System.Windows.Forms.Button btnMusteriler;
        public System.Windows.Forms.Button btnKalibrasyonaBasla;
        private System.Windows.Forms.Button btnCihazlar;
        public System.Windows.Forms.DataGridView dataGridViewABC;
        public System.Windows.Forms.Label labelCihazSayisi;
        private musterilerYeniDataSet2 musterilerYeniDataSet2;
        private System.Windows.Forms.BindingSource cihazlarBindingSource;
        private musterilerYeniDataSet2TableAdapters.cihazlarTableAdapter cihazlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isyeriadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zimmernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ureticifirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazadivemodeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazserinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalibrasyontarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonrakikalibrasyontarihiDataGridViewTextBoxColumn;
    }
}