using Asteria.Business.Abstract;
using Asteria.Entity.Rapor;
using System.Text;

namespace Asteria.Business.ReportBuilder
{
    public class JsonReportBuilder : ReportBuilderBase
    {
        public JsonReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
        }

        public override string BuildHeader()
        {
            return string.Format("{{0}}", base.Info.Title);
        }

        public override string BuildFooter()
        {
            return string.Format("{{0}}", base.Info.TotalCost);
        }

        public override string BuildContents()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{"));
            foreach (var expense in base.Info.Expenses)
            {
                sb.Append(string.Format("\n\"Expend\":\"{0}\",", expense));
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(string.Format("}"));
            return sb.ToString();
        }
    }
}
