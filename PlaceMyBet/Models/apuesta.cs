using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuesta
    {
        public apuesta(int apuestaId, string tipo, double dinero, int mercadoId, string emailId)
        {
            this.apuestaId = apuestaId;
            Tipo = tipo;
            Dinero = dinero;
            MercadoId = mercadoId;
            this.emailId = emailId;
        }

        public int apuestaId { get; set; }
        public string Tipo { get; set; }
        public double Dinero { get; set; }
        public int MercadoId { get; set; }
        public string emailId { get; set; }

        public mercado mercadoR { get; set; }

        public apuesta()
        {

        }

    }
    public class apuestaDto
    {
        public apuestaDto(string tipoMercado, double dinero, double cuotaOver, double cuotaUnder, string emailId, string fecha)
        {
            TipoMercado = tipoMercado;
            Dinero = dinero;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            this.emailId = emailId;
            this.fecha = fecha;
        }

        public string TipoMercado { get; set; }
        public double Dinero { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public string emailId { get; set; }
        public string fecha { get; set; }



    }
    public class apuestaDto2
    {
        public apuestaDto2(int eventoId, string tipo, double cuotaOver, double cuotaUnder, double dinero)
        {
            this.eventoId = eventoId;
            Tipo = tipo;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            Dinero = dinero;
        }

        public int eventoId { get; set; }
        public string Tipo { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double Dinero { get; set; }
    }

    public class apuestaDto3
    {
        public apuestaDto3(double mercado, string tipo, double cuotaOver, double cuotaUnder, double dinero)
        {
            Mercado = mercado;
            Tipo = tipo;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            Dinero = dinero;
        }

        public double Mercado { get; set; }
        public string Tipo { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double Dinero { get; set; }
    }
}