namespace DesignPatterns
{
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
        public virtual string Name { get; set; }

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