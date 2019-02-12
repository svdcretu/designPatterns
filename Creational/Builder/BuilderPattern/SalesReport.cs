using System;
using System.Collections.Generic;
using System.Drawing;


using BuilderPattern.DataObjects;

namespace BuilderPattern
{
   public class SalesReport: ReportBuilder
    {
        public SalesReport(string name) : base(name)
        {
        }
        public override void BuildHeader()
        {
            _report.ReportHeader = new ReportHeader
            {
                ColumnHeaders = new List<string> { "Product Name", "Amount", "Currency", "Date" }
            };
        }
        public override void BuildBody()
        {
            _report.ReportBody = new ReportBody 
            {
                Data = GetList(),
                ShowCells = true
            };
        }
        public override void BuildFooter()
        {
            _report.ReportFooter = new ReportFooter
            {
                Color = Color.Blue,
                FooterValues = new List<string>
                {
                    "Total"
                },
                MarkNegativeAmmounts = false
            };
        }
        private List<dynamic> GetList()
        {
            return new List<dynamic>
            {
                new
                {
                    Name = "1stProduct",
                    Amount = 25.25,
                    Currency = "$",
                    Date = DateTime.Now
                },
                new
                {
                    Name = "2ndProduct",
                    Amount = 70.99,
                    Currency = "$",
                    Date = DateTime.Now.AddDays(-7)
                }
            };
        }

        
    }
}
