using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class usuario
    {
        public usuario(string usuarioId, string nombre, string apellido, int edad, int mercadoId)
        {
            this.usuarioId = usuarioId;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            MercadoId = mercadoId;
        }

        public string usuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int MercadoId { get; set; }

        public List<apuesta> apuestaR { get; set; }
        public casaapuestas casaapuestaR { get; set; }

        public usuario()
        {
           
        }
    }

}