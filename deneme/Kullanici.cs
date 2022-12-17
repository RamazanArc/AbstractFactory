using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace deneme
{
    public class Kullanici
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciAd { get; set; }
        public string ePosta { get; set; }
        public string sifre { get; set; }
        public string telno { get; set; }
        public string tcno { get; set; }

        public void YeniKullaniciEkle(string isim, string soyisim, string kullaniciAd, string ePosta, string sifre, string telno,string tcno)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.telno = telno;
            this.sifre = sifre;
            this.ePosta = ePosta;
            this.kullaniciAd = kullaniciAd;
            this.tcno = tcno;
            SqlCommand komut = new SqlCommand("insert into kullanici(isim,soyisim,kullaniciAd,ePosta,sifre,telno,tcNo) values (@isim,@soyisim,@kullaniciad,@eposta,@sifre,@telno,@tcno)", baglanti);
            komut.Parameters.AddWithValue("@isim", this.isim);
            komut.Parameters.AddWithValue("@soyisim", this.soyisim);
            komut.Parameters.AddWithValue("@kullaniciad", this.kullaniciAd);
            komut.Parameters.AddWithValue("@eposta", this.ePosta);
            komut.Parameters.AddWithValue("@sifre", this.sifre);
            komut.Parameters.AddWithValue("@telno", this.telno);
            komut.Parameters.AddWithValue("tcno",this.tcno);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        SqlDataReader oku;
        public SqlDataReader KullaniciGirisi(string kulaniciAd, string sifre)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici where kullaniciAd =@kullaniciAd", baglanti);
            komut.Parameters.Add("@kullaniciAd", SqlDbType.NVarChar).Value = kulaniciAd;
            komut.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                if (sifre == oku["sifre"].ToString())
                {
                    
                   frmKullanici frmKullanici = new frmKullanici();
                    frmKullanici.ShowDialog();
                    
                    

                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz");
                    frmGiris frmGiris = new frmGiris();
                    frmGiris.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Komtrol ediniz");
                frmGiris frmGiris = new frmGiris();
                frmGiris.ShowDialog();
            }
            baglanti.Close();
            return oku;

           

        }
  
    }
}
