using IECReportGenerator;
using IECReportGenerator.Infrastracture;
using System.Security.Cryptography.X509Certificates;

namespace IECReportGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var generator = new IECReportGenerator(new WindReader(), new IECWriter());

            generator.GenerateReport("data.json", "iec.json");

        }
    }


    
 }       