
namespace Ariel.CSharp.DesignPattern.Creational.Singleton
{
    public class DoubleCheckLockSingleton: SingletonAbc
    {
        DoubleCheckLockSingleton() { }
        private static readonly object sr_LockObj = new object ();  
        private static DoubleCheckLockSingleton s_Instance;
        public static DoubleCheckLockSingleton Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new DoubleCheckLockSingleton();
                        }
                    }
                }
                return s_Instance;
            }
        }
    }
}
