using System.Data;
using System.Data.OleDb;

class Program
{
    static void Main()
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SISDRUG\Desktop\Zadanie_31\Zadanie_31\Turisty.mdb;";

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM Туры";
            OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection);
            DataSet ds = new DataSet();
            if (adapter != null && ds != null)
            {
                adapter.Fill(ds);
                Console.WriteLine("не пустой");
                // Другие операции с данными...
            }
            if (ds != null && ds.Tables.Count > 0)
            {
                Console.WriteLine("не пустой");
            }

            OleDbDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Название"]);
            }

            /*
            Console.WriteLine(ds.Tables["Table"].Rows[0].ItemArray);
            DataRow userRowToDelete = ds.Tables["Table"].Rows[0];
            Console.WriteLine(string.Join("\n", userRowToDelete[1]));

            if (userRowToDelete != null)
            {
                userRowToDelete.Delete();
                adapter.Update(ds, "Туры");
            }
            */
            reader.Close();
        }

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM Туристы";
            OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection);
            DataSet ds = new DataSet();
            if (adapter != null && ds != null)
            {
                adapter.Fill(ds);
                Console.WriteLine("не пустой");
                // Другие операции с данными...
            }
            if (ds != null && ds.Tables.Count > 0)
            {
                Console.WriteLine("не пустой");
            }

            DataRow newRow = ds.Tables["Table"].NewRow();
            newRow[1] = "Стефанов";
            newRow[2] = "Андрей";
            newRow[3] = "Максимильянов";

            ds.Tables["Table"].Rows.Add(newRow);

            adapter.Update(ds, "Туристы");

            DataRow userRow = ds.Tables["Table"].Rows.Find("Стефанов");
            if (userRow != null)
            {
                userRow["Имя"] = "Максим";
                adapter.Update(ds, "Туристы");
            }
        }
    }
}
