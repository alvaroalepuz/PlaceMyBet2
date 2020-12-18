using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class EventosExamen : ApiController
    {
        // GET: api/Eventos
        public List<evento> Get()
        {
            var repo = new eventoRepository();
            List<evento> e = repo.Retrieve();
            return e;
        }
        //GET: api/EventosExamen?val={nombre}
        public List<evento> Get(string val)
        {
            var repo = new eventoRepository();
            List<evento> e = repo.Retrieve(val);
            return e;
        }

        // POST: api/EventosExamen
        public void Post([FromBody] evento e, mercado m)
        {
            var repo = new eventoRepository();
            repo.Save(e,m);

        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody] evento e)
        {
            {
                eventoRepository repo = new eventoRepository();
                evento a = repo.Retrieve(id);
                repo.Update(e);
            }
        }

        // DELETE: api/Eventos/1
        public void Delete(int id)
        {
            eventoRepository repo = new eventoRepository();
            evento a = repo.Retrieve(id);
            repo.Delete(a);
        }



    }
}
