using System;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccess
{

    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=sqlserver;User ID=sa;Password=1q2w3e4r@#$";
            
            

            using(var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("conectado");
                
                var comand = new SqlCommand();
                comand.Connection = connection;
                comand.CommandType = System.Data.CommandType.Text;
                comand.CommandText = "SELECT [ID], [Title] FROM [Category]";

                var reader = comand.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                    }
            }

        }
    }
}