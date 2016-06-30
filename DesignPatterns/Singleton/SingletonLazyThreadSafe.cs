using System;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonLazyThreadSafe
    {
        private static volatile SingletonLazyThreadSafe instance;
        private static object _mutex = new Object();

        private SingletonLazyThreadSafe()
        {
        }

        public static SingletonLazyThreadSafe Instance
        {
            get
            {
                // First check if instance is null
                if (instance == null)
                {
                    // Two threads could have checked the previous check at the same time
                    // so make sure that we only let 1 thread to use this block at a time
                    lock (_mutex)
                    {
                        // Check again if the object is null - remember that if there were 2 threads the first would initialize the instance
                        // The second thread would still go into this block when it was his turn
                        if (instance == null)
                            instance = new SingletonLazyThreadSafe();
                    }
                }
                return instance;
            }
        }
    }
}