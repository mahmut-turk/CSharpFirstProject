namespace mnaMasaustuDeneme
{
    partial class formSifremiUnuttum
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
            this.btnDogrulamaKoduGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifremiUnuttum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDogrulamaKoduGonder
            // 
            this.btnDogrulamaKoduGonder.Location = new System.Drawing.Point(228, 142);
            this.btnDogrulamaKoduGonder.Name = "btnDogrulamaKoduGonder";
            this.btnDogrulamaKoduGonder.Size = new System.Drawing.Size(208, 50);
            this.btnDogrulamaKoduGonder.TabIndex = 0;
            this.btnDogrulamaKoduGonder.Text = "Dogrulama Kodu Gönder";
            this.btnDogrulamaKoduGonder.UseVisualStyleBackColor = true;
            this.btnDogrulamaKoduGonder.Click += new System.EventHandler(this.btnDogrulamaKoduGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Mail Adresinizi Giriniz :";
            // 
            // txtSifremiUnuttum
            // 
            this.txtSifremiUnuttum.Location = new System.Drawing.Point(228, 96);
            this.txtSifremiUnuttum.Name = "txtSifremiUnuttum";
            this.txtSifremiUnuttum.Size = new System.Drawing.Size(295, 26);
            this.txtSifremiUnuttum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "dogrulama kodu : ";
            // 
            // formSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(675, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifremiUnuttum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDogrulamaKoduGonder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "formSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDogrulamaKoduGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSifremiUnuttum;
    }
}