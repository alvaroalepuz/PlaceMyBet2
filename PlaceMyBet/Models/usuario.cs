using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class usuario
    {
        public usuario(string email, string nombre, string apellido, int edad, int mercadoId)
        {
            this.email = email;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            MercadoId = mercadoId;
        }

        public string email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int MercadoId { get; set; }
    }
}