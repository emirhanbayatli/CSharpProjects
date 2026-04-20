using System;

namespace InheritanceExample
{
    internal class CheckingAccount : BankAccount
    {


        public CheckingAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void Withdraw(decimal amount)
        {

            if (Balance - amount >= -1000)
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
