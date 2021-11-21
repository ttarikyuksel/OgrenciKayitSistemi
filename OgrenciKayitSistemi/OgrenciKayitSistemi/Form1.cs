using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitSistemi
{
    public partial class Form1 : Form
    {
        Genelİslemler genelİslemler = new Genelİslemler();

        public Form1()
        {
            InitializeComponent();
        }

        #region OgrenciGirisButonu
        private void btnogrencigiris_Click(object sender, EventArgs e)
        {
            genelİslemler.OgrenciGirisButonu();
            this.Hide();
        }
        #endregion

        #region OgrenciKayitButonu
        private void button2_Click(object sender, EventArgs e)
        {
            genelİslemler.OgrenciKayitButonu();
        }

        #endregion

        #region OgretmenciGirisButonu
        private void btnogretmengiris_Click(object sender, EventArgs e)
        {
            genelİslemler.OgretmenGirisButonu();
            this.Hide();
        }
        #endregion

        #region OgretmenKayitButonu
        private void button1_Click(object sender, EventArgs e)
        {
            genelİslemler.OgretmenKayitButonu();

        }
        #endregion


    }
}
