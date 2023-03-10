using IECReportGenerator.Infrastracture;
using IECReportGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IECReportGenerator
{
    internal class IECReportGenerator
    {
        WindReader _reader;
        IECWriter _writer;
        
        public IECReportGenerator(WindReader reader, IECWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void GenerateReport(string inputFile , string outputFile)
        {
             var windModels = _reader.ReadWindModels(inputFile);
            var iecModels = new List<IECModel>();

            foreach (var windModel in windModels) 
            { 
                var decimalHeight = decimal.Parse(windModel.Height.ToString());
                var iecModel = new IECModel()
                {
                    Class = windModel.WindClass,
                    Heigh = decimal.Round(decimalHeight, 1),
                    Power = windModel.Power + "MW",
                    RotorDiameter = windModel.BladeLength * 2

                };

                iecModels.Add(iecModel);
            }
            _writer.SaveIECModels(outputFile, iecModels);

        }
    }
}
