using MyEmma.Net.Api.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmma.Net.Api
{
    public interface IMyEmmaService
    {
        RestClient Call();
    }
}
