using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;

namespace Zadanie_25_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlotModel PlotModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PlotModel = new PlotModel { Title = "График функции" };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int xS = Convert.ToInt32(xs.Text); int xE = Convert.ToInt32(xe.Text); double Step = Convert.ToDouble(step1.Text);
            var model = new PlotModel { Title = "График Функции y = ctg(x)" };
            var series = new FunctionSeries(x => 1.0 / Math.Tan(x), xS, xE, Step, "y=ctg(x)");
            model.Series.Add(series);
            PlotView1.Model = model;

        }
    }
}