﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmma.Net.Api.Services
{
    public class Mailings : BaseService
    {
        public Mailings(IMyEmmaService service)
            : base(service)
        {

        }
    }
}
