using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class ApuestasController : ApiController
    {
        //GET: api/Apuestas
        public List<apuesta> Get()
        {
            var repo = new apuestaRepository();
            List<apuesta> a = repo.Retrieve();
            return a;
        }

        //GET: api/Apuestas/DTO
        //public List<apuestaDTO> Get()
        //{
        //    var repo = new apuestaRepository();
        //    List<apuestaDTO> m = repo.Retrieve();
        //    return m;
        //}

        // GET: api/Apuestas/1
        public apuesta Getid(int id)
        {
            var repo = new apuestaRepository();
           apuesta a = repo.Retrieve(id);
            return a;
        }

        // POST: api/Apuestas
        public void Post([FromBody]apuesta apuesta)
        {
            var repo = new apuestaRepository();
            repo.Save(apuesta);
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
            
        }
    }
}
