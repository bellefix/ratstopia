using MySqlConnector;
using Dapper;

public class DB
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopia;Uid=root;");
        return connection;
    }
}