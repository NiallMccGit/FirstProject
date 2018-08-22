using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIEx1.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("GetValues")]
        // http://localhost:63129/api/values/getvalues
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("GetVal")]
        // http://localhost:63129/api/values/getval?id=1
        public string Get(int id)
        {
            return "value" + id.ToString();
        }

        // POST api/values
        [Route("PostVal")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            string val = value;
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.Created };
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
