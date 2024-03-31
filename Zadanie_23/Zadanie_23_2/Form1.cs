using OxyPlot.Series;
using OxyPlot;

namespace Zadanie_23_2
{
    public partial class Form1 : Form
    {
        public PlotModel PlotModel { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
            {
            PlotModel = new PlotModel { Title = "График функции" };
            var model = new PlotModel { Title = "График функции y = ctg(x)" };
            var series = new FunctionSeries(x => 1.0 / Math.Tan(x), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), "y = ctg(x)");
            model.Series.Add(series);
            plotView1.Model = model;
        }
    }
}
