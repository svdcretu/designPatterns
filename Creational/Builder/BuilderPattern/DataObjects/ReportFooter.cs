using System.Collections.Generic;
using System.Drawing;

namespace BuilderPattern.DataObjects
{
    public class ReportFooter
    {
        public List<string> FooterValues { get; set; }

        public Color Color { get; set; }

        public bool MarkNegativeAmmounts { get; set; }
    }
}
