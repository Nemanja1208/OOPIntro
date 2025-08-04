namespace OOPIntro
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance} kr");
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }
    }
}
