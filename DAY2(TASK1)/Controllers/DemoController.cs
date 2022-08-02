using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API1.Controllers
{
    public class DemoController : ApiController
    {
        static List<String> mystrings = new List<String> { "value0","value1"};

        public IEnumerable<String> Get()
        {
            return mystrings;
        }

        public String Get(int id)
        {
            return mystrings[id];
        }

        public IEnumerable<String> Post([FromBody]String val)
        {
            mystrings.Add(val);
            return mystrings;
        }

    }
}
