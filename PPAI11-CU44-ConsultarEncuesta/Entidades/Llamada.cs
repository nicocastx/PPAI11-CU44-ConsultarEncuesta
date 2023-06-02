using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class Llamada
    {
        public string descripcionOperador { get; set; }
        public string detalleAccionRequerida { get; set; }
        public int duracion { get; set; }
        public string encuestaEnviada { get; set; }
        public string observacionAuditor { get; set; }
        public List<RespuestaDeCliente> respuestasDeCliente { get; set; }
        public List<CambioEstado> cambioEstado { get; set; }
        public Cliente cliente { get; set; }

        /*Constructor*/
        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, string encuestaEnviada, string observacionAuditor, List<RespuestaDeCliente> respuestasDeCliente, List<CambioEstado> cambioEstado, Cliente cliente)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestasDeCliente = respuestasDeCliente;
            this.cambioEstado = cambioEstado;
            this.cliente = cliente;
        }

        //!Verificar ESDEPERIODO
        public bool EsDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            return true;
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
