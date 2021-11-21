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
    public partial class OgrenciGirisEkrani : Form
    {
        public OgrenciGirisEkrani()
        {
            InitializeComponent();
        }

        public void OgrenciGirisEkrani_Load(object sender, EventArgs e)
        {
            txtogrencigirissifre.PasswordChar = '*';
        }

        public void btnOgrenciGirisButonu_Click(object sender, EventArgs e)
        {

        }
    }
}
