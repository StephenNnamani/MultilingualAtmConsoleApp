using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Enums;
using AtmConsoleAppInThreeLanguages.Properties;
using AtmConsoleAppInThreeLanguages.Transactions;
using System.Security.Principal;

namespace AtmConsoleAppInThreeLanguages.Implementations
{
    internal class LoginValidation
    {
        public List<UserAccount> _userAccountList;
        private int _userAccountNumberInput;
        private int _userCardPin;
        private static string Options { get; set; }
        private static int userInput { get; set; }

        public LoginValidation()
        {
            _userAccountList = new List<UserAccount>()
            {
                new UserAccount()
                {
                    UserId = 1,
                    CardPin = 423234,
                    CardNumber = 123456789,
                    AccountNumber = 0669976019,
                    AccountBalance = 500000000,
                    AccountName = "Kelechi Amos",
                    FullName = "Kelechi Amos Omeh",
                    Bank = "Gt Bank",
                    Location = "New York City, London"
                },
                new UserAccount()
                {
                    UserId = 2,
                    CardPin = 123231,
                    CardNumber = 987654321,
                    AccountNumber = 423710377,
                    AccountBalance = 600000000,
                    AccountName = "Kennedy",
                    FullName = "John Kennedy",
                    Bank = "Access Bank",
                    Location = "San Francisco, America"
                },new UserAccount()
                {
                    UserId = 3,
                    CardPin = 565656,
                    CardNumber = 656565,
                    AccountNumber = 123456789,
                    AccountBalance = 600000000,
                    AccountName = "Kingsley",
                    FullName = "Kingsley Somtoo",
                    Bank = "Daimond Bank",
                    Location = "Japan"
                }
            };
        }

        public void LoginVal()
        {
           
            try 
            {
                Welcome.Message("\nPlease:\t", "Enter you details for security purposes\n");
                Welcome.Message("\nPlease:\t", "Enter you Account Number\n");
                _userAccountNumberInput = int.Parse(Console.ReadLine());
                Welcome.Message("\nPlease:\t", "Enter you CardPin\n");
                _userCardPin = int.Parse(Console.ReadLine());

                foreach (var account in _userAccountList)
                {
                    var userAccountNumber = account.AccountNumber;
                    var userCardPin = account.CardPin;
                    if (userAccountNumber == _userAccountNumberInput && _userCardPin == userCardPin)
                    {
                        while (true)
                        {
                            getUser(account, userAccountNumber);
                            break;
                        }
                    }
                   /* else
                        {
                            Console.Clear();
                            Welcome.Message("\nError:\t", "User does'nt Exist");
                            LoginVal();
                        }*/
                }
            }
            catch (Exception exception)
            {
                Console.Clear();
                Welcome.Message("\nPlease:\t", "Enter A valid inputs\n");
                Console.WriteLine(exception.Message);
                LoginVal();
            }
        }


        public static void getUser(UserAccount? account, int userAccountNumber)
        {
            ChooseTransaction.ChooseTransactionType(account.AccountName);

            try
            {
                Options = Console.ReadLine();

                userInput = Convert.ToInt32(Options);
                switch (userInput)
                {

                    case (int)TransactionType.Deposit:
                        ChooseTransaction.Deposit(userAccountNumber, account.AccountBalance, account.FullName);
                        break;
                    case (int)TransactionType.Widthdrawal:
                        ChooseTransaction.Withdrawal(userAccountNumber, account.AccountBalance, account.FullName);
                        break;
                    case (int)TransactionType.Transfer:
                        ChooseTransaction.Transfer(account.FullName, account.AccountBalance, account.AccountNumber);
                        break;
                    case (int)TransactionType.CheckBalance:
                        ChooseTransaction.CheckBalance(account.AccountBalance, account.FullName);
                        break;
                    default:
                        Console.WriteLine("Entered value is not in the case");
                        break;
                }
                
            }
            catch (Exception exception)
            {
                Welcome.Message("\nError:\t", exception.Message);
            }
        }

    

    }
}
