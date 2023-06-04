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
            this.duracion = this.calcularDuracion();
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestasDeEncuesta = respuestasDeCliente;
            this.cambioEstado = cambioEstado;
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

        public int calcularDuracion()
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

    }
}
