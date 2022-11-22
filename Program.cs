

using AtmConsoleAppInThreeLanguages.Properties;

namespace ATMCONSOLEAPPINTHREELANGUAGE;
internal class Program
{
    private static void Main(string[] args)
    {
       
        UserAccount userAccount = new UserAccount();
    Console.WriteLine(userAccount.FullName);
    Welcome.RunWelcome();
        }
    }

