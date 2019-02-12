using System.Collections.Generic;
using System.Drawing;

namespace BuilderPattern.DataObjects
{
    public class ReportHeader
    {
        public List<string> ColumnHeaders { get; set; }

        public Color HeaderColor { get; set; }
    }
}
