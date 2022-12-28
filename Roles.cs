using MySqlConnector;
using Dapper;

public class Roles
{
    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopiaDB;Uid=root;");
        return connection;
    }
    public void BecomeANewMember(string name, string last_name, string address, string mail, string phone_number, int role_id, string username, string password)
    {
        Connection().Query($@"INSERT INTO members (name, last_name, address, mail, phone_number, 
        role_id, username, password) VALUES ('{name}', '{last_name}', '{address}', '{mail}', 
        '{phone_number}', {role_id}, '{username}', '{password}');");
    }

    public void GetMembersFromDatabase(string username, string password)
    {
        var queryLogin = Connection().Query($"SELECT username, password FROM members");
    }

    public int MemberRole(string member)
    {
        int member_id = Connection().Query<int>(@$"SELECT id FROM roles 
        WHERE role_name = '{member}'; SELECT CAST(LAST_INSERT_ID() AS UNSIGNED INTEGER);").Single();
        return member_id;
    }
}