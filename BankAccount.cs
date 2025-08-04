namespace OOPIntro
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        private decimal Balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance} kr");
        }
    }
}
