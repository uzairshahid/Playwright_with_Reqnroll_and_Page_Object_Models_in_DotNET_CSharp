using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;

namespace Playwrights_Web_Automation.Utils
{
    public class ExtentReportHelper
    {
        private static ExtentReports _extent;
        private static ExtentTest _test;

        public static ExtentReports GetExtentReport()
        {
            if (_extent == null)
            {
                var reportPath = Path.Combine(Directory.GetCurrentDirectory(), "../../../TestResults/ExtentReport.html");
                var htmlReporter = new ExtentSparkReporter(reportPath);
                _extent = new ExtentReports();
                _extent.AttachReporter(htmlReporter);
            }
            return _extent;
        }

        public static ExtentTest CreateTest(string testName)
        {
            _test = GetExtentReport().CreateTest(testName);
            return _test;
        }

        public static void LogInfo(string message)
        {
            _test.Info(message);
        }

        public static void LogPass(string message)
        {
            _test.Pass(message);
        }

        public static void LogFail(string message)
        {
            _test.Fail(message);
        }

        public static void FlushReport()
        {
            GetExtentReport().Flush();
        }
    }
}