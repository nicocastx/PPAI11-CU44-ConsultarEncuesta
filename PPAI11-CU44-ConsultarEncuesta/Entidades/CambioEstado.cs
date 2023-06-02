using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class CambioEstado
    {
        public DateTime FechaHoraInicio { get; set; }
        public Estado Estado { get; set; }
        public CambioEstado(DateTime FechaHoraInicio, Estado Estado)
        {
            this.FechaHoraInicio = FechaHoraInicio;
            this.Estado = Estado;
        }

        /* GENTE ACA IMPLEMENTE LA FECHA CON EL TIPO DATETIME, NO SABIA CUAL IMPLEMENTAR
        public DateTime fecha;
        public CambioEstado()
        {
            fecha = DateTime.Now;
        }

        public DateTime fechaHoraInicio {
            get { return fecha; }
            set { fecha = value; }
        }*/

        public bool esEstadoInicial()
        {
            return Estado.esIniciada();
        }
    }
}
