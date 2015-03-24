using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEmma.Net.Api;
using Newtonsoft.Json.Linq;
using MyEmma.Net.Api.Contracts;

namespace MyEmma.Net.Test
{
    [TestClass]
    public class UnitTest
    {
        IMyEmmaService service = new MyEmmaService();

        [TestMethod]
        public void GetAllMembers()
        {
            
        }
    }
}
