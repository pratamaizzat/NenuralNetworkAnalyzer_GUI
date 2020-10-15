using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork_2._0
{
    class JSONModel : DynamicObject
    {
        public dynamic TrainData { get; set; }
    }
}
