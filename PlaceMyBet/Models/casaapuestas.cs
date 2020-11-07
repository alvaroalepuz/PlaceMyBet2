using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class casaapuestas
    {
        public casaapuestas(int idCA, int saldoActual, string nombreBanco, string numeroTarjeta, string emailId)
        {
            this.idCA = idCA;
            SaldoActual = saldoActual;
            NombreBanco = nombreBanco;
            NumeroTarjeta = numeroTarjeta;
            this.emailId = emailId;
        }

        public int idCA { get; set; }
        public int SaldoActual { get; set; }
        public string NombreBanco { get; set; }
        public string NumeroTarjeta { get; set; }
        public string emailId { get; set; }
    }
}