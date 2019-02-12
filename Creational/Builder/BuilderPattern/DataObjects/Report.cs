
namespace BuilderPattern.DataObjects
{
    public class Report
    {
        public string Name { get; set; }

        public ReportHeader ReportHeader { get; set; }

        public ReportBody ReportBody { get; set; }

        public ReportFooter ReportFooter { get; set; }
    }
}
