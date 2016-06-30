namespace DesignPatterns
{
    /// <summary>
    /// This is the factory pattern.
    ///
    /// The factory class's job is to return an implementation of the abstract AnimalBase class based on a parameter.
    /// </summary>
    public class AnimalFactory
    {
        public static AnimalBase GetAnimal(int typeId)
        {
            switch (typeId)
            {
                case 1:
                    return new Dog();

                case 2:
                    return new Cat();

                default:
                    return null;
            }
        }
    }

    public abstract class AnimalBase
    {
        public abstract string SongOfItsPeople();
    }

    public class Dog : AnimalBase
    {
        public override string SongOfItsPeople()
        {
            return $"BARK BARK!";
        }
    }

    public class Cat : AnimalBase
    {
        public override string SongOfItsPeople()
        {
            return $"MEOW!";
        }
    }
}