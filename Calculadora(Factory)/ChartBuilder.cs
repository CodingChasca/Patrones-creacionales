using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculadora_Factory_
{
    public class ChartBuilder : GraphWindowBuilder
    {
        private GraphWindow graphWindow = null;

        public ChartBuilder()
        {
            graphWindow = new GraphWindow();
        }

        public override GraphWindow Build()
        {
            graphWindow = new GraphWindow();
            this.BuildMeanFontFamily(graphWindow);
            this.BuildGraphColor(graphWindow);
            this.BuildGraphHeight(graphWindow);
            this.BuildGraphWidth(graphWindow);
            this.BuildMeanFontSize(graphWindow);
            return graphWindow;
        }

        public override void BuildMeanFontFamily(GraphWindow graphWindow)
        {
            graphWindow.MeanFontStyle = FontStyle.Bold;
        }

        public override void BuildGraphColor(GraphWindow graphWindow)
        {
            graphWindow.GraphColor = ChartColorPalette.Berry;
        }

        public override void BuildGraphHeight(GraphWindow graphWindow)
        {
            graphWindow.GraphHeight = 150;
        }

        public override void BuildGraphWidth(GraphWindow graphWindow)
        {
            graphWindow.GraphWidth = 80;
        }

        public override void BuildMeanFontSize(GraphWindow graphWindow)
        {
            graphWindow.MeanFontSize = 12.0f;
        }
        
        public GraphWindow getGraphWindow()
        {
            return this.graphWindow;
        }
    }
}
