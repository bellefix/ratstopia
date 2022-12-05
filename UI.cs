using static System.Console;
public class UI
{
    static ConsoleKey menuKeys = ConsoleKey.NoName;
    public void menuUI()
    {
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
                RatAdoption();
                ReadKey();
                break;

                case ConsoleKey.D3:
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
        string givenRoleId = "2";
        // Userinput goes into BecomeANewMember in Member and get saved down to database.
        // Members can only have roleid 2, therefor givenRoleId will always be 2.
        WriteLine("Your member-information: " +name+ " " +lastname+ ", " +address+ ", " +mail+ ", " +phonenumber);
        addNewMember.BecomeANewMember(name, lastname, address, mail, phonenumber, givenRoleId);
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
            WriteLine("Is available: " + rats.is_available + ". Name: " + rats.name + ". Age: " + rats.age + ". Details: " + rats.details + ". Gender: " + rats.gender + ".");
        }
    }
}