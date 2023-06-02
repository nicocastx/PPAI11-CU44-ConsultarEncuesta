using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class Llamada
    {
        public string DescripcionOperador { get; set; }
        public string DetalleAccionRequerida { get; set; }
        public int Duracion { get; set; }
        public string EncuestaEnviada { get; set; }
        public string ObservacionAuditor { get; set; }
        public List<RespuestaDeCliente> RespuestasDeCliente { get; set; }
        public List<CambioEstado> CambioEstado { get; set; }
        public Cliente Cliente { get; set; }
        

        //!Verificar ESDEPERIODO
        public bool EsDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            return true;
        }

        public string getNombreClienteDeLlamada()
        {
            return this.Cliente.NombreCompleto;
        }

        //!IMPLEMENTAR getRespuestas
        public List<RespuestaDeCliente> getRespuestas()
        {
            return this.RespuestasDeCliente;
        }

        //Verificar EXISTENRESPUESTAS
        public bool ExistenRespuestas()
        {
            if(this.RespuestasDeCliente.Count <= 0)
            {
                return false;
            }
            return true;
        }

    }
}
