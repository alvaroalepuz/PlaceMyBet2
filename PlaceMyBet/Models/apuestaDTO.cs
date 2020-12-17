using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuestaDTO
    {
            public apuestaDTO(string usuarioId, int eventoId, string tipo, double dinero)
            {
                this.usuarioId = usuarioId;
                this.eventoId = eventoId;
                this.tipo = tipo;
                this.dinero = dinero;

            }
            public string usuarioId { get; set; }
            public int eventoId { get; set; }
            public string tipo { get; set; }
            public double dinero { get; set; }

             public mercado mercadoR { get; set; }



    }
}