using System;
using Ariel.CSharp.DesignPattern.Creational.AbstractFactory;
using Ariel.CSharp.DesignPattern.Creational.AbstractFactory.Ships;
using Ariel.CSharp.DesignPattern.Creational.Builder;
using Ariel.CSharp.DesignPattern.Creational.Builder.RobotBuilder;
using Ariel.CSharp.DesignPattern.Creational.Builder.RobotDAO;
using Ariel.CSharp.DesignPattern.Creational.FactoryMethod.Creators;
using Ariel.CSharp.DesignPattern.Creational.Singleton;

namespace Ariel.CSharp.DesignPattern.Creational
{
    public class CreationalDpMain
    {
        ///         Singleton
        public void SingletonEx()
        {
            NaiveSingleton singleton1 = NaiveSingleton.Instance;
            NaiveSingleton singleton2 = NaiveSingleton.Instance;

            SingletonThreadSafe singletonThreadSafe1 = SingletonThreadSafe.Instance;
            SingletonThreadSafe singletonThreadSafe2 = SingletonThreadSafe.Instance;
            
            DoubleCheckLockSingleton doubleCheckLockSingleton1 = DoubleCheckLockSingleton.Instance;
            DoubleCheckLockSingleton doubleCheckLockSingleton2 = DoubleCheckLockSingleton.Instance;


            ThreadSafeEagerSingleton threadSafeEagerSingleton1 = ThreadSafeEagerSingleton.Instance;
            ThreadSafeEagerSingleton threadSafeEagerSingleton2 = ThreadSafeEagerSingleton.Instance;


            PrintCheckSingletonInstance(singleton1, singleton2);

            PrintCheckSingletonInstance(singleton1, singletonThreadSafe1);

            PrintCheckSingletonInstance(singletonThreadSafe1, singletonThreadSafe2);

            PrintCheckSingletonInstance(doubleCheckLockSingleton1, doubleCheckLockSingleton2);

            PrintCheckSingletonInstance(threadSafeEagerSingleton1, threadSafeEagerSingleton2);
        }

        private void PrintCheckSingletonInstance(SingletonAbc i_Singleton1, SingletonAbc i_Singleton2)
        {
            if (i_Singleton1 == i_Singleton2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }

        ///         Abstract Factory 
        public void AbstractFactory()
        {
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            Console.WriteLine("Enter the type of the Ship - (U / R / B)");
            string typeOfShip = Console.ReadLine();

            EnemyShip enemyShip = shipFactory.MakeEnemyShip(typeOfShip);

            if(enemyShip != null)
            {
                doStuffWithTheEnemyShip();
            }

        }

        private void doStuffWithTheEnemyShip(){}


        ///         Factory Method
        public void FactoryMethod()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            clientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            clientCode(new ConcreteCreator2());
        }

        private void clientCode(Creator i_Creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                              "but it still works.\n" + i_Creator.SomeOperation());
        }


        ///         Builder
        public void BuidlerEx()
        {
            IRobotBuilder oldStyleRoot = new OldRobotBuilder();

            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRoot);

            robotEngineer.MakeRobot();

            Robot firstRobot = robotEngineer.GetRobot();

            Console.WriteLine("Robot Build");

            Console.WriteLine("Robot Head Type is : "+ firstRobot.GetRobotHead());

            Console.WriteLine("Robot Legs Type are : "+ firstRobot.GetRobotLegs());
        }

    }
}
