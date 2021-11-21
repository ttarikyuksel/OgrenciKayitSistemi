
namespace OgrenciKayitSistemi
{
    partial class OgrenciGirisEkrani
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
            this.checkogrenciŞifremiGöster = new System.Windows.Forms.CheckBox();
            this.btnOgrenciGirisButonu = new System.Windows.Forms.Button();
            this.txtogrencigirissifre = new System.Windows.Forms.TextBox();
            this.txtogrencigiriseposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkogrenciŞifremiGöster
            // 
            this.checkogrenciŞifremiGöster.AutoSize = true;
            this.checkogrenciŞifremiGöster.Location = new System.Drawing.Point(142, 91);
            this.checkogrenciŞifremiGöster.Name = "checkogrenciŞifremiGöster";
            this.checkogrenciŞifremiGöster.Size = new System.Drawing.Size(91, 17);
            this.checkogrenciŞifremiGöster.TabIndex = 22;
            this.checkogrenciŞifremiGöster.Text = "Şifremi Göster";
            this.checkogrenciŞifremiGöster.UseVisualStyleBackColor = true;
            // 
            // btnOgrenciGirisButonu
            // 
            this.btnOgrenciGirisButonu.Location = new System.Drawing.Point(61, 87);
            this.btnOgrenciGirisButonu.Name = "btnOgrenciGirisButonu";
            this.btnOgrenciGirisButonu.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciGirisButonu.TabIndex = 20;
            this.btnOgrenciGirisButonu.Text = "Giriş";
            this.btnOgrenciGirisButonu.UseVisualStyleBackColor = true;
            this.btnOgrenciGirisButonu.Click += new System.EventHandler(this.btnOgrenciGirisButonu_Click);
            // 
            // txtogrencigirissifre
            // 
            this.txtogrencigirissifre.Location = new System.Drawing.Point(61, 61);
            this.txtogrencigirissifre.Name = "txtogrencigirissifre";
            this.txtogrencigirissifre.Size = new System.Drawing.Size(100, 20);
            this.txtogrencigirissifre.TabIndex = 15;
            // 
            // txtogrencigiriseposta
            // 
            this.txtogrencigiriseposta.Location = new System.Drawing.Point(61, 34);
            this.txtogrencigiriseposta.Name = "txtogrencigiriseposta";
            this.txtogrencigiriseposta.Size = new System.Drawing.Size(100, 20);
            this.txtogrencigiriseposta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Eposta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Öğrenci Giriş Ekranı";
            // 
            // OgrenciGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 143);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkogrenciŞifremiGöster);
            this.Controls.Add(this.btnOgrenciGirisButonu);
            this.Controls.Add(this.txtogrencigirissifre);
            this.Controls.Add(this.txtogrencigiriseposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciGirisEkrani";
            this.Text = "OgrenciGirisEkrani";
            this.Load += new System.EventHandler(this.OgrenciGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox checkogrenciŞifremiGöster;
        public System.Windows.Forms.Button btnOgrenciGirisButonu;
        public System.Windows.Forms.TextBox txtogrencigirissifre;
        public System.Windows.Forms.TextBox txtogrencigiriseposta;
    }
}