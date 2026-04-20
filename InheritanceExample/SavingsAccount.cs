using System;

namespace InheritanceExample
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber) : base(accountNumber)
        {

        }

        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine($"Current Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal denied. Insufficient funds.");

            }

        }
    }
}
