using Asteria.Entity.Abstract;
using Asteria.Entity.Odeme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Business
{
    public class OdemeFabrikasi
    {
        public IOdeme OdemeNesneiOlustur(string odemeTipi)
        {
            if (odemeTipi == "KrediKarti") return new KrediKarti();
            else if(odemeTipi == "Nakit") return new Nakit();
            return null;
        }
    }
}
