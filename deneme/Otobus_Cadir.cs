using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Otobus_Cadir : SoyutFabrika
    {
        public override IUlasim UlasimOlustur()
        {
            return new Otobüs();
        }

        public override IKonaklama KonaklamaOlustur()
        {
            return new Cadir();
        }
    }
}
