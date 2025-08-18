namespace mnaMasaustuDeneme
{
    partial class formCihazlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxIsYerleri = new System.Windows.Forms.ComboBox();
            this.dataGridViewCihazlar = new System.Windows.Forms.DataGridView();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isyeriadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zimmernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ureticifirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazadivemodeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazserinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalibrasyontarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerYeniDataSet1 = new mnaMasaustuDeneme.musterilerYeniDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnCihazEkle = new System.Windows.Forms.Button();
            this.txtUreticiFirma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCihazAdiveModeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCihazSeriNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSehirler = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTumCihazlariGoster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZimmerNo = new System.Windows.Forms.TextBox();
            this.cihazlarTableAdapter = new mnaMasaustuDeneme.musterilerYeniDataSet1TableAdapters.cihazlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCihazlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cihazlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerYeniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIsYerleri
            // 
            this.comboBoxIsYerleri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxIsYerleri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxIsYerleri.DisplayMember = "IsYeriAdi";
            this.comboBoxIsYerleri.FormattingEnabled = true;
            this.comboBoxIsYerleri.Location = new System.Drawing.Point(272, 41);
            this.comboBoxIsYerleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxIsYerleri.Name = "comboBoxIsYerleri";
            this.comboBoxIsYerleri.Size = new System.Drawing.Size(432, 28);
            this.comboBoxIsYerleri.TabIndex = 2;
            this.comboBoxIsYerleri.ValueMember = "IsYeriAdi";
            // 
            // dataGridViewCihazlar
            // 
            this.dataGridViewCihazlar.AllowUserToAddRows = false;
            this.dataGridViewCihazlar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCihazlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCihazlar.AutoGenerateColumns = false;
            this.dataGridViewCihazlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCihazlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewCihazlar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCihazlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCihazlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCihazlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCihazlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sehirDataGridViewTextBoxColumn,
            this.isyeriadiDataGridViewTextBoxColumn,
            this.zimmernoDataGridViewTextBoxColumn,
            this.ureticifirmaDataGridViewTextBoxColumn,
            this.cihazadivemodeliDataGridViewTextBoxColumn,
            this.cihazserinoDataGridViewTextBoxColumn,
            this.kalibrasyontarihiDataGridViewTextBoxColumn,
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn});
            this.dataGridViewCihazlar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridViewCihazlar.DataSource = this.cihazlarBindingSource;
            this.dataGridViewCihazlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCihazlar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewCihazlar.Location = new System.Drawing.Point(0, 271);
            this.dataGridViewCihazlar.Name = "dataGridViewCihazlar";
            this.dataGridViewCihazlar.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCihazlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewCihazlar.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCihazlar.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewCihazlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCihazlar.Size = new System.Drawing.Size(1310, 533);
            this.dataGridViewCihazlar.TabIndex = 43;
            this.dataGridViewCihazlar.VirtualMode = true;
            this.dataGridViewCihazlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "sehir";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sehirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isyeriadiDataGridViewTextBoxColumn
            // 
            this.isyeriadiDataGridViewTextBoxColumn.DataPropertyName = "isyeriadi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isyeriadiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.isyeriadiDataGridViewTextBoxColumn.HeaderText = "İş Yeri Adi";
            this.isyeriadiDataGridViewTextBoxColumn.Name = "isyeriadiDataGridViewTextBoxColumn";
            this.isyeriadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zimmernoDataGridViewTextBoxColumn
            // 
            this.zimmernoDataGridViewTextBoxColumn.DataPropertyName = "zimmerno";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zimmernoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.zimmernoDataGridViewTextBoxColumn.HeaderText = "Zimmer No";
            this.zimmernoDataGridViewTextBoxColumn.Name = "zimmernoDataGridViewTextBoxColumn";
            this.zimmernoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ureticifirmaDataGridViewTextBoxColumn
            // 
            this.ureticifirmaDataGridViewTextBoxColumn.DataPropertyName = "ureticifirma";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ureticifirmaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ureticifirmaDataGridViewTextBoxColumn.HeaderText = "Üretici Firma";
            this.ureticifirmaDataGridViewTextBoxColumn.Name = "ureticifirmaDataGridViewTextBoxColumn";
            this.ureticifirmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazadivemodeliDataGridViewTextBoxColumn
            // 
            this.cihazadivemodeliDataGridViewTextBoxColumn.DataPropertyName = "cihazadivemodeli";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cihazadivemodeliDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.cihazadivemodeliDataGridViewTextBoxColumn.HeaderText = "Cihaz Adi ve Modeli";
            this.cihazadivemodeliDataGridViewTextBoxColumn.Name = "cihazadivemodeliDataGridViewTextBoxColumn";
            this.cihazadivemodeliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazserinoDataGridViewTextBoxColumn
            // 
            this.cihazserinoDataGridViewTextBoxColumn.DataPropertyName = "cihazserino";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cihazserinoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.cihazserinoDataGridViewTextBoxColumn.HeaderText = "Cihaz Seri No";
            this.cihazserinoDataGridViewTextBoxColumn.Name = "cihazserinoDataGridViewTextBoxColumn";
            this.cihazserinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalibrasyontarihiDataGridViewTextBoxColumn
            // 
            this.kalibrasyontarihiDataGridViewTextBoxColumn.DataPropertyName = "kalibrasyontarihi";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalibrasyontarihiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.kalibrasyontarihiDataGridViewTextBoxColumn.HeaderText = "Kalibrasyon Tarihi";
            this.kalibrasyontarihiDataGridViewTextBoxColumn.Name = "kalibrasyontarihiDataGridViewTextBoxColumn";
            this.kalibrasyontarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sonrakikalibrasyontarihiDataGridViewTextBoxColumn
            // 
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.DataPropertyName = "sonrakikalibrasyontarihi";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.HeaderText = "Sonraki Kalibrasyon Tarihi";
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.Name = "sonrakikalibrasyontarihiDataGridViewTextBoxColumn";
            this.sonrakikalibrasyontarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazlarBindingSource
            // 
            this.cihazlarBindingSource.DataMember = "cihazlar";
            this.cihazlarBindingSource.DataSource = this.musterilerYeniDataSet1;
            // 
            // musterilerYeniDataSet1
            // 
            this.musterilerYeniDataSet1.DataSetName = "musterilerYeniDataSet1";
            this.musterilerYeniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Lütfen Is Yeri Seciniz :";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(711, 41);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 28);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnCihazEkle
            // 
            this.btnCihazEkle.BackColor = System.Drawing.Color.White;
            this.btnCihazEkle.Location = new System.Drawing.Point(558, 200);
            this.btnCihazEkle.Name = "btnCihazEkle";
            this.btnCihazEkle.Size = new System.Drawing.Size(105, 55);
            this.btnCihazEkle.TabIndex = 9;
            this.btnCihazEkle.Text = "Ekle";
            this.btnCihazEkle.UseVisualStyleBackColor = false;
            this.btnCihazEkle.Click += new System.EventHandler(this.btnCihazEkle_Click);
            // 
            // txtUreticiFirma
            // 
            this.txtUreticiFirma.Location = new System.Drawing.Point(177, 165);
            this.txtUreticiFirma.Name = "txtUreticiFirma";
            this.txtUreticiFirma.Size = new System.Drawing.Size(342, 26);
            this.txtUreticiFirma.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Üretici Firma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Cihaz Adi ve Modeli :";
            // 
            // txtCihazAdiveModeli
            // 
            this.txtCihazAdiveModeli.Location = new System.Drawing.Point(177, 197);
            this.txtCihazAdiveModeli.Name = "txtCihazAdiveModeli";
            this.txtCihazAdiveModeli.Size = new System.Drawing.Size(342, 26);
            this.txtCihazAdiveModeli.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Cihaz Seri No :";
            // 
            // txtCihazSeriNo
            // 
            this.txtCihazSeriNo.Location = new System.Drawing.Point(177, 229);
            this.txtCihazSeriNo.Name = "txtCihazSeriNo";
            this.txtCihazSeriNo.Size = new System.Drawing.Size(342, 26);
            this.txtCihazSeriNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Kalibrasyon Tarihi :";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(682, 200);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 55);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(806, 200);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 55);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(855, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Toplam Cihaz Sayisi : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(711, 142);
            this.dateTimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Lütfen Sehir Seciniz :";
            // 
            // comboBoxSehirler
            // 
            this.comboBoxSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSehirler.DisplayMember = "IsYeriAdi";
            this.comboBoxSehirler.FormattingEnabled = true;
            this.comboBoxSehirler.Location = new System.Drawing.Point(272, 3);
            this.comboBoxSehirler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSehirler.Name = "comboBoxSehirler";
            this.comboBoxSehirler.Size = new System.Drawing.Size(432, 28);
            this.comboBoxSehirler.TabIndex = 1;
            this.comboBoxSehirler.ValueMember = "IsYeriAdi";
            this.comboBoxSehirler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSehirler_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(939, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(359, 80);
            this.label11.TabIndex = 66;
            this.label11.Text = "* Bilgilerini güncellemek istediginiz cihazin \r\nbulundugu satiri secip, \r\nsatirin" +
    " herhangi bir yerine cift tiklayiniz.\r\nBilgileri tamamlayinca Güncelle butonuna " +
    "basiniz. ";
            // 
            // btnTumCihazlariGoster
            // 
            this.btnTumCihazlariGoster.BackColor = System.Drawing.Color.White;
            this.btnTumCihazlariGoster.Location = new System.Drawing.Point(1171, 12);
            this.btnTumCihazlariGoster.Name = "btnTumCihazlariGoster";
            this.btnTumCihazlariGoster.Size = new System.Drawing.Size(127, 57);
            this.btnTumCihazlariGoster.TabIndex = 12;
            this.btnTumCihazlariGoster.Text = "Tüm Cihazlari Göster";
            this.btnTumCihazlariGoster.UseVisualStyleBackColor = false;
            this.btnTumCihazlariGoster.Click += new System.EventHandler(this.btnTumCihazlariGoster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Oda No :";
            // 
            // txtZimmerNo
            // 
            this.txtZimmerNo.Location = new System.Drawing.Point(177, 133);
            this.txtZimmerNo.Name = "txtZimmerNo";
            this.txtZimmerNo.Size = new System.Drawing.Size(342, 26);
            this.txtZimmerNo.TabIndex = 4;
            // 
            // cihazlarTableAdapter
            // 
            this.cihazlarTableAdapter.ClearBeforeFill = true;
            // 
            // formCihazlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1310, 804);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZimmerNo);
            this.Controls.Add(this.btnTumCihazlariGoster);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxSehirler);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCihazSeriNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCihazAdiveModeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUreticiFirma);
            this.Controls.Add(this.btnCihazEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCihazlar);
            this.Controls.Add(this.comboBoxIsYerleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "formCihazlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihazlar Sayfasi";
            this.Load += new System.EventHandler(this.formCihazlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCihazlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cihazlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerYeniDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewCihazlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnCihazEkle;
        private System.Windows.Forms.TextBox txtUreticiFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCihazAdiveModeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCihazSeriNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSehirler;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboBoxIsYerleri;
        private System.Windows.Forms.Button btnTumCihazlariGoster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZimmerNo;
        private musterilerYeniDataSet1 musterilerYeniDataSet1;
        private System.Windows.Forms.BindingSource cihazlarBindingSource;
        private musterilerYeniDataSet1TableAdapters.cihazlarTableAdapter cihazlarTableAdapter;
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