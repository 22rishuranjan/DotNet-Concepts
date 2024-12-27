using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDelegte
{  
    public static class SendEmail
    {
        public delegate void LogMessage(string message);
        public static void sendEmail(LogMessage print)
        {
            Console.WriteLine("send message");

            print("Email sent successfully");
            
        }
    }
}
