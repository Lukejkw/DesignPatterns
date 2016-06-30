using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void FactoryDoesGetDog()
        {
            AnimalBase animal = AnimalFactory.GetAnimal(1);
            Assert.IsTrue(animal is Dog);
        }

        [TestMethod]
        public void FactoryDoesGetCat()
        {
            AnimalBase animal = AnimalFactory.GetAnimal(2);
            Assert.IsTrue(animal is Cat);
        }

        [TestMethod]
        public void FactoryDoesGetNull()
        {
            AnimalBase animal = AnimalFactory.GetAnimal(100);
            Assert.IsTrue(animal == null);
        }

        [TestMethod]
        public void DifferentAnimalsMakeDifferentNoises()
        {
            AnimalBase dog = AnimalFactory.GetAnimal(1);
            AnimalBase cat = AnimalFactory.GetAnimal(2);

            Assert.AreNotEqual(cat.SongOfItsPeople(), dog.SongOfItsPeople());
        }
    }
}