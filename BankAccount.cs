namespace OOPIntro
{
    public abstract class Account
    {
        public string AccountHolder { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract decimal GetBalance();

        public virtual void PrintSummary()
        {
            Console.WriteLine($"Konto för: {AccountHolder}, Saldo: {GetBalance()} kr");
        }
    }

    public class BankAccount : Account
    {
        private decimal balance;

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public override decimal GetBalance()
        {
            return balance;
        }

        public override void PrintSummary()
        {
            Console.WriteLine($"[Privatkonto] {AccountHolder} - Saldo: {balance} kr");
        }
    }
}
