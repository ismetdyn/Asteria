using Asteria.Entity.Abstract;
using Asteria.Entity.Konaklama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Business
{
    public class OtelAramaci
    {
        private List<ITedarikci> tedarikciler;

        public OtelAramaci(List<ITedarikci> tedarikciler)
        {
            this.tedarikciler = tedarikciler;
        }

        public List<Otel> oteller;
        public List<Otel> OtelAra(
            string sehirAdi,
            DateTime baslangicTarihi,
            DateTime bitisTarihi,
            int kisiSayisi)
        {
            oteller = new List<Otel>();
            foreach (var tedarikci in tedarikciler)
            {
                oteller.AddRange(tedarikci.OtelAra(sehirAdi, baslangicTarihi, bitisTarihi, kisiSayisi));
            }

            oteller = oteller.GroupBy(i => i.OtelAdi).Select(i => new Otel
            {
                OtelAdi = i.Key,
                Ucret = i.Min(j => j.Ucret),
                TedarikciID = i.Min(j => j.TedarikciID)
            }).ToList();
            return oteller;
        }
    }
}
