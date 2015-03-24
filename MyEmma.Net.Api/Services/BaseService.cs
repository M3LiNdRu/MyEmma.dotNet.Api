using MyEmma.Net.Api.Models;
using RestSharp;
using RestSharp.Contrib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmma.Net.Api.Services
{
    public class BaseService
    {
        protected IMyEmmaService service;

        public BaseService(IMyEmmaService service)
        {
            this.service = service;
        }


        public List<T> GetAll<T>(string resource)
        {
            var request = new RestRequest(resource, Method.GET);

            IRestResponse<List<T>> res = this.service.Call().Execute<List<T>>(request);

            if (res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            return res.Data;
        }

        public T Get<T>(string resource, string id) where T : new()
        {
            string path = resource + "/{id}";

            var request = new RestRequest(path, Method.GET);
            request.AddUrlSegment("id", HttpUtility.UrlEncode(id));

            IRestResponse<T> res = this.service.Call().Execute<T>(request);

            if (res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return default(T);
            }

            return res.Data;
        }

        public bool Put(string resource, string email)
        {
            email = HttpUtility.UrlEncode(email);
            string path = resource + @"{params}";

            var request = new RestRequest(path, Method.PUT);
            request.AddUrlSegment("params", email);

            IRestResponse res = this.service.Call().Execute(request);

            if (res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return false;
            }

            return true;
        }

        public T Post<T>(string resource, IModel member) where T : new()
        {

            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(member);
            

            IRestResponse<T> res = this.service.Call().Execute<T>(request);

            if (res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return default(T);
            }

            return res.Data;
        }

        private RestSharp.Method ParseHttpMethod(string HTTPMethod)
        {
            switch (HTTPMethod)
            {
                case "GET": return Method.GET;
                case "POST": return Method.POST;
                case "PUT": return Method.PUT;
                case "DELETE": return Method.DELETE;
                case "HEAD": return Method.HEAD;
                case "MERGE": return Method.MERGE;
                case "OPTIONS": return Method.OPTIONS;
                case "PATCH": return Method.PATCH;
                default: return Method.GET;
            }
        }

    }
}
