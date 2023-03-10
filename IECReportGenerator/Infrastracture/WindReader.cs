using IECReportGenerator.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IECReportGenerator.Infrastracture
{
    internal class WindReader
    {
        public IEnumerable<WindModel> ReadWindModels(string inputFile)
        {
            var jsonText = File.ReadAllText(inputFile);

            var windModels =  JsonConvert.DeserializeObject<IEnumerable<WindModel>>(jsonText);

            return windModels;
        }
    }
}
