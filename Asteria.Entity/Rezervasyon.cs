using Asteria.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Entity
{
    public class Rezervasyon : IRezervasyon
    {
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int KisiSayisi { get; set; }
        public string OtelAdi { get; set; }
        public int RezervasyonID { get; set; }
    }
}
