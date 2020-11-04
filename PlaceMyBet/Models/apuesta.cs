using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuesta
    {
        public apuesta(int idapuesta, string tipo, double dinero, int mercadoId, string emailId)
        {
            this.idapuesta = idapuesta;
            Tipo = tipo;
            Dinero = dinero;
            MercadoId = mercadoId;
            this.emailId = emailId;
        }

        public int idapuesta { get; set; }
        public string Tipo { get; set; }
        public double Dinero { get; set; }
        public int MercadoId { get; set; }
        public string emailId { get; set; }
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
}