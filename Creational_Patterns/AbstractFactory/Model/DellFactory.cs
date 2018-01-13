using System;
using AbstractFactory.Model.Interface;

namespace AbstractFactory.Model
{
    /// <summary>
    /// DELL ConcreteFactory class
    /// </summary>
    public class DellFactory : IComputerFactory
    {
        public DellFactory()
        {
            Console.WriteLine("Del factory ready to serve");
        }

        public IDesktop CreateDesktop(string owner)
        {
            return new DellDesktop(owner);
        }

        public INotebook CreateNotebook(string owner)
        {
            return new DellNotebook(owner);
        }
    }
}
