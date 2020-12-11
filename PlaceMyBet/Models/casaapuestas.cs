using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class casaapuestas
    {
        public casaapuestas(int casaapuestasId, int saldoActual, string nombreBanco, int numeroTarjeta, string emailId)
        {
            this.casaapuestasId = casaapuestasId;
            SaldoActual = saldoActual;
            NombreBanco = nombreBanco;
            NumeroTarjeta = numeroTarjeta;
            this.emailId = emailId;
        }

        public int casaapuestasId { get; set; }
        public int SaldoActual { get; set; }
        public string NombreBanco { get; set; }
        public int NumeroTarjeta { get; set; }
        public string emailId { get; set; }
   

        public casaapuestas()
        {

        }
    }


}