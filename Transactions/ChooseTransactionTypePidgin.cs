using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;

namespace AtmConsoleAppInThreeLanguages.Transactions
{
    internal class ChooseTransactionTypePidgin
    {

        public static void ChooseTransactionType(string usersAccountName)
        {

            Welcome.Message($"Welcome {usersAccountName}\n\t", "Put 1-3 \n");
            Welcome.Message("\t\t1.\t", "Pick One for Deposit\n");
            Welcome.Message("\t\t2.\t", "Shey nah withdrawal you won do\n");
            Welcome.Message("\t\t3.\t", "Abi nah Transfer\n");
            Welcome.Message("\t\t4.\t", "Or Abi nah Your Balance your won check\n");

        }

        public static void CheckBalance(decimal accountBalance, string userfullName)
        {
            try
            {
                Console.WriteLine($"{userfullName} Gee your new balance nah {accountBalance}");


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

                Console.WriteLine("Gee put Amount");
                int AmountToDeposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Put Account Number");

                int DepositAccountNumber = Convert.ToInt32(Console.ReadLine());
                if (AccountNumber.Equals(DepositAccountNumber))
                {
                    decimal newBalance = AccountBalance + AmountToDeposit;
                    Welcome.Message($"\n{AccountFullName}\t", $"You deposited {AmountToDeposit} in your account. Your new balance nah\t : {newBalance} ");
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
        public static void Withdrawal(decimal AccountBalance, string AccountFullName)
        {

            try
            {

                Console.WriteLine("Enter Amount");
                int amountToWidthraw = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Account Number");

                int DepositAccountNumber = Convert.ToInt32(Console.ReadLine());
                    decimal newBalance = AccountBalance -= amountToWidthraw;
                    Welcome.Message($"\n{AccountFullName}\t", $"You just removed {amountToWidthraw} for your account, your new balance nah:\t {newBalance} ");
            }
            catch (Exception errorException)
            {

                Welcome.Message("\nError:\t", $"{errorException.Message}");
                return;
            }
        }

        public static void Transfer(string SenderFullName, decimal SenderAccountBalance, int SenderAccountNumber)
        {
            try
            {
                LoginValInEnglish loginValidation = new LoginValInEnglish();
                var account = loginValidation._userAccountList;
                foreach (var user in account)
                {


                    Console.WriteLine("Put Amount");
                    decimal AmountToTransfer = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Put Account Number");

                    int ReceiverAccountNumberInput = Convert.ToInt32(Console.ReadLine());
                    var currentUser = account.FirstOrDefault(specificUser => specificUser.AccountNumber == ReceiverAccountNumberInput);
                    if (SenderAccountNumber == currentUser.AccountNumber)
                    {
                        Console.WriteLine("Ahh You won transfer money to your self!! No nah");
                    }
                    else if (SenderAccountBalance < AmountToTransfer)
                    {
                        Console.WriteLine("Your Balance no reach gee");
                    }
                    else
                    {
                        currentUser.AccountBalance += AmountToTransfer;
                        SenderAccountBalance -= AmountToTransfer;
                        Console.WriteLine($"{SenderFullName} you sent {AmountToTransfer} to {currentUser.FullName} and we don remove {AmountToTransfer} for your account");
                        Welcome.Message($"\n{SenderFullName} Your new balance nah", $"{SenderAccountBalance}");
                    }
                    LoginValidationInPidgin.getUser(user, user.AccountNumber);
                }
            }
            catch (Exception exception)
            {
                Welcome.Message("\nProblem:", $"{exception.Message}");

            }
        }
       
    }
}

