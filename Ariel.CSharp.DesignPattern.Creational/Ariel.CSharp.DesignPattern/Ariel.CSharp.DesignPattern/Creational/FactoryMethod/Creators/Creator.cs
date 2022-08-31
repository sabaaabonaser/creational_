
using Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Products;

namespace Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Creators
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();
            // Now, use the product.
            string result = "Creator: The same creator's code has just worked with "
                         + product.Operation();

            return result;
        }
    }
}
