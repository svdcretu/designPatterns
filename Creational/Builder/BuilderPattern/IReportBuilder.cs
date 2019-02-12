using BuilderPattern.DataObjects;

namespace BuilderPattern
{
    public interface IReportBuilder
    {
        void BuildHeader();

        void BuildBody();

        void BuildFooter();

        Report GetReport();
    }
}
