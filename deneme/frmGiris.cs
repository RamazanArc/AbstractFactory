using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace deneme
{
    public partial class frmGiris : Form
        
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
        
        public frmGiris()
        {
            InitializeComponent();
            
        }
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
           

            if(txt_kullaniciad.Text == "admin" && txt_sifre.Text == "admin")
            {
               this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
               

            }
            else
            {
                this.Hide();
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciGirisi(txt_kullaniciad.Text, txt_sifre.Text);
               
            }
            


        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            frmKayit frmkayit = new frmKayit();
            frmkayit.ShowDialog();
            
            
        }
    }
}
