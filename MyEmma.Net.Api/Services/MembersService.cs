using MyEmma.Net.Api.Contracts;
using MyEmma.Net.Api.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Api.Services
{
    public class MembersService : BaseService, IMembersService
    {
        private static string MEMBER = "members";
        public MembersService(IMyEmmaService service)
            : base(service)
        {

        }

        public List<Member> Get() 
        {
            return base.GetAll<Member>(MEMBER);
        }
        public Member Get(string id) 
        {
            return base.Get<Member>(MEMBER, id); 
        }
        public Member GetByEmail(string email)
        {
            return base.Get<Member>(MEMBER + @"/email/",  email);
        }
        public ResponseAddMember Subscribe(RequestAddMember member) {
            return base.Post<ResponseAddMember>(MEMBER + "/add", member);
        }

        public bool Unsubscribe(string email)
        {
            return base.Put(MEMBER + @"/email/optout/", email);
        }

        public Member Profile(string id) { return null; }
        public bool Add(Member member) { return false; }
        public bool Add(List<Member> members) { return false; }
        public bool Delete(List<Member> members) { return false; }
        public bool Delete(string id) { return false; }
      
    }
}
