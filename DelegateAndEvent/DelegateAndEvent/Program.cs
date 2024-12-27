using Publisher;
using Subscriber;
using TestingDelegte;
using static Publisher.PublishMessage;

namespace DelegateAndEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
           SendEmail.sendEmail(Program.Success);

            var publisher = new PublishMessage();
            var subscriber = new SubscribeMessage();

            publisher.OnPublish += subscriber.OnNotificationReceived;

            Notify del = subscriber.OnNotificationReceived;
            del?.Invoke(); //delegate can be invoked from any class that holds their reference;

            //publisher.OnPublish?.Invoke(); //but Events can only be raised (invoked) within the class that declares them.

            publisher.Publish();
            publisher.Publish(subscriber.OnNotificationReceived); 

           
            Console.WriteLine("Hello, World!");


        }

        public static void Success(string message)
        {
           Console.WriteLine(message);
        }
    }
}
