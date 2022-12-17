using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    public class Seyehat
    {
        private SoyutFabrika _soyutFabrika;
        private IUlasim _ulasim;
        private IKonaklama _konaklama;

        public Seyehat(SoyutFabrika soyutFabrika)
        {
            _soyutFabrika = soyutFabrika;
            _ulasim = _soyutFabrika.UlasimOlustur();
            _konaklama = _soyutFabrika.KonaklamaOlustur();
        }
        public void SeyehatOlustur(string konaklama, string ulasim, string no,string lokasyon, string ücret)
        {
            _ulasim.BuildUlasim(ulasim,lokasyon,ücret);
            _konaklama.BuildKonaklama(konaklama,no);

        }
    }
}
