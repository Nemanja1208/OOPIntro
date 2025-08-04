namespace OOPIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            myAccount.AccountHolder = "Anna Andersson";
            myAccount.Deposit(1000);
            myAccount.Withdraw(250);
            myAccount.PrintBalance(); // Output: Account Holder: Anna Andersson, Balance: 750 kr
        }
    }
}
