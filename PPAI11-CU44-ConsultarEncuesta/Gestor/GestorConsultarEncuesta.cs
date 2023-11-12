using PPAI11_CU44_ConsultarEncuesta.Entidades;
using PPAI11_CU44_ConsultarEncuesta.Interfaz;
using PPAI11_CU44_ConsultarEncuesta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI11_CU44_ConsultarEncuesta.Datos.Modelos;
using System.Diagnostics;
using PPAI11_CU44_ConsultarEncuesta.Entidades.Interfaces;

namespace PPAI11_CU44_ConsultarEncuesta.Gestor
{
    public class GestorConsultarEncuesta
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

        public Llamada llamadaSeleccionada { get; set; }

        public List<Encuesta> Encuestas { get; set; }

        //aplicacion del iterator
        public Iiterador iteradorLlamada { get; set; }

        public List<Llamada> llamadasDePeriodoYRta { get; set; }


        //Interaccion con la interfaz consultarEncuesta
        public ConsultarEncuesta FormConsultar { get; set; }



        public GestorConsultarEncuesta(List<Encuesta> encuestas, ConsultarEncuesta formularioEncuesta)
        {
            this.Encuestas = encuestas;
            llamadasDePeriodoYRta = new List<Llamada>();
            FormConsultar = formularioEncuesta;
        }

        //EMPIEZA ACA A ITERAR
        public void filtrarPorPeriodoYEncuesta()
        {
            this.iteradorLlamada = crearIterador();
            iteradorLlamada.primero();
            while (iteradorLlamada.haTerminado())
            {
                if (iteradorLlamada.actual() != null)
                {
                    this.llamadasDePeriodoYRta.Add(iteradorLlamada.actual());
                }
                iteradorLlamada.siguiente();
            }

            if (llamadasDePeriodoYRta.Count == 0)
            {
                MessageBox.Show("No hay llamadas en el periodo con encuestas respondidas!", "No hay llamadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FormConsultar.mostrarLlamadasConPeriodoYEncuesta(llamadasDePeriodoYRta);
        }

        private Iiterador crearIterador()
        {
            return new IteradorLlamada(fechaInicio, fechaFin);
        }

        public void tomarFechaInicio(DateTime fechaInicioIngresada)
        {
            this.fechaInicio = fechaInicioIngresada;
        }

        public void tomarFechaFin(DateTime fechaFinIngresada)
        {
            this.fechaFin = fechaFinIngresada;
        }

        public void tomarOpcionLlamada(Llamada llamadaSeleccionada)
        {
            this.llamadaSeleccionada = llamadaSeleccionada;
        }
        
        public List<String> mostrarDatosLlamada(List<string> LlamadaConPreguntas)
        {
            //metodo de llamada para mostrar sus atributos
            if (llamadaSeleccionada == null)
            {
                return new List<String>();
            }
            string nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoLlamada = llamadaSeleccionada.esUltimoEstado();
            string duracionLlamada = llamadaSeleccionada.duracion.ToString();
            List<RespuestaDeCliente> respuestasCliente = llamadaSeleccionada.getRespuestas();
            List<String> listaPreguntas = new List<string>();

            //agrega todas las descripciones de las preguntas a un listado de preguntas 
            for (var i = 0; i < this.Encuestas[0].pregunta.Count; i++)
            {
                listaPreguntas.Add(Encuestas[0].pregunta[i].pregunta);
            }

            //Se crea una lista de strings que luego sera mostrada

            LlamadaConPreguntas.Clear();
            LlamadaConPreguntas.Add(nombreCliente);
            LlamadaConPreguntas.Add(estadoLlamada);
            LlamadaConPreguntas.Add(duracionLlamada);
            
            //agrega todas las preguntas con su respuesta a la lista de strings
            for (int j = 0; j < listaPreguntas.Count; j++)
            {
                LlamadaConPreguntas.Add(listaPreguntas[j]);
                LlamadaConPreguntas.Add(respuestasCliente[j].respuestaSeleccionada.valor.ToString());
            }

            //se asigna la llamada con preguntas al atributo del gestor
            return LlamadaConPreguntas;
        }

        public void generarArchivoCSV(List<String> LlamadaConPreguntas)
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
