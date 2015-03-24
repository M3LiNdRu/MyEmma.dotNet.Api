using MyEmma.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmma.Net.Api.Contracts
{
    public interface IWebHooksService
    {
        List<WebHook> Get();
        WebHook Get(string id);
        List<WebHookEvent> GetEvents();
        int Create(WebHook WebHook);
    }
}
