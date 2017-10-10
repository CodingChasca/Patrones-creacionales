using System.Collections.Generic;

namespace Core
{
    public class DataGeneratorFactory
    {
        public enum ListType { Random, Polynomic, Ones};

        public static List<double> createData(ListType type)
        {
            IDataGenerator dataGenerator = null;
            switch(type)
            {
                case (ListType.Random):
                    dataGenerator = new RandomDataGenerator();
                    break;

                case (ListType.Polynomic):
                    dataGenerator = new PolynomicDataGenerator();
                    break;

                case (ListType.Ones):
                    dataGenerator = new OnesDataGenerator();
                    break;
            }
            
            return dataGenerator.GenerateData();
        }
    }
}
