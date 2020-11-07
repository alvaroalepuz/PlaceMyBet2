using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class evento
    {
        public evento(int idevento, string nombreNombreEquipoLocal, string nombreNombreEquipoVisitante, string fecha, int mercadoId)
        {
            this.idevento = idevento;
            NombreNombreEquipoLocal = nombreNombreEquipoLocal;
            NombreNombreEquipoVisitante = nombreNombreEquipoVisitante;
            this.fecha = fecha;
            this.mercadoId = mercadoId;
        }
        public evento(string nombreNombreEquipoLocal, string nombreNombreEquipoVisitante, string fecha)
        {
            NombreNombreEquipoLocal = nombreNombreEquipoLocal;
            NombreNombreEquipoVisitante = nombreNombreEquipoVisitante;
            this.fecha = fecha;
        }

        public int idevento { get; set; }
        public string NombreNombreEquipoLocal { get; set; }
        public string NombreNombreEquipoVisitante { get; set; }
        public string fecha { get; set; }
        public int mercadoId { get; set; }
    }
}
public class eventoDto
{
    public eventoDto(string nombreNombreEquipoLocal, string nombreNombreEquipoVisitante, string fecha)
    {
        NombreNombreEquipoLocal = nombreNombreEquipoLocal;
        NombreNombreEquipoVisitante = nombreNombreEquipoVisitante;
        this.fecha = fecha;
    }

    public string NombreNombreEquipoLocal { get; set; }
    public string NombreNombreEquipoVisitante { get; set; }
    public string fecha { get; set; }
}