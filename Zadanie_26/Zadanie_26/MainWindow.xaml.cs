using Microsoft.Win32;
using System.Diagnostics.Metrics;
using System.IO;
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
using Zadanie_26.Interfaces;
using Zadanie_26.Models;
using Zadanie_26.Share;
using Microsoft.Extensions.Logging;
using System.Xml;

namespace Zadanie_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpenned = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder
                                            .SetMinimumLevel(LogLevel.Information))
                                            .CreateLogger<MainWindow>();
            _worker = new IXmlDocumentWorker(_logger);
        }


        public void PrintAvto(Avto avto)
        {
            textBlockXMlFileContent.Text = "===Avto====" + Environment.NewLine;
            textBlockXMlFileContent.Text += avto?.ToString() ?? "AvtoNotFound";
        }

        private void textBoxDeleteCountryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                PrintAvto(_worker.GetAll());
            }
        }

        private void PrintAvto(List<Avto> avtos)
        {
            textBlockXMlFileContent.Text = "====Avto====" + Environment.NewLine;
            foreach (var avto in avtos)
            {
                textBlockXMlFileContent.Text += avto.ToString();
            }
        }

        private void buttonOpenFile_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;

            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintAvto(_worker.GetAll());
            }
        }

        private void buttonFindCountryName_Click_1(object sender, RoutedEventArgs e)
        {
            var avto = _worker.FindBy(textBoxCountryName.Text);
            PrintAvto(avto);
        }

        private void buttonDelete_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteCountryName.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteCountryName.Text))
            {
                _worker.Delete(textBoxDeleteCountryName.Text);
                PrintAvto(_worker.GetAll());
            }
        }

        private void buttonAdd_Click_1(object sender, RoutedEventArgs e)
        {
            PrintAvto(_worker.GetAll());
        }

        private void buttonExit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}