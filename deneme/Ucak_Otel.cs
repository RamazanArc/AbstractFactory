using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    public class Ucak_Otel : SoyutFabrika
    {
        public override IKonaklama KonaklamaOlustur()
        {
            return new Otel();
            
        }
        public override IUlasim UlasimOlustur()
        {
            return new Ucak();
        }
        
    }
}
