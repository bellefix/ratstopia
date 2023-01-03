using MySqlConnector;
using Dapper;

public class Orders
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopiaDB;Uid=root;");
        return connection;
    }
    public int OrderDB(int customer_id)
    {
        int order_id = Connection().Query<int>(@$" INSERT into orders (customer_id)
        VALUES ({customer_id}); SELECT CAST(LAST_INSERT_ID() AS UNSIGNED INTEGER);").Single();
        return order_id;
    }
}