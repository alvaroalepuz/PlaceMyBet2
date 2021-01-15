using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace PlaceMyBet.Models
{
    public class apuestaRepository
    {
        internal List<apuesta> Retrieve()
        {

            List<apuesta> apuesta = new List<apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuesta = context.Apuesta.ToList();
            }

            return apuesta;

        }

        internal apuesta Retrieve(int id)
        {
            apuesta apuesta;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuesta = context.Apuesta
                    .Where(s => s.apuestaId == id)
                    .FirstOrDefault();
            }


            return apuesta;
        }



        //public static apuestaDTO ToDTO(apuesta a, evento e, usuario u)
        //{
        //    return new apuestaDTO(u.usuarioId, e.eventoId, a.Tipo, a.Dinero);
        //}

        //internal List<apuestaDTO> Retrieve()
        //{
        //    List<apuestaDTO> apuestadto = new List<apuestaDTO>();
        //    evento e = new evento();
        //    usuario u = new usuario();

        //    using (PlaceMyBetContext context = new PlaceMyBetContext())
        //    {
        //        apuestadto = context.Apuesta
        //            .Select(a => ToDTO(a, e, u))
        //            .Include(p => p.mercadoR).ToList();

        //    }


        //    return apuestadto;
        //}




        internal void Save(apuesta d)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Apuesta.Add(d);
            context.SaveChanges();

        }
    }
}