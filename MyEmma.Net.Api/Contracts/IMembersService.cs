using MyEmma.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Api.Contracts
{
    public interface IMembersService
    {
        List<Member> Get();
        Member Get(string id);
        Member GetByEmail(string email);
        Member Profile(string id);
        ResponseAddMember Subscribe(RequestAddMember member);
        bool Unsubscribe(string email);
        bool Add(Member member);
        bool Add(List<Member> members);
        bool Delete(List<Member> members);
        bool Delete(string id);

    }
}
