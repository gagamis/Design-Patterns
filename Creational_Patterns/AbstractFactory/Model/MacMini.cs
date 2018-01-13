using System;
namespace AbstractFactory.Model
{
    public class MacMini : IDesktop
    {
        private readonly string _owner;

        public MacMini(string owner)
        {
            this._owner = owner;
        }

        void IDesktop.GetType() => Console.WriteLine($"This is {_owner} Mac Mini desktop computer");
    }
}
