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

            // Test init balance is positive
            // try {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught: negative balance");
            //     Console.WriteLine(e.ToString());
            // }
            
            account.MakeWithdrawal(50, DateTime.Now, "xbox game");
            Console.WriteLine(account.Balance);

			Console.WriteLine(account.GetAccountHistory());

        }

    }
}
