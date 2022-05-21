using Asteria.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteria.Business
{
    public class ReportManager
    {
        private ReportBuilderBase Builder;

        public ReportManager(ReportBuilderBase builder) => Builder = builder;

        public string Build()
        {
            string product = Builder.BuildOutput();
            return product;
        }

        public string BuildUpsideDown()
        {
            string product = Builder.BuildHeader();
            product += Builder.BuildContents();
            product += Builder.BuildFooter();
            return product;
        }
    }
}
