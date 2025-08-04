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

            // POLYMORFISM exempel
            BusinessAccount företagKonto = new BusinessAccount();
            företagKonto.AccountHolder = "Kalle Karlsson";
            företagKonto.CompanyName = "ACME AB";
            företagKonto.Balance = 78000;
            företagKonto.PrintBalance();

        }
    }
}
