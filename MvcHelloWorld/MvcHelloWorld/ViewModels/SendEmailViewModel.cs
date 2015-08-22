using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHelloWorld.ViewModels
{
    public class SendEmailViewModel
    {

        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}