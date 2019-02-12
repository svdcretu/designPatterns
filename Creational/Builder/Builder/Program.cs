using System;

using BuilderPattern;
using BuilderPattern.DataObjects;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************** Builder Pattern *******************************************");

            IReportDirector reportFactory = new ReportDirector();
            ReportClient rd = new ReportClient(reportFactory);
            var reports = rd.ProcessReports();

            foreach (var report in reports)
            {
                Console.WriteLine($"************ {report.Name} ************************");
                foreach (string reportHeaderColumnHeader in report.ReportHeader.ColumnHeaders)
                {
                    Console.WriteLine($" {reportHeaderColumnHeader} ");
                }
                Console.WriteLine("~~~~~~~~~~~~ END ~~~~~~~~~~~~");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
