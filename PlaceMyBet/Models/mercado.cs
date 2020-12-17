using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class mercado
    {
        public mercado(int mercadoId, double mercado, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder)
        {
            this.mercadoId = mercadoId;
            Mercado = mercado;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
        }

        public int mercadoId { get; set; }
        public double Mercado { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double DineroOver{ get; set; }
        public double DineroUnder{ get; set; }

        public List<evento> eventoR { get; set; }
        public List<usuario> usuarioR { get; set; }

        public mercado()
        {

        }
        public class mercadoDTO
        {
            public mercadoDTO(double mercado, double cuotaOver, double cuotaUnder)
            {
                Mercado = mercado;
                CuotaOver = cuotaOver;
                CuotaUnder = cuotaUnder;
            }
            public double Mercado { get; set; }
            public double CuotaOver { get; set; }
            public double CuotaUnder { get; set; }
        }
    }



}