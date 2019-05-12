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
    public class wordsController : ApiController
    {
        // GET: api/words
        public IEnumerable<wordsObject> Get()
        {
            //return new string[] { "value1", "value2" };

            wordsDa wda = new wordsDa();
            var c = new List<wordsObject>();
            wda.Load(c);
            return c;
        }

        // GET: api/words/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/words
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/words/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/words/5
        public void Delete(int id)
        {
        }
    }
}
