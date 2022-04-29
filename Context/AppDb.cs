using MySql.Data.MySqlClient;

namespace ProjWork.context;

public class AppDb
{

    public MySqlConnection Connection { get; }

    private const string defaultConnectionString = "server=localhost;database=piattaforma_vaccini_v2;uid=root;pwd=maremmamaiala69;";

    public AppDb()
    {
        Connection = new MySqlConnection(defaultConnectionString);
    }
    public AppDb(string connectionString)
    {
        Connection = new MySqlConnection(connectionString);
    }



}