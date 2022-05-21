using Asteria.Entity.Abstract;
using Asteria.Entity.Konaklama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Entity.Tedarikci
{
    public class Tedarikci2 : ITedarikci
    {
        public List<Otel> OtelAra(string sehirAdi, DateTime baslangicTarihi, DateTime bitisTarihi, int kisiSayisi)
        {
            // web servisten veri çekme
            return new List<Otel>();
        }
    }
}
