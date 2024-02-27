namespace Personel_Kayit
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.KullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // KullaniciAd
            // 
            this.KullaniciAd.Location = new System.Drawing.Point(351, 114);
            this.KullaniciAd.Name = "KullaniciAd";
            this.KullaniciAd.Size = new System.Drawing.Size(226, 36);
            this.KullaniciAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola :";
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(351, 175);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(226, 36);
            this.Sifre.TabIndex = 3;
            this.Sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(351, 233);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(230, 51);
            this.BtnGiris.TabIndex = 5;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(846, 379);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KullaniciAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiris;
    }
}