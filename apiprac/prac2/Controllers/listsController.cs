using Data.GRE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace prac2.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    [EnableCors(origins: "http://ui01.azurewebsites.net", headers: "*", methods: "*")]
    public class listsController : ApiController
    {
        // GET: api/lists
        public IEnumerable<listsObject> Get()
        {
            //return new string[] { "value1", "value2" };

            listsDa lda = new listsDa();
            var c = new List<listsObject>();
            lda.Load(c);
            return c;
        }

        // GET: api/lists/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/lists
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/lists/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/lists/5
        public void Delete(int id)
        {
        }
    }
}
