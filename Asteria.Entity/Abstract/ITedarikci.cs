using Asteria.Entity.Konaklama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Entity.Abstract
{
    public interface ITedarikci
    {
        List<Otel> OtelAra(
            string sehirAdi,
            DateTime baslangicTarihi,
            DateTime bitisTarihi,
            int kisiSayisi);
    }
}
