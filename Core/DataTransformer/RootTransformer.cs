using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class RootTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            List<double> transformedData = new List<double>();
            foreach(double element in data)
            {
                transformedData.Add(Math.Sqrt(element));
            }
            return transformedData;
        }
    }
}
