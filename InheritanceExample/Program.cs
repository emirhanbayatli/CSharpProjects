using System;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null;

            decimal withdrawAmount;
            decimal depositAmount;

            Console.WriteLine("=== Welcome to the Banking System ===");
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            Console.WriteLine("\nSelect Account Type:");
            Console.WriteLine("1 - Business Account");
            Console.WriteLine("2 - Checking Account");
            Console.WriteLine("3 - Savings Account");
            Console.Write("Your choice: ");

            int firstSelect = int.Parse(Console.ReadLine());


            switch (firstSelect)
            {
                case 1:
                    account = new BusinessAccount(accountNumber);
                    break;
                case 2:
                    account = new CheckingAccount(accountNumber);
                    break;
                case 3:
                    account = new SavingsAccount(accountNumber);
                    break;
                default:
                    Console.WriteLine("Invalid account type. Program terminated.");
                    return;
            }



            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Show Balance");
                Console.WriteLine("0 - Exit");
                Console.Write("Select an option: ");

                int operation = int.Parse(Console.ReadLine());

                if (operation == 0)
                {
                    Console.WriteLine("Thank you for using the Banking System.");
                    break;
                }

                switch (operation)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        withdrawAmount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;

                    case 3:
                        Console.WriteLine($"Current Balance: {account.Balance}");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

        }
    }
}
