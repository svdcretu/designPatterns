using BuilderPattern.DataObjects;

namespace BuilderPattern
{
    public class ReportDirector : IReportDirector
    {
        public Report BuildReport(IReportBuilder builder)
        {
            builder.BuildHeader();
            builder.BuildBody();
            builder.BuildFooter();

            return builder.GetReport();
        }
    }
}
