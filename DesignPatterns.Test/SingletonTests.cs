using DesignPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class SingletonBasicTests
    {
        [TestMethod]
        public void TwoSingletonInstancesAreTheSameInstance()
        {
            SingletonBasic instance1 = SingletonBasic.Instance;
            SingletonBasic instance2 = SingletonBasic.Instance;

            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void SingletonInstanceNotNull()
        {
            Assert.IsNotNull(SingletonBasic.Instance);
        }
    }

    [TestClass]
    public class SingletonLazyNotThreadSafeTests
    {
        [TestMethod]
        public void TwoLazySingletonInstancesAreTheSameInstance()
        {
            SingletonLazyNotThreadSafe instance1 = SingletonLazyNotThreadSafe.Instance;
            SingletonLazyNotThreadSafe instance2 = SingletonLazyNotThreadSafe.Instance;

            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void LazySingletonInstanceNotNull()
        {
            Assert.IsNotNull(SingletonLazyNotThreadSafe.Instance);
        }
    }

    [TestClass]
    public class SingletonLazyThreadSafe
    {
        [TestMethod]
        public void TwoThreadSafeLazySingletonInstancesAreTheSameInstance()
        {
            SingletonLazyNotThreadSafe instance1 = SingletonLazyNotThreadSafe.Instance;
            SingletonLazyNotThreadSafe instance2 = SingletonLazyNotThreadSafe.Instance;

            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void ThreadSafeLazySingletonInstanceNotNull()
        {
            Assert.IsNotNull(SingletonLazyNotThreadSafe.Instance);
        }
    }
}