using System;

namespace InheritanceExample
{
    internal class BusinessAccount : BankAccount
    {
        public BusinessAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void Deposit(decimal amount)
        {

            decimal commission = amount * 0.01m;

            Console.WriteLine($"Commission charged: {commission}");

            Balance += (amount - commission);

            Console.WriteLine($"Deposit successful. Net amount added: {amount - commission}");
            Console.WriteLine($"Current Balance: {Balance}");

        }

        public override void Withdraw(decimal amount)
        {

            if (Balance - amount >= -5000)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine($"Current Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal denied. Overdraft limit exceeded.");
            }
        }
    }
}
