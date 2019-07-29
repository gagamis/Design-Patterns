using System;

namespace FactoryMethod
{
    // The Creator class declares the factory method that is supposed to return an object of a IProduct interface. 
    // The Creator's subclasses overrides the implementation of this method.
    public abstract class Creator
    {
        // the factory method.
        public abstract IProduct FactoryMethod();

        public void SomeOperation()
        {
            // Call the factory method to create a Product object.
            IProduct product = FactoryMethod();

            // and do some operation on it 
            Console.WriteLine($"Creator worked with: {product.Operation()}");

        }
    }
}
