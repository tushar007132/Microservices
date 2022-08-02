using API1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API1.Controllers
{
    [RoutePrefix("api/Person")]
    public class PersonController : ApiController
    {
        static List<Person> personList = new List<Person>()
        {
            new Person{Id=101,Name="Tushar",City="Ranchi"}
        };

        [HttpGet]

        [Route("persondetails")]

        public IEnumerable<Person> Get()
        {
            return personList;
        }
        [Route("p")]
        public HttpResponseMessage GetP(int id)
        {
            var person = personList.Find(x => x.Id == id);
            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, id);
            }

            return Request.CreateResponse(HttpStatusCode.OK, person);
        }

        public Person Post([FromBody]Person p)
        {
            personList.Add(p);
            return p;
        }

        // put request

        public void Put(int id,[FromUri] Person person)
        {
            personList[id - 1] = person;
        }
    }
}
