using System;

namespace question_12
{
    public delegate void MyDelegate(string message);

    public class Messenger
    {
        public event MyDelegate MessageSent;

        public void SendMessage(string message)
        {
            Console.WriteLine("Sending message: " + message);
            if (MessageSent != null)
            {
                MessageSent(message);
            }
        }
    }

    internal class Program
    {
        static void OnMessageSent(string massage)
        {
            Console.WriteLine("Message sent: " + massage);
        }

        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            messenger.MessageSent += OnMessageSent;
            messenger.SendMessage("Hello World!");
        }
    }
}