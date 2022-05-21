using Asteria.Business.Abstract;
using Asteria.Entity.Abstract;

namespace Asteria.Business
{
    public class RezervasyonUretici
    {
        private AbstractRezervasyonTuretici _abstractRezervasyonTuretici;
        private IKonaklama _konaklama;
        private IUlasim _ulasim;

        public RezervasyonUretici(AbstractRezervasyonTuretici abstractRezervasyonTuretici)
        {
            _abstractRezervasyonTuretici = abstractRezervasyonTuretici;
            _konaklama = _abstractRezervasyonTuretici.CreateKonaklama();
            _ulasim = _abstractRezervasyonTuretici.CreateUlasim();
        }

        public void RezervasyonUret()
        {
            _konaklama.BuildKonaklama();
            _ulasim.BuildUlasim();
        }
    }
}
