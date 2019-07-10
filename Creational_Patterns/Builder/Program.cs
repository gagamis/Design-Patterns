using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Builder pattern!");

            // report generator
            Director director = new Director();

            // Cretae PDF report
            ReportBuilder pdfBuilder = new PDFBuilder();
            Report pdfReport = director.GenerateReport(pdfBuilder); // Generate the PDF report

            // Create Excel report
            ReportBuilder excelBuilder = new ExcelBuilder();
            Report excelReport = director.GenerateReport(excelBuilder);  // Generate the Excel report

            // Create PDF report by fluent builder
            FluentDirector fluentDirector = new FluentDirector();
            FluentReportBuilder pdfFluentBuilder = new PDFFluentBuilder();
            Report pdfFluentReport = fluentDirector.GenerateReport(pdfFluentBuilder);

            // print PDF 
            Console.WriteLine("--- PDF report ---");
            Console.WriteLine($"Type: {pdfReport.ReportType}");
            Console.WriteLine($"Header: {pdfReport.Header}");
            Console.WriteLine($"Content: {pdfReport.Content}");
            Console.WriteLine($"Footer: {pdfReport.Footer}");

            // print Excel report
            Console.WriteLine("--- Excel report ---");
            Console.WriteLine($"Type: {excelReport.ReportType}");
            Console.WriteLine($"Header: {excelReport.Header}");
            Console.WriteLine($"Content: {excelReport.Content}");
            Console.WriteLine($"Footer: {excelReport.Footer}");

            // print fluent PDF
            Console.WriteLine("--- Fluent PDF report ---");
            Console.WriteLine($"Type: {pdfFluentReport.ReportType}");
            Console.WriteLine($"Header: {pdfFluentReport.Header}");
            Console.WriteLine($"Content: {pdfFluentReport.Content}");
            Console.WriteLine($"Footer: {pdfFluentReport.Footer}");

            Console.ReadLine();
        }
    }

    /// <summary>
    /// The PRODUCT
    /// </summary>
    class Report
    {
        public string ReportType { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Content { get; set; }
    }

    // It is responsible for defining
    // the construction process for induvidual parts. 
    // Builder has those induvidual process to initialize and configure the report.
    abstract class ReportBuilder
    {
        protected Report _report;

        public void CreateReport()
        {
            _report = new Report();
        }
        public abstract void SetReportType();
        public abstract void SetHeader();
        public abstract void SetFooter();
        public abstract void SetContent();
        public Report DispatchReport() => _report;
    }

    /// <summary>
    /// PDF report
    /// </summary>
    class PDFBuilder : ReportBuilder
    {
        /// <summary>
        /// Set the content of report
        /// </summary>
        public override void SetContent() => _report.Content = "PDF Content";

        /// <summary>
        /// Set the footer of report
        /// </summary>
        public override void SetFooter() => _report.Footer = "PDF Footer";

        /// <summary>
        /// Set the header of report
        /// </summary>
        public override void SetHeader() => _report.Header = "PDF Header";

        /// <summary>
        /// Set the type of report
        /// </summary>
        public override void SetReportType() => _report.ReportType = "PDF";
    }

    /// <summary>
    /// Excel report
    /// </summary>
    class ExcelBuilder : ReportBuilder
    {

        /// <summary>
        /// Set the content of report
        /// </summary>
        public override void SetContent() => _report.Content = "Excel Content";

        /// <summary>
        /// Set the footer of report
        /// </summary>
        public override void SetFooter() => _report.Footer = "Excel Footer";

        /// <summary>
        /// Set the header of report
        /// </summary>
        public override void SetHeader() => _report.Header = "Excel Header";

        /// <summary>
        /// Set the type of report
        /// </summary>
        public override void SetReportType() => _report.ReportType = "Excel";
    }

    // Director takes those induvidual process from the builder
    // and defines the sequence to build the report.
    class Director
    {
        /// <summary>
        /// Process the sequence to build the report
        /// </summary>
        /// <param name="builder">Report builder</param>
        /// <returns>Report</returns>
        public Report GenerateReport(ReportBuilder builder)
        {
            // Sequence of creating report
            builder.CreateReport();     // Step 1
            builder.SetReportType();    // Step 2
            builder.SetHeader();        // Step 3
            builder.SetFooter();        // Step 4
            builder.SetContent();       // Step 5

            // return the created report
            return builder.DispatchReport();
        }
    }

    // Fluent API
    abstract class FluentReportBuilder
    {
        protected Report _report;

        public FluentReportBuilder CreateReport()
        {
            _report = new Report();
            return this;
        }

        public abstract FluentReportBuilder SetReportType();
        public abstract FluentReportBuilder SetHeader();
        public abstract FluentReportBuilder SetFooter();
        public abstract FluentReportBuilder SetContent();
        public Report DispatchReport() => _report;
    }
    class FluentDirector
    {
        public Report GenerateReport(FluentReportBuilder builder)
        {
            return builder
                    .CreateReport()
                    .SetReportType()
                    .SetHeader()
                    .SetFooter()
                    .SetContent()
                    .DispatchReport();
        }
    }
    class PDFFluentBuilder : FluentReportBuilder
    {
        public override FluentReportBuilder SetContent()
        {
            _report.Content = "PDF Fluent Content";
            return this;
        }

        public override FluentReportBuilder SetFooter()
        {
            _report.Footer = "PDF Fluent Footer";
            return this;
        }

        public override FluentReportBuilder SetHeader()
        {
            _report.Header = "PDF Fluent Header";
            return this;
        }

        public override FluentReportBuilder SetReportType()
        {
            _report.ReportType = "PDF Fluent";
            return this;
        }
    }
}
