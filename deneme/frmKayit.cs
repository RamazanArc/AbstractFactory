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
    public partial class frmKayit : Form
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
        public frmKayit()
        {
            InitializeComponent();
        }

        private void btn_kayit2_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.YeniKullaniciEkle(txt_isim2.Text, txt_soyisim2.Text, txt_kullaniciad2.Text, txt_eposta2.Text, txt_sifre2.Text, txt_telno2.Text,txt_tc.Text);
            MessageBox.Show("Kayıt Başarılı");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select kullaniciID from kullanici where telno = '"+txt_telno2.Text+"'",baglanti);
            
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                string id = read["kullaniciID"].ToString();
                MessageBox.Show(" Müsteri numaranız : " +id );
            }
            baglanti.Close();

            this.Close();
        }
    }
    
}
