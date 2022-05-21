using Asteria.Business.Abstract;
using Asteria.Entity.Abstract;
using Asteria.Entity.Konaklama;
using Asteria.Entity.Ulasim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Business.RezervasyonTuretici
{
    public class RezervasyonUreticiOtobusCadir : AbstractRezervasyonTuretici
    {
        public override IKonaklama CreateKonaklama()
        {
            return new Cadir();
        }

        public override IUlasim CreateUlasim()
        {
            return new Otobus();
        }
    }
}
