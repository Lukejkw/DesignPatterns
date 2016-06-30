namespace DesignPatterns.Singleton
{
    /// <summary>
    /// This is the most basic implementation of a singleton but is not Lazy
    /// </summary>
    public sealed class SingletonBasic
    {
        public static readonly SingletonBasic Instance = new SingletonBasic();

        private SingletonBasic()
        { }
    }
}