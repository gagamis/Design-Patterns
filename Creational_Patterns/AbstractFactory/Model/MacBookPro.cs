using System;
namespace AbstractFactory.Model
{
    public class MacBookPro : INotebook
    {
        private readonly string _owner;

        public MacBookPro(string owner)
        {
            this._owner = owner;
        }

        void INotebook.GetType() => Console.WriteLine($"This is {_owner} Macbook Pro notebook");
    }
}
