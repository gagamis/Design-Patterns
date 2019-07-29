using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory Method!");

            Client client = new Client();

            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            Creator creator1 = new ConcreteCreator1();
            client.ClientCode(creator1);

            Console.WriteLine();

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            Creator creator2 = new ConcreteCreator2();
            client.ClientCode(creator2);

            Console.ReadLine();
        }
    }

    class Client
    {
        public void ClientCode(Creator creator)
        {
            Console.WriteLine("App: I'm not aware of the creator's class, but it still works.");
            creator.SomeOperation();
        }
    }
}
