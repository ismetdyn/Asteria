using Asteria.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Business.Abstract
{
    public abstract class AbstractRezervasyonTuretici
    {
        public abstract IKonaklama CreateKonaklama();
        public abstract IUlasim CreateUlasim();
    }
}
