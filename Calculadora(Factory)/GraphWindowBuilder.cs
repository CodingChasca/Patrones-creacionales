using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Factory_
{
    public abstract class GraphWindowBuilder
    {
        public abstract void BuildGraphColor(GraphWindow graphWindow);

        public abstract void BuildGraphWidth(GraphWindow graphWindow);

        public abstract void BuildGraphHeight(GraphWindow graphWindow);

        public abstract void BuildMeanFontSize(GraphWindow graphWindow);

        public abstract void BuildMeanFontFamily(GraphWindow graphWindow);

        public abstract GraphWindow Build();
    }
}
