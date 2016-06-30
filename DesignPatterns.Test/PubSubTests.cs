using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Test
{
    [TestClass]
    public class PubSubTests
    {
        private Publisher publisher = null;

        [TestInitialize]
        public void Setup()
        {
            publisher = new Publisher();
        }

        [TestMethod]
        public void PublisherDoesNotifySubscribers()
        {
            // Arrange
            bool notifiedSub1 = false;
            bool notifiedSub2 = false;

            publisher.OnNameChanged += (args) => notifiedSub1 = true;
            publisher.OnNameChanged += (args) => notifiedSub2 = true;

            // Act
            publisher.Name = "A New Name";

            // Assert
            Assert.IsTrue(notifiedSub1);
            Assert.IsTrue(notifiedSub2);
        }

        [TestMethod]
        public void PublisherDoesNotifySubscribersWithNameAsArgument()
        {
            // Arrange
            string name = string.Empty;
            publisher.OnNameChanged += (args) => name = args;

            // Act
            publisher.Name = "A New Name";

            // Assert
            Assert.AreEqual("A New Name", name);
        }

        [TestMethod]
        public void ExampleSubscriberDoesGetNotified()
        {
            var subscriber = new ExampleSubscriber();

            subscriber.Publisher.Name = "Thomas";

            Assert.AreEqual("Thomas", subscriber.CurrentName);
        }

        [TestCleanup]
        public void TearDown()
        {
            publisher = null;
        }
    }
}