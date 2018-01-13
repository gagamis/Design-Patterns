using System;
using AbstractFactory.Model.Interface;

namespace AbstractFactory.Model
{
    /// <summary>
    /// APPLE ConcreteFactory class
    /// </summary>
    public class AppleFactory : IComputerFactory
    {
        public AppleFactory()
        {
            Console.WriteLine("Apple factory ready to serve");
        }

        public IDesktop CreateDesktop(string owner)
        {
            return new MacMini(owner);
        }

        public INotebook CreateNotebook(string owner)
        {
            return new MacBookPro(owner);
        }
    }
}
