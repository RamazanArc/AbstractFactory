using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace deneme
{
    public class Otel : IKonaklama
    {
        public string konaklama { get; set; }
        public string no { get; set; }
        public void BuildKonaklama(string konaklama ,string no)
        {
            this.konaklama = konaklama;
            this.no = no;
            SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
            SqlCommand komut = new SqlCommand("update rCesitleri set rKonaklama =@konaklama where rezervasyonID = @no", baglanti);
            komut.Parameters.AddWithValue("@konaklama", this.konaklama);
            komut.Parameters.AddWithValue("@no",this.no);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
            
    }
}
