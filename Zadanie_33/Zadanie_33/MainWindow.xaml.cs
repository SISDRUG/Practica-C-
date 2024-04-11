using System.Data;
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
using System.Data.OleDb;

namespace Zadanie_33
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SISDRUG\Desktop\Zadanie_33\Zadanie_33\Turisty.mdb;Persist Security Info=False;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();


                DataSet dataSet = new DataSet();


                string toursQuery = "SELECT * FROM Туры";
                string touristsQuery = "SELECT * FROM Туристы";


                DataTable toursTable = new DataTable("Туры");
                DataTable touristsTable = new DataTable("Туристы");


                OleDbDataAdapter toursAdapter = new OleDbDataAdapter(toursQuery, connection);
                toursAdapter.Fill(toursTable);

                OleDbDataAdapter touristsAdapter = new OleDbDataAdapter(touristsQuery, connection);
                touristsAdapter.Fill(touristsTable);

                dataSet.Tables.Add(toursTable);
                dataSet.Tables.Add(touristsTable);
                //s


                dataGridTours.ItemsSource = dataSet.Tables["Туры"].DefaultView;
                dataGridTourists.ItemsSource = dataSet.Tables["Туристы"].DefaultView;


                int tourCodeToDelete = 5;
                string deleteTourQuery = "DELETE FROM Туры WHERE КодТура = 2";
                OleDbCommand deleteTourCommand = new OleDbCommand(deleteTourQuery, connection);
                deleteTourCommand.Parameters.AddWithValue("@TourCode", tourCodeToDelete);
                int deletedRows = deleteTourCommand.ExecuteNonQuery();

                Console.WriteLine("Удалено {0} записей", deletedRows);


                int touristIdToUpdate = 1;
                string newName = "Антон";
                string updateTouristQuery = "UPDATE Туристы SET Имя = NewName WHERE TouristId = TouristId";
                OleDbCommand updateTouristCommand = new OleDbCommand(updateTouristQuery, connection);
                updateTouristCommand.Parameters.AddWithValue("NewName", newName);
                updateTouristCommand.Parameters.AddWithValue("TouristId", touristIdToUpdate);
                int updatedRows = updateTouristCommand.ExecuteNonQuery();

                Console.WriteLine("Изменено {0} записей", updatedRows);
            }
        }
    }
}
