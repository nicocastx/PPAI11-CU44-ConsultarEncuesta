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
        }

        public void consultarEncuesta() { 
        }

        public void tomarFechaInicio()
        {
        }

        public void tomarFechaFin()
        {
        }

        public void filtrarPorPeriodo()
        {
        }

        public void filtrarQueTenganEncuestas()
        {
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
