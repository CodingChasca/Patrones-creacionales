using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class SortTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            List<double> transformedData = new List<double>(data);
            transformedData.Sort();
            return transformedData;
        }
    }
}
