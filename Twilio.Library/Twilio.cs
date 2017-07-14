using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Twilio.Library
{
    public class Twilio
    {
        public void SendSms(string to, string body, string from= "SENDER_ID_HERE")
        {
            try
            {
                // Your Account SID from twilio.com/console
                var accountSid = ConfigurationManager.AppSettings.Get("Twilio_AccountSID");
                // Your Auth Token from twilio.com/console
                var authToken = ConfigurationManager.AppSettings.Get("Twilio_AuthToken");

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.CreateAsync(
                    to: new PhoneNumber(to),
                    from: new PhoneNumber(ConfigurationManager.AppSettings.Get("Twilio_Sender")),
                    body: body);
            } catch
            {
                // nothing
            }
        }
    }
}
