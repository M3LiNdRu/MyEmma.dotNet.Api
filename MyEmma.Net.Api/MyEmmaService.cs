using MyEmma.Net.Api.Services;
using MyEmma.Net.Api.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Api
{

    public class MyEmmaService : IMyEmmaService
    {
        private string url = "https://api.e2ma.net/{account_id}/";
        private string account_id = "XXXXXXX";
        private string public_api_key = "XXXXXXXXXXXXXXXXXXXX";
        private string private_api_key = "XXXXXXXXXXXXXXXXXXXX";
        public RestClient client;


        public MyEmmaService() 
        {

            url = url.Replace("{account_id}", account_id);
            client = new RestClient(url);
            client.Authenticator = new HttpBasicAuthenticator(public_api_key, private_api_key);
        }

        public RestClient Call() { return this.client;  }
       
    }
}
