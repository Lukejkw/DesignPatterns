namespace DesignPatterns.Singleton
{
    /// <summary>
    /// The following singleton example uses lazy loading BUT is not thread safe
    /// </summary>
    public sealed class SingletonLazyNotThreadSafe
    {
        private static SingletonLazyNotThreadSafe _instance;

        private SingletonLazyNotThreadSafe()
        { }

        public static SingletonLazyNotThreadSafe Instance
        {
            get
            {
                // Two threads could hit this check at the exact same time
                if (_instance == null)
                    _instance = new SingletonLazyNotThreadSafe();
                return _instance;
            }
        }
    }
}