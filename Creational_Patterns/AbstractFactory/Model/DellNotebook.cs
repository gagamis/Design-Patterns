using System;
namespace AbstractFactory.Model
{
    public class DellNotebook : INotebook
    {
        private readonly string _owner;

        public DellNotebook(string owner)
        {
            this._owner = owner;
        }

        void INotebook.GetType() => Console.WriteLine($"This is {_owner} DELL notebook");
    }
}
