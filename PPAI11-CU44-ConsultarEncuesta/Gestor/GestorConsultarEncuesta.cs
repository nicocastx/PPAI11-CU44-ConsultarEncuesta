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
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

        public Llamada llamadaSeleccionada { get; set; }

        //Lista de llamadas de BD
        public List<Llamada> Llamadas { get; set; }

        public List<Encuesta> Encuestas { get; set; }

        public List<String> LlamadaConPreguntas { get; set; }

        public GestorConsultarEncuesta(List<Llamada> llamadas, List<Encuesta> encuestas)
        {
            this.Llamadas = llamadas;
            this.Encuestas = encuestas;
            LlamadaConPreguntas = new List<string>();
        }

        //metodo consultarEncuesta
        public List<Llamada> consultarEncuesta(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {

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

        //metodo filtrar por periodo: toma de parametros la fecha inicio y la fecha fin y a la entidad de llamadas
        //las filtra por el periodo seleccionado
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

        //filtrarQueTenganEncuestas: Toma las llamadas del periodo y las filtra por las que tengan respuestas existentes
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
            //metodo de llamada para mostrar sus atributos
            string nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoLlamada = llamadaSeleccionada.esUltimoEstado();
            string duracionLlamada = llamadaSeleccionada.duracion.ToString();
            List<RespuestaDeCliente> respuestasCliente = llamadaSeleccionada.getRespuestas();
            List<String> listaPreguntas = new List<string>();

            //agrega todas las descripciones de las preguntas a un listado de preguntas 
            for (var i = 0; i < this.Encuestas[0].pregunta.Count; i++)
            {
                listaPreguntas.Add(Encuestas[0].pregunta[i].descripcion);
            }

            //Se crea una lista de strings que luego sera mostrada

            this.LlamadaConPreguntas.Add(nombreCliente);
            this.LlamadaConPreguntas.Add(estadoLlamada);
            this.LlamadaConPreguntas.Add(duracionLlamada);
            
            //agrega todas las preguntas con su respuesta a la lista de strings
            for (int j = 0; j < listaPreguntas.Count; j++)
            {
                LlamadaConPreguntas.Add(listaPreguntas[j]);
                LlamadaConPreguntas.Add(respuestasCliente[j].respuestaSeleccionada.valor.ToString());
            }

            //se asigna la llamada con preguntas al atributo del gestor
            return LlamadaConPreguntas;
        }

        public void generarArchivoCSV()
        {
            if(LlamadaConPreguntas.Count > 0)
            {
                EncuestaCSV encuestaCSV = new EncuestaCSV();
                encuestaCSV.LlamadaSeleccionada = LlamadaConPreguntas;
                ConsultarEncuesta.ActiveForm.Hide();
                encuestaCSV.Show();
            };
        }

        public void finCU()
        {
            MessageBox.Show("Se cancela el CU!", "CU Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(1);
        }

    }
}
