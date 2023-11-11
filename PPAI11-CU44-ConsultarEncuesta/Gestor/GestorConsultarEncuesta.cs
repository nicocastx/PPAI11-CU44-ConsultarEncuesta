﻿using PPAI11_CU44_ConsultarEncuesta.Entidades;
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

        //Lista de llamadas de BD
        public List<Llamada> Llamadas { get; set; }

        public List<Encuesta> Encuestas { get; set; }

        //aplicacion del iterator
        public Iiterador iteradorLlamada { get; set; }


        public GestorConsultarEncuesta(List<Llamada> llamadas, List<Encuesta> encuestas)
        {
            this.Llamadas = llamadas;
            this.Encuestas = encuestas;
        }

        //metodo consultarEncuesta
        public List<Llamada> consultarEncuesta()
        {

            List<Llamada> LlamadasAMostrar = filtrarPorPeriodoYEncuesta();


            if(LlamadasAMostrar.Count == 0)
            {
                MessageBox.Show("No hay llamadas en el periodo con encuestas respondidas!", "No hay llamadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return LlamadasAMostrar;
        }

        private List<Llamada> filtrarPorPeriodoYEncuesta()
        {
            List<Llamada> llamadasFiltradas = new List<Llamada>();
            this.iteradorLlamada = crearIterador(fechaInicio, fechaFin);
            iteradorLlamada.primero();
            while (iteradorLlamada.haTerminado())
            {
                if (iteradorLlamada.actual() != null)
                {
                    llamadasFiltradas.Add(iteradorLlamada.actual());
                }
                iteradorLlamada.siguiente();
            }
            return llamadasFiltradas;
        }

        private Iiterador crearIterador(DateTime fechaInicio, DateTime fechaFin)
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

        //metodo filtrar por periodo: toma de parametros la fecha inicio y la fecha fin y a la entidad de llamadas
        //las filtra por el periodo seleccionado
        public List<Llamada> filtrarPorPeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            List<Llamada> LlamadasFiltradas = new List<Llamada>();
            for(var i = 0; i < this.Llamadas.Count; i++)
            {
                if (Llamadas[i].esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo))
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
                if (Llamadas[i].existenRespuestas())
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
