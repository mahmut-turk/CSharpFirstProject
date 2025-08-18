namespace mnaMasaustuDeneme
{
    partial class acilisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acilisFormu));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.linkLabelSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.btnKullaniciEekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.Image")));
            this.btnGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGirisYap.Location = new System.Drawing.Point(884, 276);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(138, 54);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = " Sign In";
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullaniciAdi.Location = new System.Drawing.Point(779, 181);
            this.labelKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(91, 20);
            this.labelKullaniciAdi.TabIndex = 2;
            this.labelKullaniciAdi.Text = "Username :";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifre.Location = new System.Drawing.Point(790, 230);
            this.labelSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(86, 20);
            this.labelSifre.TabIndex = 3;
            this.labelSifre.Text = "Password :";
            // 
            // linkLabelSifremiUnuttum
            // 
            this.linkLabelSifremiUnuttum.AutoSize = true;
            this.linkLabelSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSifremiUnuttum.Location = new System.Drawing.Point(1030, 293);
            this.linkLabelSifremiUnuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            this.linkLabelSifremiUnuttum.Size = new System.Drawing.Size(129, 20);
            this.linkLabelSifremiUnuttum.TabIndex = 4;
            this.linkLabelSifremiUnuttum.TabStop = true;
            this.linkLabelSifremiUnuttum.Text = "Forgot Password";
            this.linkLabelSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSifremiUnuttum_LinkClicked);
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(884, 178);
            this.textBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(270, 26);
            this.textBoxKullaniciAdi.TabIndex = 5;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSifre.Location = new System.Drawing.Point(884, 227);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(270, 26);
            this.textBoxSifre.TabIndex = 6;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // btnKullaniciEekle
            // 
            this.btnKullaniciEekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKullaniciEekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKullaniciEekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciEekle.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEekle.Image")));
            this.btnKullaniciEekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKullaniciEekle.Location = new System.Drawing.Point(920, 394);
            this.btnKullaniciEekle.Name = "btnKullaniciEekle";
            this.btnKullaniciEekle.Size = new System.Drawing.Size(188, 73);
            this.btnKullaniciEekle.TabIndex = 22;
            this.btnKullaniciEekle.Text = " Add User";
            this.btnKullaniciEekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciEekle.UseVisualStyleBackColor = false;
            this.btnKullaniciEekle.Click += new System.EventHandler(this.btnKullaniciEekle_Click);
            // 
            // acilisFormu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1334, 713);
            this.Controls.Add(this.btnKullaniciEekle);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.linkLabelSifremiUnuttum);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "acilisFormu";
            this.Text = "Sign In Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.acilisFormu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.LinkLabel linkLabelSifremiUnuttum;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Button btnKullaniciEekle;
    }
}

