using System;

namespace Ariel.CSharp.DesignPattern.Creational.Singleton
{
    public class NaiveSingleton : SingletonAbc
    {
        private NaiveSingleton(){}

        private static NaiveSingleton s_Instance;

        public static NaiveSingleton Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    s_Instance = new NaiveSingleton();
                }
                return s_Instance;
                //Or instead
                //return instance ?? (instance = new SingletonThreadSafe());
            }
        }

        public void MyClassJob()
        {
            Console.WriteLine("Doing my job");
        }
    }
}
