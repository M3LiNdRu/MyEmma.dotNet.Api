using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmma.Net.Api.Models
{
    public class WebHook : IModel
    {
        public string url { get; set; }
        public string webhook_id { get; set; }
        public string method { get; set; }
        public int account_id { get; set; }
        public string @event { get; set;}
    }

    public class WebHookEvent : IModel
    {
        public string event_name { get; set; }
        public string webhook_event_id { get; set; }
        public string description { get; set; }
    }

}
