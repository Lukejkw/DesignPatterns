namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        { }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}