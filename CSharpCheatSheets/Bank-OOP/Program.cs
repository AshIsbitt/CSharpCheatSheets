using System;

namespace Bank_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object
            var account = new BankAccount("Delilah", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
        }
    }
}
