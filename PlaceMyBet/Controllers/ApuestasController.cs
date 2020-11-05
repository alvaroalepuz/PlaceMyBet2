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
        // GET: api/Apuestas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //GET: api/Apuestas/1
        public apuestaDto3 Get(int id)
        {
            var repo = new apuestaRepository();
            apuestaDto3 e = repo.RetriveFiltro3();
            return e;
        }
        //GET: api/Apuestas?TipoMercado,CuotaUnder,CuotaOver
        [Authorize(Roles = "Admin")]
        //public apuestaDto2 Get(int id)
        //{
        //    var repo = new apuestaRepository();
        //    apuestaDto2 e = repo.RetriveFiltro();
        //    return e;
        //}

        //GET: api/Apuestas?TipoMercado,CuotaUnder,CuotaOver
        //[Authorize(Roles ="Admin")]
        //public apuestaDto Get(int id)
        //{
        //    var repo = new apuestaRepository();
        //    apuestaDto e = repo.RetriveFiltrado();
        //    return e;
        //}

        // GET: api/Apuestas/5
        //public apuesta Get(int id)
        //{
        //    var repo = new apuestaRepository();
        //    apuesta a = repo.Retrive();
        //    return a;
        //}

        // POST: api/Apuestas
        [Authorize]
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
