using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteria.Entity.Rapor;

namespace Asteria.Business.Abstract
{
    public abstract class ReportBuilderBase
    {
        protected ReportInfo Info;

        public ReportBuilderBase(ReportInfo reportInfo) => Info = reportInfo;

        public string BuildOutput()
        {
            string output = BuildHeader();
            output += BuildContents();
            output += BuildFooter();
            return output;
        }

        public abstract string BuildHeader();
        public abstract string BuildFooter();
        public abstract string BuildContents();
    }
}
