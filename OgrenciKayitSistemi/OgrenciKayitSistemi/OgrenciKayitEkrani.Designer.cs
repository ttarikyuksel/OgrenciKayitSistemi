
namespace OgrenciKayitSistemi
{
    partial class OgrenciKayitEkrani
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
            this.checkogrenciŞifremiGöster = new System.Windows.Forms.CheckBox();
            this.btnOgrenciGirisButonu = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Öğrenci Kayıt Ekranı";
            // 
            // checkogrenciŞifremiGöster
            // 
            this.checkogrenciŞifremiGöster.AutoSize = true;
            this.checkogrenciŞifremiGöster.Location = new System.Drawing.Point(161, 119);
            this.checkogrenciŞifremiGöster.Name = "checkogrenciŞifremiGöster";
            this.checkogrenciŞifremiGöster.Size = new System.Drawing.Size(91, 17);
            this.checkogrenciŞifremiGöster.TabIndex = 29;
            this.checkogrenciŞifremiGöster.Text = "Şifremi Göster";
            this.checkogrenciŞifremiGöster.UseVisualStyleBackColor = true;
            // 
            // btnOgrenciGirisButonu
            // 
            this.btnOgrenciGirisButonu.Location = new System.Drawing.Point(80, 115);
            this.btnOgrenciGirisButonu.Name = "btnOgrenciGirisButonu";
            this.btnOgrenciGirisButonu.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciGirisButonu.TabIndex = 28;
            this.btnOgrenciGirisButonu.Text = "Kayıt Ol";
            this.btnOgrenciGirisButonu.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(80, 37);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Şifre(Tekrar) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Eposta :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Şifre :";
            // 
            // OgrenciKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 155);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkogrenciŞifremiGöster);
            this.Controls.Add(this.btnOgrenciGirisButonu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciKayitEkrani";
            this.Text = "OgrenciKayitEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkogrenciŞifremiGöster;
        private System.Windows.Forms.Button btnOgrenciGirisButonu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}