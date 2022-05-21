using Asteria.Entity.Abstract;
using System.Collections.Generic;

namespace Asteria.Entity.Rapor
{
    public class ReportInfo : IRapor
    {
        public string Title;
        public List<string> Expenses;
        public decimal TotalCost;
    }
}
