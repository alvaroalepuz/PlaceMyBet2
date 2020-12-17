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
        public List<evento> Get()
        {
            var repo = new eventoRepository();
            List<evento> e = repo.Retrieve();
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
        public void Post([FromBody]evento evento)
        {
            var repo = new eventoRepository();
            repo.Save(evento);
        }

        // PUT: api/Eventos/5
        public void Put(int id ,[FromBody]evento e)
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
