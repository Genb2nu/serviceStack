using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack_to_github.ServiceModel;

namespace ServiceStack_to_github.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        public object Any(NameRequest request)
        {
            return new NameResponse { Result = "Name, {0}!".Fmt(request.Name) };
        }

    }
}