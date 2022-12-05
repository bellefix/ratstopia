using MySqlConnector;
using Dapper;
public class Rats
{
    public bool is_available { get; set; }
    public string? name {get; set; }
    public string? age { get; set; }
    public string? details { get; set; }
    public string? gender { get; set; }
        public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopia;Uid=root;");
        return connection;
    }
    public List<Rats> AdoptionInfo()
    {
        List<Rats> allRatsInformation = Connection().Query<Rats>("SELECT is_available, name, age, details, gender FROM rats;").ToList();
        return allRatsInformation;
    }
}