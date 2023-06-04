using PPAI11_CU44_ConsultarEncuesta.Entidades;
using PPAI11_CU44_ConsultarEncuesta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Gestor
{
    public class GestorConsultarEncuesta
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Llamada Llamada { get; set; }

        /*public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public bool esDePeriodo { get; set; }
        public List<Llamada> llamadasDePeriodo { get; set; }
        public string nombreCliente { get; set; }
        public int duracion { get; set; }
        public List<RespuestaPosible> respuestas { get; set; }
        public List<Pregunta> preguntas { get; set; }

        public GestorConsultarEncuesta()
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.esDePeriodo = esDePeriodo;
            this.llamadasDePeriodo = llamadasDePeriodo;
            this.nombreCliente = nombreCliente;
            this.duracion = duracion;
            this.respuestas = respuestas;
            this.preguntas = preguntas;
        }*/

        public void consultarEncuesta()
        { 

        }

        public void tomarFechaInicio(DateTime fechaInicioIngresada)
        {
            this.fechaInicio = fechaInicioIngresada;
        }

        public void tomarFechaFin(DateTime fechaFinIngresada)
        {
            this.fechaFin = fechaFinIngresada;
        }

        public List<Llamada> filtrarPorPeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            List<Llamada> Llamadas = BD.ListaLlamadas();
            List<Llamada> LlamadasFiltradas = new List<Llamada>();
            for(var i = 0; i < Llamadas.Count; i++)
            {
                if (Llamadas[i].EsDePeriodo(fechaInicioPeriodo, fechaFinPeriodo))
                {
                    LlamadasFiltradas.Add(Llamadas[i]);
                }
            }
            return LlamadasFiltradas;
        }

        public List<Llamada> filtrarQueTenganEncuestas(List<Llamada> Llamadas)
        {
            List<Llamada> LlamadasFiltradasConEncuesta = new List<Llamada>();
            for (var i = 0; i < Llamadas.Count; i++)
            {
                if (Llamadas[i].ExistenRespuestas())
                {
                    LlamadasFiltradasConEncuesta.Add(Llamadas[i]);
                }
            }
            return LlamadasFiltradasConEncuesta;
        }

        public void tomarOpcionLlamada()
        {
        }

        public void mostrarDatosLlamada()
        {
        }

        public void tomarOpcionGenerarCSV()
        {
        }

        public void generarArchivoCSV()
        {
        }
    }
}
