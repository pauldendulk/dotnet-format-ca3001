using System.Data.SqlClient;
using System.Data;

Console.WriteLine("Hello, World!");

string? name = Console.ReadLine();
using SqlConnection connection = new("my connection string");
SqlCommand sqlCommand = new()
{
    CommandText = "SELECT ProductId FROM Products WHERE ProductName = '" + name + "'",
    CommandType = CommandType.Text,
};
SqlDataReader reader = sqlCommand.ExecuteReader();