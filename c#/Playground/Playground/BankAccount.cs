using System;


namespace Playground
{
    class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("New bank account!");
        }
        public double Balance { get; set; } = 0;

        public virtual void Deposit(double n) => Balance += n;
        public void Withdraw(double n)
        {
            Balance -= n;
        }
        public double GetBalance()
        {
            return Balance;
        }
    }



}
