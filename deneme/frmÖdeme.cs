using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class frmÖdeme : Form
    {
        public frmÖdeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKullanici frmKullanici = new frmKullanici();
            Odeme odeme = new Odeme();
                odeme.OdemeIslemi(txt_kartno.Text, txt_cvv.Text, txt_skt.Text, txt_musterino.Text);
                MessageBox.Show("Ödeme yapıldı");
            
            
        }

        private void frmÖdeme_Load(object sender, EventArgs e)
        {
           
        }
    }
}
