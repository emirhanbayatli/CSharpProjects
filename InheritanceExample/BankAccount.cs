namespace InheritanceExample
{
    abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public abstract void Withdraw(decimal amount);


    }

}
