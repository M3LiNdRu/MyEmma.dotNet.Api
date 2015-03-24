using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEmma.Net.Api;
using MyEmma.Net.Api.Contracts;
using MyEmma.Net.Api.Models;
using MyEmma.Net.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Test
{
    [TestClass]
    public class WebHookTest
    {
        IMyEmmaService myemma = new MyEmmaService();

        [TestMethod]
        public void GetAllHooks()
        {
            IWebHooksService webhook = new WebHooksService(myemma);
            var list = webhook.Get();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetSomeHook()
        {
            IWebHooksService webhook = new WebHooksService(myemma);
            var wh = webhook.Get("93470");
            Assert.IsNotNull(wh);
        }

        [TestMethod]
        public void CreateHook()
        {
            IWebHooksService webhook = new WebHooksService(myemma);
            int number = webhook.Create(new WebHook()
            {
                url = "http://www.google.com",
                @event = "mailing_finish"
            });
            string parse = number.ToString();
            Assert.IsNotNull(parse);
        }

        [TestMethod]
        public void GetEvents()
        {
            IWebHooksService webhook = new WebHooksService(myemma);
            var list = webhook.GetEvents();
            Assert.IsNotNull(list);
        }
    }
}
