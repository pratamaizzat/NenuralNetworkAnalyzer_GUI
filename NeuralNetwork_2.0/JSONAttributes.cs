using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork_2._0
{
    public class JSONAttributes
    {
        public List<double[]> Inputs { get; set; } = new List<double[]>();
        public List<double[]> Targets { get; set; } = new List<double[]>();
    }
}
