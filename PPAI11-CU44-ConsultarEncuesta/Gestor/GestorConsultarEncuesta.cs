using PPAI11_CU44_ConsultarEncuesta.Entidades;
using PPAI11_CU44_ConsultarEncuesta.Interfaz;
using PPAI11_CU44_ConsultarEncuesta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI11_CU44_ConsultarEncuesta.Gestor
{
    public class GestorConsultarEncuesta
    {
        static public List<DataGridViewRow> filaGrillaLlamadas = new List<DataGridViewRow>();
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

        public Llamada llamadaSeleccionada { get; set; }

        //Lista de llamadas de BD
        public List<Llamada> Llamadas { get; set; }

        public List<Encuesta> Encuestas { get; set; }

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

        public GestorConsultarEncuesta(List<Llamada> llamadas, List<Encuesta> encuestas)
        {
            this.Llamadas = llamadas;
            this.Encuestas = encuestas;
        }

        public List<Llamada> consultarEncuesta(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            filaGrillaLlamadas.Clear();

            //REVISAR SI ESTA MAL
            List<Llamada> LlamadasAMostrar = filtrarPorPeriodo(fechaInicioPeriodo, fechaFinPeriodo);
            LlamadasAMostrar = filtrarQueTenganEncuestas(LlamadasAMostrar);

            if(LlamadasAMostrar.Count == 0)
            {
                MessageBox.Show("No hay llamadas en el periodo con encuestas respondidas!", "No hay llamadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return LlamadasAMostrar;
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
            List<Llamada> LlamadasFiltradas = new List<Llamada>();
            for(var i = 0; i < this.Llamadas.Count; i++)
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

        public void tomarOpcionLlamada(Llamada llamadaSeleccionada)
        {
            this.llamadaSeleccionada = llamadaSeleccionada;
        }

        public List<String> mostrarDatosLlamada()
        {
            string nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoLlamada = llamadaSeleccionada.esUltimoEstado();
            string duracionLlamada = llamadaSeleccionada.duracion.ToString();
            List<RespuestaDeCliente> respuestasCliente = llamadaSeleccionada.getRespuestas();
            List<String> listaPreguntas = new List<string>();
            
            
            for (var i = 0; i < this.Encuestas[0].pregunta.Count; i++)
            {
                listaPreguntas.Add(Encuestas[0].pregunta[i].descripcion);
            }

            List<String> LlamadaConPreguntas = new List<string>
            {
                nombreCliente,
                estadoLlamada,
                duracionLlamada
            };

            for (int j = 0; j < listaPreguntas.Count; j++)
            {
                LlamadaConPreguntas.Add(listaPreguntas[j]);
                LlamadaConPreguntas.Add(respuestasCliente[j].respuestaSeleccionada.valor.ToString());
            }

            return LlamadaConPreguntas;
        }

        public void tomarOpcionGenerarCSV()
        {

        }

        public void generarArchivoCSV()
        {

        }

        public void finCU()
        {
            MessageBox.Show("Se cancela el CU!", "CU Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(1);
        }

    }
}
