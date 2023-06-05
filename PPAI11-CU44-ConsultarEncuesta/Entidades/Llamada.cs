using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Llamada
    {
        public string descripcionOperador { get; set; }
        public string detalleAccionRequerida { get; set; }
        public int duracion { get; set; }
        public bool encuestaEnviada { get; set; }
        public string observacionAuditor { get; set; }
        public List<RespuestaDeCliente> respuestasDeEncuesta { get; set; }
        public List<CambioEstado> cambioEstado { get; set; }
        public Cliente cliente { get; set; }

        /*Constructor */
        public Llamada(string descripcionOperador, string detalleAccionRequerida, bool encuestaEnviada, string observacionAuditor, List<RespuestaDeCliente> respuestasDeCliente, List<CambioEstado> cambioEstado, Cliente cliente)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestasDeEncuesta = respuestasDeCliente;
            this.cambioEstado = cambioEstado;
            this.duracion = this.calcularDuracion();
            this.cliente = cliente;
        }

        //!Verificar ESDEPERIODO, DEVUELVE TRUE O FALSE
        public bool EsDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            for (var i = 0; i < cambioEstado.Count; i++)
            {
                if (cambioEstado[i].esEstadoInicial())
                {
                    if (cambioEstado[i].FechaHoraInicio < fechaFinPeriodo && cambioEstado[i].FechaHoraInicio > fechaInicioPeriodo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*public int calcularDuracion()
        {
            DateTime fechaHoraInicio = new DateTime();
            DateTime fechaHoraFin = new DateTime();
            for (var i = 0; i < cambioEstado.Count; i++)
            {
                if (cambioEstado[i].esEstadoInicial())
                {
                    fechaHoraInicio = cambioEstado[i].FechaHoraInicio;
                } else if (cambioEstado[i].esEstadoFinal())
                {
                    fechaHoraFin = cambioEstado[i].FechaHoraInicio;
                }
            }

            TimeSpan diferencia = fechaHoraInicio.Subtract(fechaHoraFin);

            int minutos = (int)diferencia.TotalMinutes;
            return minutos;
        }*/

        public int calcularDuracion()
        {
            DateTime fechaHoraInicio = DateTime.MinValue;
            DateTime fechaHoraFin = DateTime.MinValue;

            for (var i = 0; i < cambioEstado.Count; i++)
            {
                if (cambioEstado[i] != null)
                {
                    if (cambioEstado[i].esEstadoInicial())
                    {
                        fechaHoraInicio = cambioEstado[i].FechaHoraInicio;
                    }
                    else if (cambioEstado[i].esEstadoFinal())
                    {
                        fechaHoraFin = cambioEstado[i].FechaHoraInicio;
                    }
                }
            }

            if (fechaHoraInicio != DateTime.MinValue && fechaHoraFin != DateTime.MinValue)
            {
                TimeSpan diferencia = fechaHoraFin.Subtract(fechaHoraInicio);
                int minutos = (int)diferencia.TotalMinutes;
                return minutos;
            }

            return 0; // Valor predeterminado si no se puede calcular la duración
        }

        public string getNombreClienteDeLlamada()
        {
            return this.cliente.NombreCompleto;
        }

        //!IMPLEMENTAR getRespuestas
        public List<RespuestaDeCliente> getRespuestas()
        {
            return this.respuestasDeEncuesta;
        }

        //Verificar EXISTENRESPUESTAS
        public bool ExistenRespuestas()
        {
            if (this.respuestasDeEncuesta.Count <= 0)
            {
                return false;
            }
            return true;
        }

        //Verifica el ultimo estado
        public string esUltimoEstado()
        {
            for (var i =0; i < this.cambioEstado.Count; i++)
            {
                if (cambioEstado[i].esEstadoFinal())
                {
                    return cambioEstado[i].getNombreEstado();
                }
            }
            return null;
        }

    }
}
