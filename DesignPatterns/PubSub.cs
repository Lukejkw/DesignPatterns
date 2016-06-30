using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// This is an example of the PubSub design pattern.
    ///
    /// The Publisher class has an event that can be "subcribed" to. In this example, subscribers will be notified on every name change
    /// </summary>
    public class Publisher
    {
        private string _name = string.Empty;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnNameChanged?.Invoke(_name);
            }
        }

        public delegate void PublisherEvent(string args);

        public event PublisherEvent OnNameChanged;
    }

    public class ExampleSubscriber
    {
        // The publisher - could be a button for example
        public Publisher Publisher = new Publisher();

        public string CurrentName { get; set; }

        public ExampleSubscriber()
        {
            // Subscribe (+= is important because it will add us to the list of subscribers)
            Publisher.OnNameChanged += PublisherNameChanged;
        }

        private void PublisherNameChanged(string args)
        {
            // This method will run whenever the publisher does something
            // and will allow the subscriber to act on it
            CurrentName = args;
        }
    }
}