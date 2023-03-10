using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IECReportGenerator.Models
{
    internal class IECModel
    {
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("height")]
        public decimal Heigh { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("rotorDiameter")]
        public int RotorDiameter { get; set; }
    }
}
