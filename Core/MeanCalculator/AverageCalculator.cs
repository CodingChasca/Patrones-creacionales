using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    internal class AverageCalculator : IMeanCalculator
    {
        public double CalculateMean(List<double> data)
        {
            double ans = 0.0;

            foreach(double element in data)
            {
                ans += element;
            }

            ans /= Convert.ToDouble(data.Count());
            return ans;
        }
    }
}
