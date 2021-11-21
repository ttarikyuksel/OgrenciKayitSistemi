
namespace OgrenciKayitSistemi
{
    partial class OgretmenGirisEkranı
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
            this.label3 = new System.Windows.Forms.Label();
            this.checkogretmenŞifremiGöster = new System.Windows.Forms.CheckBox();
            this.btnOgretmenGirisButonu = new System.Windows.Forms.Button();
            this.txtogretmengirissifre = new System.Windows.Forms.TextBox();
            this.txtogretmengiriseposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Öğretmen Giriş Ekranı";
            // 
            // checkogretmenŞifremiGöster
            // 
            this.checkogretmenŞifremiGöster.AutoSize = true;
            this.checkogretmenŞifremiGöster.Location = new System.Drawing.Point(144, 93);
            this.checkogretmenŞifremiGöster.Name = "checkogretmenŞifremiGöster";
            this.checkogretmenŞifremiGöster.Size = new System.Drawing.Size(91, 17);
            this.checkogretmenŞifremiGöster.TabIndex = 29;
            this.checkogretmenŞifremiGöster.Text = "Şifremi Göster";
            this.checkogretmenŞifremiGöster.UseVisualStyleBackColor = true;
            // 
            // btnOgretmenGirisButonu
            // 
            this.btnOgretmenGirisButonu.Location = new System.Drawing.Point(63, 89);
            this.btnOgretmenGirisButonu.Name = "btnOgretmenGirisButonu";
            this.btnOgretmenGirisButonu.Size = new System.Drawing.Size(75, 23);
            this.btnOgretmenGirisButonu.TabIndex = 28;
            this.btnOgretmenGirisButonu.Text = "Giriş";
            this.btnOgretmenGirisButonu.UseVisualStyleBackColor = true;
            // 
            // txtogretmengirissifre
            // 
            this.txtogretmengirissifre.Location = new System.Drawing.Point(63, 63);
            this.txtogretmengirissifre.Name = "txtogretmengirissifre";
            this.txtogretmengirissifre.Size = new System.Drawing.Size(100, 20);
            this.txtogretmengirissifre.TabIndex = 27;
            // 
            // txtogretmengiriseposta
            // 
            this.txtogretmengiriseposta.Location = new System.Drawing.Point(63, 36);
            this.txtogretmengiriseposta.Name = "txtogretmengiriseposta";
            this.txtogretmengiriseposta.Size = new System.Drawing.Size(100, 20);
            this.txtogretmengiriseposta.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Eposta :";
            // 
            // OgretmenGirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 122);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkogretmenŞifremiGöster);
            this.Controls.Add(this.btnOgretmenGirisButonu);
            this.Controls.Add(this.txtogretmengirissifre);
            this.Controls.Add(this.txtogretmengiriseposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgretmenGirisEkranı";
            this.Text = "OgretmenGirisEkranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkogretmenŞifremiGöster;
        private System.Windows.Forms.Button btnOgretmenGirisButonu;
        private System.Windows.Forms.TextBox txtogretmengirissifre;
        private System.Windows.Forms.TextBox txtogretmengiriseposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}