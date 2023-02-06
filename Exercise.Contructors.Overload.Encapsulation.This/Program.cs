using Exercise.Contructors.Overload.Encapsulation.This.Entities;

namespace Exercise.Contructors.Overload.Encapsulation.This
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account;
            Console.Write("Enter the account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter owner of the account: ");
            string ownerAccount = Console.ReadLine();

            Console.Write("Will there be an initial deposit (s/n)? ");
            char response = char.Parse(Console.ReadLine());

            if (response == 's' || response == 'S')
            {
                Console.Write("Inform the deposit amount: ");
                double amount = double.Parse(Console.ReadLine());
                account = new Account(accountNumber, ownerAccount, amount);
            }
            else
                account = new Account(accountNumber, ownerAccount);

            Console.WriteLine();
            Console.WriteLine($"Account data:\n{account.ToString()}");
            Console.WriteLine();

            Console.Write("Enter the deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine($"Account data updated:\n{account.ToString()}");
            Console.WriteLine();

            Console.Write("Enter the withdraw amount: ");
            double withdrawAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);
            Console.WriteLine($"Account data updated:\n{account.ToString()}");
        }
    }
}
