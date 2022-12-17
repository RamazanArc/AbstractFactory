using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Ucak_Cadir : SoyutFabrika
    {
        public override IKonaklama KonaklamaOlustur()
        {
            return new Cadir();
        }

        public override IUlasim UlasimOlustur()
        {
            return new Ucak();
        }
    }
}
