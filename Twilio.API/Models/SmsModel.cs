﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twilio.API.Models
{
    public class SmsModel
    {
        public string from { get; set; }
        public string to { get; set; }
        public string body { get; set; }
    }
}