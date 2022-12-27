using MySqlConnector;
using Dapper;

public class Products
{
    public string? product { get; set; }
    public int price { get; set; }

    public MySqlConnection Connection()
    {
        MySqlConnection connection = new();
        connection = new MySqlConnection("Server=localhost;Database=ratstopiaDB;Uid=root;");
        return connection;
    }

    public int getProducts(string product)
    {
        int product_id = Connection().Query<int>($"SELECT id FROM products WHERE product = '{product}'").Single();
        return product_id;
    }
    public void addToOrder(int order_id, int product_id)
    {
        Connection().Query($" INSERT into products_to_order (order_id, product_id) VALUES ({order_id}, {product_id})");       
    }
}