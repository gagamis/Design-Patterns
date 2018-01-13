using System;
namespace AbstractFactory.Model
{
    public class DellDesktop : IDesktop
    {
        private readonly string _owner;

        public DellDesktop(string owner)
        {
            this._owner = owner;
        }

        void IDesktop.GetType() => Console.WriteLine($"This is {_owner} DELL desktop computer");
    }
}
