using MySqlConnector;
using Dapper;

public class Customer
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopiaDB;Uid=root;");
        return connection;
    }
    public int CreateNewCustomer(string name, string last_name, string address, string mail, string phone_number)
    {
        int returnCustomer = Connection().Query<int>($@"
        INSERT INTO customers (name, last_name, address, mail, phone_number)
        VALUES ('{name}', '{last_name}', '{address}', '{mail}', '{phone_number}');
        SELECT CAST(LAST_INSERT_ID() AS UNSIGNED INTEGER);").Single();
        return returnCustomer;
    }
}