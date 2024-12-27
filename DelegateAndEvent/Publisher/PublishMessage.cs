namespace Publisher
{
    public class PublishMessage
    {
        // Delegate declaration
        public delegate void Notify();
        public event Notify OnPublish;

        public void Publish()
        {
            Console.WriteLine("Publishing...");
            OnPublish?.Invoke();
        }

        public void Publish(Notify del)
        {
            Console.WriteLine("Publishing using delegate...");
            del?.Invoke();
        }

    }
}
