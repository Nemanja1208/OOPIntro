namespace OOPIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ABSTRAKTION exempel
            Account myAccount = new BankAccount(); // abstrakt typ, konkret implementation
            myAccount.AccountHolder = "Sara Svensson";

            myAccount.Deposit(2000);
            myAccount.Withdraw(500);
            myAccount.PrintSummary(); // Output: [Privatkonto] Sara Svensson - Saldo: 1500 kr
        }
    }
}
