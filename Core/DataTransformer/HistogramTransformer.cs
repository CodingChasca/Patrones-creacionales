using System.Collections.Generic;
using System.Linq;

namespace Core
{
    internal class HistogramTranformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            double mi = data.Min();
            double ma = data.Max()+1;
            int parts = 10;
            double size = (ma - mi) / parts;
            List<double> histogram = new List<double>();
            
            for (int i=0;i<10;i++)
            {
                histogram.Add(0.0);
            }

            foreach (double element in data)
            {
                int part = (int)((element-mi) / size);
                histogram[part]++;
            }
            return histogram;
        }
    }
}
