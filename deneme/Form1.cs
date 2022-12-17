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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_ulasim.SelectedIndex ==0 && cmb_konaklama.SelectedIndex ==0)
            {
                Seyehat ucakotel = new Seyehat(new Ucak_Otel());
                ucakotel.SeyehatOlustur(cmb_konaklama.Text, cmb_ulasim.Text, txt_rNo.Text,txt_lokasyon.Text,txt_ücret.Text);
                SqlCommand komut = new SqlCommand("update rCesitleri set baslangicTarihi = '" + dtp_baslangic.Value.ToString("yyyy-MM-dd") + "' , bitisTarihi = '" + dtp_bitis.Value.ToString("yyyy-MM-dd") + "' where rezervasyonID ='" + txt_rNo.Text + "' ", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Oluşturuldu");


            }
            else if (cmb_ulasim.SelectedIndex ==0 && cmb_konaklama.SelectedIndex ==1)
            {
                  Seyehat ucakcadir = new Seyehat(new Ucak_Cadir());
                  ucakcadir.SeyehatOlustur(cmb_konaklama.Text, cmb_ulasim.Text,txt_rNo.Text,txt_lokasyon.Text,txt_ücret.Text);
                SqlCommand komut = new SqlCommand("update rCesitleri set baslangicTarihi = '" + dtp_baslangic.Value.ToString("yyyy-MM-dd") + "' , bitisTarihi = '" + dtp_bitis.Value.ToString("yyyy-MM-dd") + "' where rezervasyonID ='" + txt_rNo.Text + "' ", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Oluşturuldu");

            }
            else if (cmb_ulasim.SelectedIndex == 1 && cmb_konaklama.SelectedIndex == 0)
            {
                Seyehat otobusotel = new Seyehat(new Otobus_Otel());
                otobusotel.SeyehatOlustur(cmb_konaklama.Text, cmb_ulasim.Text,txt_rNo.Text,txt_lokasyon.Text,txt_ücret.Text);
                SqlCommand komut = new SqlCommand("update rCesitleri set baslangicTarihi = '" + dtp_baslangic.Value.ToString("yyyy-MM-dd") + "' , bitisTarihi = '" + dtp_bitis.Value.ToString("yyyy-MM-dd") + "' where rezervasyonID ='" + txt_rNo.Text + "' ", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Oluşturuldu");

            }
            else if (cmb_ulasim.SelectedIndex == 1 && cmb_konaklama.SelectedIndex ==1)
            {
                Seyehat otobuscadir = new Seyehat(new Otobus_Cadir());
                otobuscadir.SeyehatOlustur(cmb_konaklama.Text, cmb_ulasim.Text,txt_rNo.Text,txt_lokasyon.Text,txt_ücret.Text);
                SqlCommand komut = new SqlCommand("update rCesitleri set baslangicTarihi = '" + dtp_baslangic.Value.ToString("yyyy-MM-dd") + "' , bitisTarihi = '" + dtp_bitis.Value.ToString("yyyy-MM-dd") + "' where rezervasyonID ='" + txt_rNo.Text + "' ", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Oluşturuldu");
            }






        }

        private void btn_acikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris frmGiris = new frmGiris();
            frmGiris.ShowDialog();
        }
    }
}
