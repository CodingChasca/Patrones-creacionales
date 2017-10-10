using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculadora_Factory_
{
    public class GraphWindow
    {
        public ChartColorPalette GraphColor { get; set; }

        public int GraphWidth { get; set; }

        public int GraphHeight { get; set; }

        public float MeanFontSize { get; set; }

        public FontStyle MeanFontStyle { get; set; }
    }
}
