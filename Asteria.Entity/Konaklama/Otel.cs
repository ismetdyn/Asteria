using Asteria.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Entity.Konaklama
{
    public class Otel : IKonaklama
    {
        public string OtelAdi { get; set; }
        public int Ucret { get; set; }
        public int TedarikciID { get; set; }

        public void BuildKonaklama()
        {
            throw new NotImplementedException();
        }
    }
}
