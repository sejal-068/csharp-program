using System.Data.SqlClient;

string conn = "Server=yourserver;Database=db;User Id=user;Password=pass;";

using SqlConnection con = new SqlConnection(conn);
con.Open();

Console.WriteLine("Connected to Azure SQL");