
using System;

namespace Ariel.CSharp.DesignPattern.Creational.Singleton
{
    public class ThreadSafeEagerSingleton : SingletonAbc
    {
        private static readonly ThreadSafeEagerSingleton sr_Instance = new ThreadSafeEagerSingleton();
        static ThreadSafeEagerSingleton()
        {
        }
        private ThreadSafeEagerSingleton()
        {
        }
        public static ThreadSafeEagerSingleton Instance
        {
            get
            {
                return sr_Instance;
            }
        }
        //Or instead 
        //public static ThreadSafeEagerSingleton Instance => sr_Instance;


        //Or instead 
        //public static ThreadSafeEagerSingleton Instance { get; } = new ThreadSafeEagerSingleton();


        public void MyClassJob()
        {
            Console.WriteLine("Doing my job");
        }
    }
}
