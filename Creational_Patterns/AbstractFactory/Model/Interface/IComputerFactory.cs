using System;
namespace AbstractFactory.Model.Interface
{
    /// <summary>
    /// The AbstractFactory interface
    /// </summary>
    public interface IComputerFactory
    {
        INotebook CreateNotebook(string owner);
        IDesktop CreateDesktop(string owner);
    }
}
