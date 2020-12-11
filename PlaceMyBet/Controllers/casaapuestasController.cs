using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class casaapuestasController : ApiController
    {
        // GET: api/casaapuestas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/casaapuestas/5
        public casaapuestas Get(int id)
        {
            //var repo = new casaapuestasRepository();
            //casaapuestas a = repo.Retrive();
            return null;
        }

        // POST: api/casaapuestas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/casaapuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/casaapuestas/5
        public void Delete(int id)
        {
        }
    }
}
