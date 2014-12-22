using Faktury.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

public class VersionChecker
{
    public static string latestVersion = null;
    
    public static bool IsNewUpdate(string currentVersion)
    {
        if(CheckForInternetConnection())
        {
            OpenSqlConnection();
            if(currentVersion == null)
            {
                return true;
            }
            if(latestVersion != null)
            {
                if(Version.Parse(latestVersion).CompareTo(Version.Parse(currentVersion)) > 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private static void OpenSqlConnection()
    {
        string connectionString = GetConnectionString();
        string queryString = "SELECT * FROM Faktury";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    latestVersion = reader[1].ToString();
                }
            }
            finally
            {
                reader.Close();
            }
        }
    }

    internal static void OpenSqlConnectionUpdate()
    {
        string connectionString = GetConnectionString();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("DELETE FROM Faktury", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();

            command = new SqlCommand("INSERT INTO Faktury ([ID], Version) VALUES (1, " + "'"+ Application.ProductVersion +"')", connection);
            connection.Open();
            reader = command.ExecuteReader();
            connection.Close();
        }
    }

    private static string GetConnectionString()
    {
        return "Data Source=Faktury.mssql.somee.com;Persist Security Info=True;User ID=Muchaszewski_SQLLogin_1;Password=3et91hp9dt";
    }

    public static bool CheckForInternetConnection()
    {
        try
        {
            using (var client = new WebClient())
            using (var stream = client.OpenRead("http://www.google.com"))
            {
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

}