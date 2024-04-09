using System;
using System.Data.OleDb;

class Program
{
    static void Main()
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SISDRUG\Desktop\Zadanie_30\Zadanie_30\Turisty.mdb;";

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();

            // Выполнение SQL-запроса
            string sqlQuery = "SELECT * FROM Туры";
            using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Обработка результатов запроса
                        Console.WriteLine(("----------------------------------------------------"));
                        Console.WriteLine("Код тура " + reader["Код тура"]);
                        Console.WriteLine("Название "+reader["Название"]);
                        Console.WriteLine("Цена "+reader["Цена"]);
                        Console.WriteLine("Информация " + reader["Информация"]);
                        Console.WriteLine(("----------------------------------------------------"));
                    }
                }
            }

            string deleteQuery = "DELETE FROM Туры WHERE Название = '1111'";

            using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection))
            {
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Запись успешно удалена!");
            }


            using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Обработка результатов запроса
                        Console.WriteLine(("----------------------------------------------------"));
                        Console.WriteLine("Код тура " + reader["Код тура"]);
                        Console.WriteLine("Название " + reader["Название"]);
                        Console.WriteLine("Цена " + reader["Цена"]);
                        Console.WriteLine("Информация " + reader["Информация"]);
                        Console.WriteLine(("----------------------------------------------------"));
                    }
                }
            }

            string insertQuery = "INSERT INTO  Туристы (Фамилия, Имя, Отчество) VALUES ('Jane', 'Doe', 21)";

            using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
            {
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Новая запись успешно добавлена!");
            }

            sqlQuery = "SELECT * FROM Туристы";
            using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Обработка результатов запроса
                        Console.WriteLine(("----------------------------------------------------"));
                        Console.WriteLine("Код туриста " + reader["Код туриста"]);
                        Console.WriteLine("Фамилия " + reader["Фамилия"]);
                        Console.WriteLine("Имя " + reader["Имя"]);
                        Console.WriteLine("Отчество " + reader["Отчество"]);
                        Console.WriteLine(("----------------------------------------------------"));
                    }
                }
            }

            string updateQuery = "UPDATE Туристы SET Имя = 'Антон' WHERE Фамилия = 'Jane'";

            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
            {
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("Запись успешно обновлена!");
            }

            using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Обработка результатов запроса
                        Console.WriteLine(("----------------------------------------------------"));
                        Console.WriteLine("Код туриста " + reader["Код туриста"]);
                        Console.WriteLine("Фамилия " + reader["Фамилия"]);
                        Console.WriteLine("Имя " + reader["Имя"]);
                        Console.WriteLine("Отчество " + reader["Отчество"]);
                        Console.WriteLine(("----------------------------------------------------"));
                    }
                }
            }

        }
    }
}
