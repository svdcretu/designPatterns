using System.Collections.Generic;
using System.Drawing;

using BuilderPattern.DataObjects;

namespace BuilderPattern
{
    public class AdminReport: ReportBuilder
    {
        public AdminReport(string name) : base(name)
        {
        }

        public override void BuildHeader()
        {
            _report.ReportHeader = new ReportHeader
            {
                HeaderColor = Color.Red,
                ColumnHeaders = new List<string> { "A", "B", "C", "D", "E", "F", "G" }
            };
        }

        public override void BuildBody()
        {
            _report.ReportBody = new ReportBody
            {
                ShowCells = true,
                Data = new List<dynamic>
                {
                    new { a = "1", b = "2", c = "3", d = "4", e = 4, f = -80, g = 20 },
                    new { a = "1", b = "2", c = "3", d = "4", e = 4, f = 7, g = 21 },
                    new { a = "1", b = "2", c = "3", d = "4", e = 4, f = 108, g = 22 },
                    new { a = "1", b = "2", c = "3", d = "4", e = 4, f = 0, g = 23 }
                }
            };

        }

        public override void BuildFooter()
        {
            _report.ReportFooter = new ReportFooter
            {
                FooterValues = new List<string> { "A", "B", "C", "D", "E", "F", "G" },
                MarkNegativeAmmounts = true,
                Color = Color.Black
            };
        }
    }
}
