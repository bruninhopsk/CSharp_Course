namespace Exercise.Contructors.Overload.Encapsulation.This.Entities
{
    public class Account
    {
        private double _taxToWithdraw = 5.00;
        public string AccountNumber { get; private set; }
        public double Amount { get; private set; }
        public string Name { get; set; }

        public Account(string accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }

        public Account(string accountNumber, string name, double amount) : this(accountNumber, name)
        {
            this.Deposit(amount);
        }

        public void Withdraw(double amount) => Amount -= amount + _taxToWithdraw;

        public void Deposit(double amount) => Amount += amount;

        public override string ToString()
        {
            return $"AccountNumber: {AccountNumber} Name: {Name} Balance: ${Amount.ToString("F2")}";
        }
    }
}