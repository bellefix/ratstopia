using MySqlConnector;
using Dapper;

public class member
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopia;Uid=root;");
        return connection;
    }
    public void BecomeANewMember(string name, string lastname, string address, string mail, string phonenumber)
    {
        Connection().Query($"INSERT INTO customer @ (name, lastname, address, mail, phonenumber) VALUES ('{name}', '{lastname}', '{address}', '{mail}', '{phonenumber}');");
    }
}