using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Library;

namespace TwilioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendSms();
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }

        static public void SendSms()
        {
            Twilio.Library.Twilio obj = new Twilio.Library.Twilio();
            obj.SendSms("RECEIVER_MOBILE_NUMBER_HERE", "Hello from C#");
        }
    }
}
