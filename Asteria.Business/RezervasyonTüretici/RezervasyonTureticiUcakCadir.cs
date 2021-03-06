using Asteria.Business.Abstract;
using Asteria.Entity.Abstract;
using Asteria.Entity.Konaklama;
using Asteria.Entity.Ulasim;
using System;

namespace Asteria.Business.RezervasyonTuretici
{
    public class RezervasyonUreticiUcakCadir : AbstractRezervasyonTuretici
    {
        public override IKonaklama CreateKonaklama()
        {
            return new Cadir();
        }

        public override IUlasim CreateUlasim()
        {
            return new Ucak();
        }
    }
}
