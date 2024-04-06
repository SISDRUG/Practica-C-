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
                PrintAvtoBlock(_worker.GetAll());
            }
        }

        private void PrintAvtoBlock(List<Avto> avtos)
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

                if (radioButtonTextBlock.IsChecked == true)
                {
                    PrintAvtoBlock(_worker.GetAll());
                    listBoxCountries.Visibility = Visibility.Collapsed;
                    treeViewCountries.Visibility = Visibility.Collapsed;
                    textBlockXMlFileContent.Visibility = Visibility.Visible;

                }
                else if (radioButtonTreeView.IsChecked == true)
                {
                    PrintContriesTreeView(_worker.GetAll());
                    listBoxCountries.Visibility = Visibility.Collapsed;
                    treeViewCountries.Visibility = Visibility.Visible;
                    textBlockXMlFileContent.Visibility = Visibility.Collapsed;
                }
                else if (radioButtonListBox.IsChecked == true)
                {
                    PrintContriesListBox(_worker.GetAll());
                    listBoxCountries.Visibility = Visibility.Visible;
                    treeViewCountries.Visibility = Visibility.Collapsed;
                    textBlockXMlFileContent.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void PrintContriesTreeView(List<Avto> countries)
        {
            treeViewCountries.Items.Clear();

            foreach (var country in countries)
            {
                var countryNode = new TreeViewItem();
                countryNode.Header = country;


                treeViewCountries.Items.Add(countryNode);
            }
        }

        private void PrintContriesListBox(List<Avto> countries)
        {
            listBoxCountries.Items.Clear();

            foreach (var country in countries)
            {
                listBoxCountries.Items.Add(country);
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
                PrintAvtoBlock(_worker.GetAll());
            }
        }

        private void buttonAdd_Click_1(object sender, RoutedEventArgs e)
        {
            PrintAvtoBlock(_worker.GetAll());
        }

        private void buttonExit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}