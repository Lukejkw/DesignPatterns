using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Test
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void TwoSingletonInstancesAreTheSameInstance()
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void SingletonInstanceNotNull()
        {
            Assert.IsNotNull(Singleton.Instance);
        }
    }
}