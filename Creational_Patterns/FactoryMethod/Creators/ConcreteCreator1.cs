using System;

namespace FactoryMethod
{
    // Concrete Creators derived from Creator abstract class
    // Concrete Creators override the factory method in order to change the resulting product's type.
    public class ConcreteCreator1 : Creator
    {
        // The signature of the method still uses the abstract product
        // This way the Creator can stay independent of concrete product classes.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
