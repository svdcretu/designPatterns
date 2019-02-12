using BuilderPattern.DataObjects;

namespace BuilderPattern
{
    public interface IReportDirector
    {
        Report BuildReport(IReportBuilder builder);
    }
}