 using IECReportGenerator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IECReportGenerator.Infrastracture
{
    internal class IECWriter
    {
        public void SaveIECModels(string outputFile, IEnumerable<IECModel>models)
        {
            File.WriteAllText(outputFile, JsonConvert.SerializeObject(models));
        }
    }
}
