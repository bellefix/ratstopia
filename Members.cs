using MySqlConnector;
using Dapper;

public class Member
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopia;Uid=root;");
        return connection;
    }
    public void BecomeANewMember(string name, string last_name, string address, string mail, string phone_number, string role_id)
    {
        Connection().Query($"INSERT INTO members (name, last_name, address, mail, phone_number, role_id) VALUES ('{name}', '{last_name}', '{address}', '{mail}', '{phone_number}', '{role_id}');");
    }
}