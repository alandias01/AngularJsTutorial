using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Data.GRE;

namespace prac2.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    [EnableCors(origins: "http://ui01.azurewebsites.net", headers: "*", methods: "*")]
    public class vlistwordsController : ApiController
    {
        // GET: api/vlistwords
        public IEnumerable<vlistwordsObject> Get()
        {
            //return new string[] { "value1", "value2" };

            vlistwordsDa vda = new vlistwordsDa();
            var c = new List<vlistwordsObject>();
            vda.Load(c);
            return c;
        }

        // GET: api/vlistwords/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/vlistwords
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/vlistwords/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/vlistwords/5
        public void Delete(int id)
        {
        }
    }
}
