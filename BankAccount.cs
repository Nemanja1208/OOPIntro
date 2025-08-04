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

        public virtual void PrintBalance()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance} kr");
        }
    }

    public class BusinessAccount : BankAccount
    {
        public string CompanyName { get; set; }

        public override void PrintBalance()
        {
            Console.WriteLine($"Business: {CompanyName} (Holder: {AccountHolder}), Balance: {Balance} kr");
        }
    }
}
