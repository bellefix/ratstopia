using static System.Console;
public class UI
{
    public ConsoleKey menuKeys = ConsoleKey.NoName;
    List<string> productsToBuy = new List<string>();
    int order_id;
    string memberRole = "member";
    public void menuUI()
    {
        Clear();
        while (true)
        {
            WriteLine("\n>> RATSTOPIA <<\n");
            WriteLine("Wellcome to Ratstopia, what would you like to do?");
            WriteLine("1* Become a member.");
            WriteLine("2* Check rats ready for adoption.");
            WriteLine("3* Visit the store.");
            menuKeys = ReadKey(true).Key;

            switch (menuKeys)
            {
                case ConsoleKey.D1:
                BecomeAMember();
                ReadKey();
                break;

                case ConsoleKey.D2:
                RatsAvailable();
                ReadKey();
                break;

                case ConsoleKey.D3:
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
        Members member = new Members();
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
        int member_id =  member.MemberRole(memberRole);
        WriteLine("Your member-information: " +name+ " " +lastname+ ", " +address+ ", " +mail+ ", " +phonenumber+ "," + username);
        member.BecomeANewMember(name, lastname, address, mail, phonenumber, member_id, username, password);
    }
    public void RatsAvailable()
    {
        Clear();
        List<Rats> allRats = new();
        Rats allRatsInformation = new Rats();
        WriteLine(">> All published rats for adoption:\n");
        allRats = allRatsInformation.AdoptionInfo();
        foreach (var rats in allRats)
        {
            WriteLine("Is Available: " + rats.is_available + " " + ". Name: " + rats.name + ". Age: " + rats.age + ". Details: " + rats.details + ". Gender: " + rats.gender + ".");
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
        order_id = newOrder.OrderDB(customer_id);
        foreach (var product in productsToBuy)
        {
            int product_id = productsToOrder.GetProducts(product);
            order_id = productsToOrder.GetProducts(product);
            productsToOrder.AddToOrder(order_id, product_id);
        }
    }
    public void StoreMode()
    {   
        Clear();
        WriteLine(">> Wellcome to ratstopia store.\n");
        WriteLine("By purshasing items from our store you'll be supporting our work.");
        WriteLine("Proceeds goes directly to the business.\n");
        
        WriteLine("What do you wanna purshase today?");
        WriteLine("[1] Rat-Calendar 2023-2024");
        WriteLine("[2] Ratstopias Rat-Food");
        WriteLine("[3] Ratstopias Post-Card\n");
        WriteLine("[4] Check shopping cart.");
        WriteLine("[5] Continue to check-out.\n");
        WriteLine("[6] Go back to main menu.");
        menuKeys = ReadKey(true).Key;

        switch (menuKeys)
        {
            case ConsoleKey.D1:
            Clear();
            productsToBuy.Add("Rat-Calendar 2023-2024");
            WriteLine("Rat-Calendar has now been added to your cart.");
            ReadKey();
            StoreMode();
            break;

            case ConsoleKey.D2:
            Clear();
            productsToBuy.Add("Ratstopias Rat-Food");
            WriteLine("Ratstopias Rat-Food has now been added to your cart.");
            ReadKey();
            StoreMode();
            break;

            case ConsoleKey.D3:
            Clear();
            productsToBuy.Add("Ratstopias Post-Card");
            WriteLine("Ratstopias Post-Card has now been added to your cart.");
            ReadKey();
            StoreMode();
            break;

            case ConsoleKey.D4:
            Clear();
            WriteLine("Your shopping-cart:");
            foreach (string item in productsToBuy)
            {
                WriteLine(item);
            }
            ReadKey();
            StoreMode();
            break;

            case ConsoleKey.D5:
            Clear();
            CreateCustomer();
            break;

            case ConsoleKey.D6:
            menuUI();
            break;
        }

    }
}