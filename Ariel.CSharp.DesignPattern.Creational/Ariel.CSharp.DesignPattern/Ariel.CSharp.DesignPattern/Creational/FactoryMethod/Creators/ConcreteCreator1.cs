using Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Products;

namespace Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Creators
{
    class ConcreteCreator1:Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
