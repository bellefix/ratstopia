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
        WriteLine(name + lastname + address + mail + phonenumber);
    }
}