using Asteria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Business
{
    class RezervasyonYapici
    {
        private Rezervasyon rezervasyon;
        
        public Rezervasyon RezervasyonYap()
        {
            // bilgileri al
            rezervasyon = new Rezervasyon();
            return rezervasyon;
        }
    }
}
