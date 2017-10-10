using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class StandardDeviationCalculator : IMeanCalculator
    {
        public double CalculateMean(List<double> data)
        {
            IMeanCalculator averageCalculator = new AverageCalculator();
            double mean = averageCalculator.CalculateMean(data);
            double ans = 0.0;

            foreach(double element in data)
            {
                ans += (element - mean) * (element - mean);
            }

            ans /= Convert.ToDouble(data.Count() - 1);
            ans = Math.Sqrt(ans);
            return ans;
        }
    }
}
