using System.Collections.Generic;


namespace BuilderPattern.DataObjects
{
    public class ReportBody
    {
        public List<dynamic> Data { get; set; }

        public bool ShowCells { get; set; }
    }
}
