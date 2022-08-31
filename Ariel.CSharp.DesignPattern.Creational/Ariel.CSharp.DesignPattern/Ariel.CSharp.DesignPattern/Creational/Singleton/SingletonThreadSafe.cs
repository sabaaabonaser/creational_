using System;

namespace Ariel.CSharp.DesignPattern.Creational.Singleton
{
    public class SingletonThreadSafe : SingletonAbc
    {
        private SingletonThreadSafe() { }
        private static readonly object sr_LockObj = new object ();  
        private static SingletonThreadSafe s_Instance;
        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (sr_LockObj)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new SingletonThreadSafe();
                    }
                    return s_Instance;

                    //Or instead
                    //return instance ?? (instance = new SingletonThreadSafe());
                }
            }
        }

        public void MyClassJob()
        {
            Console.WriteLine("Doing my job");
        }
    }
}
