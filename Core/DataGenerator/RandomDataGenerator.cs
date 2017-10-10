using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class RandomDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            var rand = new Random();
            var rtnList = new List<double>();
            
            for (int i =0; i<50; i++)
            {
                rtnList.Add(rand.Next(1000));
            }
            return rtnList;    
        }
    }
}
