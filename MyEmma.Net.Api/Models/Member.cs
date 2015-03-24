using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Api.Models
{
    public class Member : IModel
    {
        public string status { get; set; }
        public string confirmed_opt_in { get; set; }
        public int account_id { get; set; }
        public string fields { get; set; } //Custom fields
        public long member_id { get; set; }
        public string last_modified_at { get; set; }
        public string member_status_id { get; set; }
        public string plaintext_preferred { get; set; }
        public string email_error { get; set; }
        public DateTime member_since { get; set;}
        public int bounce_count { get; set; }
        public string deleted_at { get; set; }
        public string email { get; set; }
    }
    public class RequestAddMember : IModel
    {
        public string email { get; set; }
        public MemberCustomFields fields { get; set; }
    }
    public class ResponseAddMember : IModel
    {
        public string status { get; set; }
        public bool added { get; set; }
        public int member_id { get; set; }
    }

    public class MemberCustomFields : IModel
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
