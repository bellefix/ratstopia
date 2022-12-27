using static System.Console;
public class UI
{
    static ConsoleKey menuKeys = ConsoleKey.NoName;
    int price = 169;
    string productName = "Rat-Calendar 2023-2024";
    public void menuUI()
    {
        while (true)
        {
            WriteLine("\n>> RATSTOPIA <<\n");
            WriteLine("Wellcome to Ratstopia, what would you like to do?");
            WriteLine("1* Become a member.");
            WriteLine("2* Login as member.");
            WriteLine("3* Check rats ready for adoption.");
            WriteLine("4* Visit the store.");
            menuKeys = ReadKey(true).Key;

            switch (menuKeys)
            {
                case ConsoleKey.D1:
                BecomeAMember();
                ReadKey();
                break;

                case ConsoleKey.D2:
                MemberLogin();
                ReadKey();
                break;

                case ConsoleKey.D3:
                RatAdoption();
                ReadKey();
                break;

                case ConsoleKey.D4:
                StoreMode();
                ReadKey();
                break;

                default:
                break;
            }               
        }
    }

    public void BecomeAMember()
    {
        Clear();
        Member addNewMember = new Member();
        WriteLine("Enter your firstname: ");
        string name = ReadLine()!;
        WriteLine("Enter your lastname: ");
        string lastname = ReadLine()!;
        WriteLine("Enter your address: ");
        string address = ReadLine()!;
        WriteLine("Enter your mail:");
        string mail = ReadLine()!;
        WriteLine("Enter your phone number: ");
        string phonenumber = ReadLine()!;
        WriteLine("Enter the username you wish to use: ");
        string username = ReadLine()!;
        WriteLine("Enter a password: ");
        string password = ReadLine()!;
        string givenRoleId = "2";
        // Userinput goes into BecomeANewMember in Member and get saved down to database.
        // Members can only have roleid 2, therefor givenRoleId will always be 2.
        WriteLine("Your member-information: " +name+ " " +lastname+ ", " +address+ ", " +mail+ ", " +phonenumber+ "," + username);
        addNewMember.BecomeANewMember(name, lastname, address, mail, phonenumber, givenRoleId, username, password);
    }
    public void MemberLogin() 
    { 
    }
    public void RatAdoption()
    {
        Clear();
        List<Rats> allRats = new();
        Rats allRatsInformation = new Rats();
        WriteLine(">> All published rats for adoption:\n");
        allRats = allRatsInformation.AdoptionInfo();
        foreach (var rats in allRats)
        {
            WriteLine(" " + " " + "Name: " + rats.name + ". Age: " + rats.age + ". Details: " + rats.details + ". Gender: " + rats.gender + ".");
        }
    }

    public void CreateCustomer()
    {
        Customer newCustomer = new Customer();
        Orders newOrder = new Orders();
        Products productsToOrder = new Products();
        WriteLine("Customer Info");
        WriteLine("Enter your firstname: ");
        string name = ReadLine()!;
        WriteLine("Enter your lastname: ");
        string last_name = ReadLine()!;
        WriteLine("Enter your address: ");
        string address = ReadLine()!;
        WriteLine("Enter your mail: ");
        string mail = ReadLine()!;
        WriteLine("Enter your phonenumber: ");
        string phone_number = ReadLine()!;
        int customer_id = newCustomer.CreateNewCustomer(name, last_name, address, mail, phone_number);
        int order_id = newOrder.OrderDB(customer_id);
        int product_id = productsToOrder.getProducts(productName);
        productsToOrder.addToOrder(order_id, product_id);
    }
    public void StoreMode()
    {
        Products buyProduct = new Products();
        Clear();
        WriteLine(">> Wellcome to ratstopia store.\n");
        WriteLine("By purshasing items from our store you'll be supporting our work.");
        WriteLine("Proceeds goes directly to the business.\n");
        
        WriteLine("Do you wanna purchase " + productName + price + "? [y]Yes [n]No");
        var key = ReadKey();

        if (key.KeyChar == 'y')
        {
            Clear();
            WriteLine("To continue with your purchase enter your personalinfo: ");
            CreateCustomer();   
        }
        else if (key.KeyChar == 'n')
        {
            Clear();
            WriteLine("Press any key to be returned to main menu.");
        }
        else
        {
            Clear();
            WriteLine("Incorrect input.");
        }
    }
}