using System;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class CambioEstado
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
            if (this.Estado.esIniciada())
            {
                return true;
            }
            return false;
        }

        public bool esEstadoFinal() {
            if (this.Estado.esFinalizada())
            {
                return true;
            }
            return false;
        }
    }
}
