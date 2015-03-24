using MyEmma.Net.Api.Contracts;
using MyEmma.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Api.Services
{
    public class WebHooksService : BaseService, IWebHooksService
    {
        private static string WEBHOOK = "webhooks";

        public WebHooksService(IMyEmmaService service)
            : base(service)
        {

        }

        public List<WebHook> Get()
        {
            return base.GetAll<WebHook>(WEBHOOK);
        }
        public WebHook Get(string id)
        {
            return base.Get<WebHook>(WEBHOOK, id);
        }
        public List<WebHookEvent> GetEvents()
        {
            return base.GetAll<WebHookEvent>(WEBHOOK + @"/events");
        }

        public int Create(WebHook WebHook)
        {
            return base.Post<int>(WEBHOOK, WebHook);
        }
    }
}
