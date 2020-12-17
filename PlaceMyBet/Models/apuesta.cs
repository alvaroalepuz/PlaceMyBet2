using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuesta
    {
        public apuesta(int apuestaId, string tipo, double dinero, int mercadoId, string uduarioId)
        {
            this.apuestaId = apuestaId;
            Tipo = tipo;
            Dinero = dinero;
            MercadoId = mercadoId;
            this.usuarioId = uduarioId;
        }

        public int apuestaId { get; set; }
        public string Tipo { get; set; }
        public double Dinero { get; set; }
        public int MercadoId { get; set; }
        public string usuarioId { get; set; }

        public mercado mercadoR { get; set; }

        public apuesta()
        {

        }

       
    }
}