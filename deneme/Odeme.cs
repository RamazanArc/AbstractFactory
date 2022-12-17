using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace deneme
{
    public  class Odeme
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
        public string KrediKartıNo { get; set; }
        public string CVV { get; set; }
        public string KartTarihi { get; set; }
        public string kullaniciID { get; set; }
        

        public void OdemeIslemi(string kartno,string cvv, string tarih,string kullaniciID)
        {
            

            this.KrediKartıNo    = kartno;
            this.CVV = cvv;
            this.KartTarihi = tarih;
            this.kullaniciID = kullaniciID;
            SqlCommand komut = new SqlCommand("insert into ödeme(kartNo,CVV,SKT,kullaniciID) values (@kartno,@cvv,@tarih,@kullaniciID)",baglanti);
            komut.Parameters.AddWithValue("@kartno",this.KrediKartıNo);
            komut.Parameters.AddWithValue("@cvv",this.CVV);
            komut.Parameters.AddWithValue("@tarih", this.KartTarihi);
            komut.Parameters.AddWithValue("@kullaniciID",this.kullaniciID);
           
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

    }
}
