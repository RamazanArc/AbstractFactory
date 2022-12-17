using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace deneme
{
    public class Ucak : IUlasim
    {
        public string ulasim { get; set; }
        public string lokasyon { get; set; }
        public string ücret { get; set; }

        public void BuildUlasim(string ulasim, string lokasyon , string ücret)
        {
            this.ulasim = ulasim;
            this.lokasyon = lokasyon;
            this.ücret = ücret;
            SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");
            SqlCommand komut = new SqlCommand("insert into rCesitleri(rUlasim,lokasyon,ücret) values(@ulasim,@lokasyon,@ücret)", baglanti);
            komut.Parameters.AddWithValue("@ulasim", this.ulasim);
            komut.Parameters.AddWithValue("@lokasyon",this.lokasyon);
            komut.Parameters.AddWithValue("@ücret",this.ücret);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }



    }
}
