using System.Collections.Generic;
using BuilderPattern.DataObjects;

namespace BuilderPattern
{
    public class ReportClient
    {
        private readonly List<IReportBuilder> _reportBuilder;

        private readonly IReportDirector _reportDirector;

        public ReportClient(IReportDirector reportDirector)
        {
            _reportDirector = reportDirector;
            _reportBuilder = new List<IReportBuilder>
            {
                new AdminReport("Yearly Admin Report"),
                new SalesReport("Monthly Sales Report")
            };
        }

        public List<Report> ProcessReports()
        {
            var results = new List<Report>();

            foreach (IReportBuilder reportBuilder in _reportBuilder)
            {
                Report report = _reportDirector.BuildReport(reportBuilder);
                results.Add(report);
            }

            return results;
        }
    }
}
