using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyEmma.Net.Api;
using Newtonsoft.Json.Linq;
using MyEmma.Net.Api.Contracts;
using MyEmma.Net.Api.Services;
using MyEmma.Net.Api.Models;
using Newtonsoft.Json;


namespace MyEmma.Net.Test
{
    [TestClass]
    public class MembersTest
    {
        IMyEmmaService myemma = new MyEmmaService();

        [TestMethod]
        public void GetAllMembers()
        {
            IMembersService members = new MembersService(myemma);
            var list = members.Get();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetSomeMember()
        {
            IMembersService members = new MembersService(myemma);
            var member = members.Get("752395550");
            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void GetMemberByEmail()
        {
            IMembersService members = new MembersService(myemma);
            var member = members.GetByEmail("m3lindru@gmail.com");
            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void UnSubscribeMember()
        {
            IMembersService members = new MembersService(myemma);
            var member = members.Unsubscribe("m3lindru@gmail.com");
            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void SubscribeMember()
        {
            IMembersService members = new MembersService(myemma);
            var member = members.Subscribe(new RequestAddMember()
            {
                email = "m3lindru@gmail.com",
                fields = new MemberCustomFields { first_name = "m3lindru", last_name = "lastname" }
            });
            Assert.IsNotNull(member);
        }
    }
}
