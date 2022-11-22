using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;
using AtmConsoleAppInThreeLanguages.Properties;

namespace AtmConsoleAppInThreeLanguages.Transactions
{
    internal static class ChooseTransaction
    {
        public static void ChooseTransactionType(string usersAccountName)
        {

            Welcome.Message($"Welcome {usersAccountName}\n\t", "Choose 1-3 for your preffered transactions\n");
            Welcome.Message("\t\t1.\t", "Deposit\n");
            Welcome.Message("\t\t2.\t", "Withdrawal\n");
            Welcome.Message("\t\t.3\t", "Transfer\n");
            Welcome.Message("\t\t4.\t", "Check Balance\n");

        }

        public static void CheckBalance(decimal accountBalance, string userfullName)
        {
            try
            {
                Console.WriteLine($"{userfullName} Your new balance is {accountBalance}");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public static void Deposit(int AccountNumber, decimal AccountBalance, string AccountFullName)
        {

            try
            {

                Console.WriteLine("Enter Amount");
                int AmountToDeposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Account Number");

                int DepositAccountNumber = Convert.ToInt32(Console.ReadLine());
                if (AccountNumber.Equals(DepositAccountNumber))
                {
                    decimal newBalance = AccountBalance += AmountToDeposit;
                    Welcome.Message($"\n{AccountFullName}\t", $"Your made a deposit of {AmountToDeposit} in your account. Your new balance is\t : {newBalance} ");
                }
                else
                {
                    Welcome.Message("\nError:\t", "Try Again\n");
                }
            }
            catch (Exception errorException)
            {

                Welcome.Message("\nError:\t", $"{errorException.Message}");
                return;
            }
        }
         public static void Withdrawal(int AccountNumber, decimal AccountBalance, string AccountFullName)
        {

            try
            {
                
                Console.WriteLine("Enter Amount");
                int amountToWidthraw = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Account Number");

                int DepositAccountNumber = Convert.ToInt32(Console.ReadLine());
                if (AccountNumber.Equals(DepositAccountNumber))
                {
                    decimal newBalance = AccountBalance -= amountToWidthraw;
                    Welcome.Message($"\n{AccountFullName}\t", $"Your just withdrawed {amountToWidthraw} from your account, your new balance is:\t {newBalance} ");
                }
                else
                {
                    Welcome.Message("\nError:\t", "Try Again\n");
                }
            }
            catch (Exception errorException)
            {

                Welcome.Message("\nError:\t", $"{errorException.Message}");
                return;
            }
        }

        public static void Transfer(int AccountNumber, decimal SenderAccountBalance, decimal ReceiverAccountNumber, int ReceierAccountNumber, string SenderFullName, string ReceiverFullName)
        {
            try
            {

                Console.WriteLine("Enter Amount");
                int AmountToTransfer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Account Number");

                int PayerAccountNumber = Convert.ToInt32(Console.ReadLine());
                if (AccountNumber.Equals(PayerAccountNumber))
                {
                 
                }
                else
                {
                    Welcome.Message("Error:", "Account number does not exist. Try Again\n");
                }
            }
            catch (Exception exception)
            {

                Welcome.Message("\nError:", $"{exception.Message}");

            }
        } 
    }
}
