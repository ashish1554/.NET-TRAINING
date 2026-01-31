using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    abstract class ReportGenerator
    {
        public abstract void GenerateReport();

    }
    class PdfReport:ReportGenerator
    {
        public override void GenerateReport()
        {
            Console.WriteLine("pdf report is generated....");
        }
    }

    class ExcelReport : ReportGenerator
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Excel report is generated....");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ReportGenerator pdf = new PdfReport();
            pdf.GenerateReport();
            ReportGenerator excel=new ExcelReport();
            excel.GenerateReport();
        }
    }
}
