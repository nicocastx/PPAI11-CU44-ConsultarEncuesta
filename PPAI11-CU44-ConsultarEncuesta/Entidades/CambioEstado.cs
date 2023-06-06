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

        //devuelve el nombre del estado
        public string getNombreEstado()
        {
            return this.Estado.nombre;
        }

        //verifica si el nombre del estado es iniciada, devuelve true o false
        public bool esEstadoInicial()
        {
            if (this.Estado.esIniciada())
            {
                return true;
            }
            return false;
        }

        //verifica si el nombre del estado es finalizada, devuelve true o false
        public bool esEstadoFinal() {
            if (this.Estado.esFinalizada())
            {
                return true;
            }
            return false;
        }
    }
}
