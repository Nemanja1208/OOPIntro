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

            // ARV exempel
            SavingsAccount mySavings = new SavingsAccount();
            mySavings.AccountHolder = "Alex Andersson";
            mySavings.InterestRate = 0.05m; // 5% ränta

            mySavings.Deposit(1000);
            mySavings.ApplyInterest();
            mySavings.PrintBalance(); // Saldo bör nu vara 1050 kr
        }
    }
}
