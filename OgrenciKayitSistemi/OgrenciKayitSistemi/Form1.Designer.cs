﻿
namespace OgrenciKayitSistemi
{
    partial class Form1
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
            this.btnogrencigiris = new System.Windows.Forms.Button();
            this.btnogretmengiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogrencigiris
            // 
            this.btnogrencigiris.Location = new System.Drawing.Point(12, 12);
            this.btnogrencigiris.Name = "btnogrencigiris";
            this.btnogrencigiris.Size = new System.Drawing.Size(226, 58);
            this.btnogrencigiris.TabIndex = 0;
            this.btnogrencigiris.Text = "ÖĞRENCİ GİRİŞ";
            this.btnogrencigiris.UseVisualStyleBackColor = true;
            this.btnogrencigiris.Click += new System.EventHandler(this.btnogrencigiris_Click);
            // 
            // btnogretmengiris
            // 
            this.btnogretmengiris.Location = new System.Drawing.Point(244, 12);
            this.btnogretmengiris.Name = "btnogretmengiris";
            this.btnogretmengiris.Size = new System.Drawing.Size(226, 58);
            this.btnogretmengiris.TabIndex = 1;
            this.btnogretmengiris.Text = "ÖĞRETMEN GİRİŞ";
            this.btnogretmengiris.UseVisualStyleBackColor = true;
            this.btnogretmengiris.Click += new System.EventHandler(this.btnogretmengiris_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(244, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "ÖĞRETMEN KAYIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(12, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "ÖĞRENCİ KAYIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 139);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnogretmengiris);
            this.Controls.Add(this.btnogrencigiris);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnogrencigiris;
        private System.Windows.Forms.Button btnogretmengiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

