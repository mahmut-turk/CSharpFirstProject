namespace mnaMasaustuDeneme
{
    partial class formSorunBildir
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
            this.buttonIptal = new System.Windows.Forms.Button();
            this.textBoxKonu = new System.Windows.Forms.TextBox();
            this.richTextBoxSorunBilgileri = new System.Windows.Forms.RichTextBox();
            this.labelSorunKonu = new System.Windows.Forms.Label();
            this.labelDetayliAcikla = new System.Windows.Forms.Label();
            this.buttonSorunuGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIptal
            // 
            this.buttonIptal.CausesValidation = false;
            this.buttonIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIptal.Location = new System.Drawing.Point(899, 655);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(136, 43);
            this.buttonIptal.TabIndex = 0;
            this.buttonIptal.Text = "Iptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // textBoxKonu
            // 
            this.textBoxKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKonu.Location = new System.Drawing.Point(102, 69);
            this.textBoxKonu.Name = "textBoxKonu";
            this.textBoxKonu.Size = new System.Drawing.Size(1075, 26);
            this.textBoxKonu.TabIndex = 1;
            // 
            // richTextBoxSorunBilgileri
            // 
            this.richTextBoxSorunBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSorunBilgileri.Location = new System.Drawing.Point(102, 121);
            this.richTextBoxSorunBilgileri.Name = "richTextBoxSorunBilgileri";
            this.richTextBoxSorunBilgileri.Size = new System.Drawing.Size(1075, 518);
            this.richTextBoxSorunBilgileri.TabIndex = 2;
            this.richTextBoxSorunBilgileri.Text = "";
            // 
            // labelSorunKonu
            // 
            this.labelSorunKonu.AutoSize = true;
            this.labelSorunKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSorunKonu.Location = new System.Drawing.Point(42, 75);
            this.labelSorunKonu.Name = "labelSorunKonu";
            this.labelSorunKonu.Size = new System.Drawing.Size(54, 20);
            this.labelSorunKonu.TabIndex = 3;
            this.labelSorunKonu.Text = "Konu :";
            // 
            // labelDetayliAcikla
            // 
            this.labelDetayliAcikla.AutoSize = true;
            this.labelDetayliAcikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetayliAcikla.Location = new System.Drawing.Point(98, 98);
            this.labelDetayliAcikla.Name = "labelDetayliAcikla";
            this.labelDetayliAcikla.Size = new System.Drawing.Size(320, 20);
            this.labelDetayliAcikla.TabIndex = 4;
            this.labelDetayliAcikla.Text = "Lütfen sorunu asagida detaylica aciklayiniz : ";
            // 
            // buttonSorunuGonder
            // 
            this.buttonSorunuGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSorunuGonder.Location = new System.Drawing.Point(1041, 655);
            this.buttonSorunuGonder.Name = "buttonSorunuGonder";
            this.buttonSorunuGonder.Size = new System.Drawing.Size(136, 43);
            this.buttonSorunuGonder.TabIndex = 5;
            this.buttonSorunuGonder.Text = "Gönder";
            this.buttonSorunuGonder.UseVisualStyleBackColor = true;
            this.buttonSorunuGonder.Click += new System.EventHandler(this.buttonSorunuGonder_Click);
            // 
            // formSorunBildir
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonIptal;
            this.ClientSize = new System.Drawing.Size(1200, 707);
            this.Controls.Add(this.buttonSorunuGonder);
            this.Controls.Add(this.labelDetayliAcikla);
            this.Controls.Add(this.labelSorunKonu);
            this.Controls.Add(this.richTextBoxSorunBilgileri);
            this.Controls.Add(this.textBoxKonu);
            this.Controls.Add(this.buttonIptal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 23);
            this.MaximizeBox = false;
            this.Name = "formSorunBildir";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorun Bildirme Platformu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.TextBox textBoxKonu;
        private System.Windows.Forms.RichTextBox richTextBoxSorunBilgileri;
        private System.Windows.Forms.Label labelSorunKonu;
        private System.Windows.Forms.Label labelDetayliAcikla;
        private System.Windows.Forms.Button buttonSorunuGonder;
    }
}