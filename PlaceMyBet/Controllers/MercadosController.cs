using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class MercadosController : ApiController
    {

        //GET: api/Mercados
        //public List<mercado> Get()
        //{
        //    var repo = new mercadoRepository();
        //    List<mercado> m = repo.Retrieve();
        //    return m;
        //}
        // GET: api/Mercados/1
        public mercado Getid(int id)
        {
            var repo = new mercadoRepository();
            mercado m = repo.Retrieve(id);
            return m;
        }
        //GET: api/Mercados
        public List<mercado.mercadoDTO> Get()
        {
            var repo = new mercadoRepository();
            List<mercado.mercadoDTO> m = repo.Retrieve();
            return m;
        }

        internal List<mercado> Retrieve()
        {

            List<mercado> mercado = new List<mercado>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercado = context.Mercado.ToList();
            }

            return mercado;

        }

        // POST: api/Mercados
        public void Post([FromBody] mercado mercado)
        {
            var repo = new mercadoRepository();
            repo.Save(mercado);
        }

        // PUT: api/Mercados/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Mercados/5
        public void Delete(int id)
        {
        }
    }
}
