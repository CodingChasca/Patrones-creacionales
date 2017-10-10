using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DataContainer : IClonableDataContainer
    {
        public List<double> Data { get; set; }

        public IClonableDataContainer Clone()
        {
            DataContainer clone = new DataContainer();
            clone.Data = new List<double>(this.Data);
            return clone;
        }
    }
}
