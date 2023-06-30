﻿using Apps.SalesforceMarketing;
using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.SalesforceMarketing
{
    public class SalesforceRequest : RestRequest
    {
        public SalesforceRequest(string endpoint, Method method, IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders) : base(endpoint, method)
        {
            var token = authenticationCredentialsProviders.First(p => p.KeyName == "Authorization").Value;
            this.AddHeader("Authorization", $"{token}");
        }
    }
}
