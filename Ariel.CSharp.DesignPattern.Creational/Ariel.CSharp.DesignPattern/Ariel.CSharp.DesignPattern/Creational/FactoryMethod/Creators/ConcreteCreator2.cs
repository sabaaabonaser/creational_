using Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Products;

namespace Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Creators
{
    class ConcreteCreator2:Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
