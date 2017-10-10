using System.Collections.Generic;

namespace Core
{
    internal class OnesDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            List<double> ans = new List<double>();

            for (int i = 0; i < 50; i++)
            {
                ans.Add(1);
            }

            return ans;
        }
    }
}
