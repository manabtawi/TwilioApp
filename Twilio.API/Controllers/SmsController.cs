using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Twilio.API.Models;

namespace Twilio.API.Controllers
{
    public class SmsController : ApiController
    {
        // POST api/sms
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public IHttpActionResult Post(SmsModel model)
        {
            Library.Twilio twilio = new Library.Twilio();
            twilio.SendSms(model.to,model.body,model.from);
            return Ok();
        }
    }
}
