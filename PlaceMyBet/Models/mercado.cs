using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class mercado
    {
        public mercado(int idmercado, double mercado, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder)
        {
            this.idmercado = idmercado;
            Mercado = mercado;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
        }

        public int idmercado { get; set; }
        public double Mercado { get; set; }
        public double CuotaOver { get; set; }
        public  double CuotaUnder { get; set; }
        public double DineroOver{ get; set; }
        public double DineroUnder{ get; set; }
    }

}
public class mercadoDto
{
    public mercadoDto(double mercado, double cuotaOver, double cuotaUnder)
    {
        Mercado = mercado;
        CuotaOver = cuotaOver;
        CuotaUnder = cuotaUnder;
    }
    public double Mercado { get; set; }
    public double CuotaOver { get; set; }
    public double CuotaUnder { get; set; }
}