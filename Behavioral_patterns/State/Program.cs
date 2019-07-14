using System;

namespace State
{
    class Program
    {
        // Context
        static Acount ctx = new Acount("Michael Night");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello State Design Pattern!");

            // Add 1000 HUF money to my acount
            Transaction(1_000); // normal member

            // Add 10000 HUF money to my acount
            Transaction(100_000); // normal member

            // Add 20000 HUF money to my acount
            Transaction(200_000); // silver member

            // WithDrowal 10000 HUF money to my acount
            Transaction(-100_000); // normal member

            // Add 50000 HUF money to my acount
            Transaction(500_000); // gold member

            // WithDrowal 50000 HUF money to my acount
            Transaction(-500_000); // normal member

            Console.ReadLine();
        }

        private static void Transaction(double amount)
        {
            ctx.Transaction(amount);

            // write transaction informations
            Console.WriteLine();
            Console.WriteLine($"----- TRANSACTION with {amount.ToString("C")} -----");
            Console.WriteLine($"balance: {ctx.State.Balance.ToString("C")}");
            Console.WriteLine($"membership: {ctx.State.Membership.ToString()}");
        }
        
    }
}
