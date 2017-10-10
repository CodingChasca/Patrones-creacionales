using System;
using System.Windows.Forms;
using Core;
using Core.StatisticsFactory;
using System.Drawing;

namespace Calculadora_Factory_
{
    public partial class Form1 : Form
    {
        DataContainer dataContainer;
        DataContainer transformedDataContainer;

        public Form1()
        {
            InitializeComponent();
            dataContainer = new DataContainer();
            ChartBuilder builder = new ChartBuilder();
            builder.Build();
            GraphWindow window = builder.getGraphWindow();
            dataChart.Height = window.GraphHeight;
            meanLabel.Font = new Font("Arial", window.MeanFontSize, window.MeanFontStyle);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = typeComboBox.SelectedItem;

            if (type.Equals("Ones"))
            {
                dataContainer.Data = DataGeneratorFactory.createData(DataGeneratorFactory.ListType.Ones);
            }

            if (type.Equals("Random"))
            {
                dataContainer.Data = DataGeneratorFactory.createData(DataGeneratorFactory.ListType.Random);
            }

            if (type.Equals("Polynomic"))
            {
                dataContainer.Data = DataGeneratorFactory.createData(DataGeneratorFactory.ListType.Polynomic);
            }

            dataChart.Series["Data"].Points.Clear();
            foreach(double element in dataContainer.Data)
            {
                dataChart.Series["Data"].Points.Add(element);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transformationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transformedDataContainer = (DataContainer)dataContainer.Clone();
            var type = transformationComboBox.SelectedItem;
            IStatisticsFactory factory = null;

            if (type.Equals("Histogram"))
            {
                factory = new HistogramAverageFactory();
            }

            if (type.Equals("Root"))
            {
                factory = new RootStandardDeviationFactory();
            }

            if (type.Equals("Sort"))
            {
                factory = new SortAverageFactory();
            }

            if (type.Equals("Square"))
            {
                factory = new SquareStandardDeviationFactory();
            }

            transformedDataContainer.Data = factory.GetDataTransformer().TransformData(transformedDataContainer.Data);
            dataChart.Series["Transformed Data"].Points.Clear();

            foreach (double element in transformedDataContainer.Data)
            {
                dataChart.Series["Transformed Data"].Points.Add(element);
            }

            meanLabel.Text = factory.GetMeanCalculator().CalculateMean(dataContainer.Data).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataChart_Click(object sender, EventArgs e)
        {

        }
    }
}
