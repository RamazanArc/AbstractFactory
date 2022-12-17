using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    public class Otobus_Otel : SoyutFabrika
    {
        public override IUlasim UlasimOlustur()
        {
            return new Otobüs();
        }
        public override IKonaklama KonaklamaOlustur()
        {
            return new Otel();
        }
    }
}
