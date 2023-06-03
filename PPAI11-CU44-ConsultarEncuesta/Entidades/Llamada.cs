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

        /*Constructor kevin gil*/
        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, bool encuestaEnviada, string observacionAuditor, List<RespuestaDeCliente> respuestasDeCliente, List<CambioEstado> cambioEstado, Cliente cliente)
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

        //!Verificar ESDEPERIODO
        public bool EsDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            for(var i = 0; i < cambioEstado.Count; i++)
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
            for (var i = 0; i < cambioEstado.Count; i++)
            {
                fechaHoraInicio = 
                if (cambioEstado[i].esEstadoInicial())
                {
                    
                }
            }
            return false;
        }
        public string getNombreClienteDeLlamada()
        {
            return this.cliente.NombreCompleto;
        }

        //!IMPLEMENTAR getRespuestas
        public List<RespuestaDeCliente> getRespuestas()
        {
            return this.respuestasDeCliente;
        }

        //Verificar EXISTENRESPUESTAS
        public bool ExistenRespuestas()
        {
            if(this.respuestasDeCliente.Count <= 0)
            {
                return false;
            }
            return true;
        }

    }
}
