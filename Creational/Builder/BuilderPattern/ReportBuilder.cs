using BuilderPattern.DataObjects;

namespace BuilderPattern
{
    public abstract class ReportBuilder: IReportBuilder
    {
        protected readonly Report _report;

        public ReportBuilder(string name)
        {
            _report = new Report
            {
                Name = name
            };
        }

        public abstract void BuildHeader();

        public abstract void BuildBody();

        public abstract void BuildFooter();

        public virtual Report GetReport()
        {
            return _report;
        }
    }
}
