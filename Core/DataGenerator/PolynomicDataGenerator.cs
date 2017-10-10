using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class PolynomicDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            List<double> rtnList = new List<double>();

            for (int i = 0; i < 50; i++)
            {
                rtnList.Add(3 * i * i * i + 8 * i * i - 6 * i + 5);
            }

            return rtnList;
        }
    }
}
