using System;
using Ariel.CSharp.DesignPattern.Creational;

namespace Ariel.CSharp.DesignPattern
{
    public class Program
    {
        public static void Main(string[] i_Args)
        {
            CreationalDpMain creationals = new CreationalDpMain();

            Console.WriteLine("======================Singleton=======================================");
            creationals.SingletonEx();
            Console.WriteLine("======================FactoryMethod=======================================");
            creationals.FactoryMethod();
            Console.WriteLine("======================AbstractFactory=======================================");
            creationals.AbstractFactory();
            Console.WriteLine("======================Builder=======================================");
            creationals.BuidlerEx();
        }
    }
}
