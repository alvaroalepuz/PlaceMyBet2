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
        // GET: api/Mercados
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //GET: api/Mercados?TipoMercado,CuotaUnder,CuotaOver
        //public mercadoDto Get(int id)
        //{
        //    var repo = new mercadoRepository();
        //    mercadoDto e = repo.RetriveTipoMercado();
        //    return e;
        //}


//GET: api/Mercados/2

public mercado Get(int id)
{
    //var repo = new mercadoRepository();
    //mercado e = repo.RetriveFiltrado();
    return null;
}
// GET: api/Mercados/5
//public mercado Get(int id)
//{
//    var repo = new mercadoRepository();
//    mercado m = repo.Retrive();
//    return m;
//}

// POST: api/Mercados
public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mercados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercados/5
        public void Delete(int id)
        {
        }
    }
}
