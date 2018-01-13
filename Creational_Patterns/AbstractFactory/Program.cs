using System;
using AbstractFactory.Model;
using AbstractFactory.Model.Interface;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Design Patterns!");
            Console.WriteLine();

            // Create and run the DELL factory
            IComputerFactory dell = new DellFactory();
            Console.WriteLine();

            // I need a dell desktop computer
            var newDellDesktopOfMine = dell.CreateDesktop("my new");
            newDellDesktopOfMine.GetType();

            // My brother need a dell notebook
            var newMacbookOfMyBrother = dell.CreateNotebook("my brother`s new");
            newMacbookOfMyBrother.GetType();

            Console.WriteLine();

            // Create and run Apple factory
            IComputerFactory apple = new AppleFactory();
            Console.WriteLine();

            // My new MacBook Pro
            var newMacbookOfMine = apple.CreateNotebook("my new");
            newMacbookOfMine.GetType();

            // My brother`s new Mac Mini desktop computer
            var newMacMiniOfMyBrother = apple.CreateDesktop("my brother`s new");
            newMacbookOfMyBrother.GetType();

            Console.ReadLine();
        }
    }
}
