using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.StatisticsFactory
{
    public class SortAverageFactory : IStatisticsFactory
    {
        public override IDataTransformer GetDataTransformer()
        {
            return new SortTransformer();
        }

        public override IMeanCalculator GetMeanCalculator()
        {
            return new AverageCalculator();
        }
    }
}
