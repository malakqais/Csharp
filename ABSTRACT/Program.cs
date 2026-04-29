
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT
{
    
    abstract class Notification
    {
      
        protected string message;

        // Constructor
        public Notification(string message)
        {
            this.message = message;
        }

        // Regular method
        public void Preview()
        {
            Console.WriteLine("Message Preview");
            Console.WriteLine(" ");
            Console.WriteLine("Content: " + message);
        }

        // Abstract method
        public abstract void Send();
    }

    // Email Notification
    class EmailNotification : Notification
    {
        private string emailAddress;

        public EmailNotification(string message, string emailAddress)
            : base(message)
        {
            this.emailAddress = emailAddress;
        }

        public override void Send()
        {
            Console.WriteLine("Email Notification");
            Console.WriteLine("Receiver: " + emailAddress);
            Console.WriteLine("Message sent: " + message);
            Console.WriteLine();
        }
    }

    // SMS Notification
    class SMSNotification : Notification
    {
        private string phoneNumber;

        public SMSNotification(string message, string phoneNumber)
            : base(message)
        {
            this.phoneNumber = phoneNumber;
        }

        public override void Send()
        {
            Console.WriteLine("SMS Notification");
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Message sent: " + message);
            Console.WriteLine();
        }
    }

    // Push Notification
    class PushNotification : Notification
    {
        private string deviceId;

        public PushNotification(string message, string deviceId)
            : base(message)
        {
            this.deviceId = deviceId;
        }

        public override void Send()
        {
            Console.WriteLine("Push Notification");
            Console.WriteLine("Device ID: " + deviceId);
            Console.WriteLine("Message sent: " + message);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Using base class reference
            Notification email = new EmailNotification("Your account has been updated", "student@email.com");
            Notification sms = new SMSNotification("Your verification code is 1234", "0781112223");
            Notification push = new PushNotification("You have a new alert", "Mobile-01");

            email.Preview();
            email.Send();

            sms.Preview();
            sms.Send();

            push.Preview();
            push.Send();

            Console.WriteLine("All notifications were processed successfully.");
        }
    }
}