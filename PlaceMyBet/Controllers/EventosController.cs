using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET: api/Eventos?NombreDeEquipo
        public eventoDto Get(int id)
        {
            var repo = new eventoRepository();
            eventoDto e = repo.RetriveNameDate();
            return e;
        }

        //GET: api/Eventos/5
        //public evento Get(int id)
        //{
        //    var repo = new eventoRepository();
        //    evento e = repo.Retrive();
        //    return e;
        //}

        // POST: api/Eventos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
