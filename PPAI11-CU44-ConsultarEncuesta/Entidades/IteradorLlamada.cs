using PPAI11_CU44_ConsultarEncuesta.Datos.Modelos;
using PPAI11_CU44_ConsultarEncuesta.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//el gestor le pasa los datos a la llamada?

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class IteradorLlamada : Iiterador
    {
        private List<Llamada> listaLlamadas;
        private int posicionActual;
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private LlamadaModelo modeloLlamada = new LlamadaModelo();

        public IteradorLlamada(DateTime fechaInicio, DateTime fechaFin)
        {
            //el iterador ya conoce a las llamadas
            this.listaLlamadas = modeloLlamada.mostrarLlamadas();
            fechaInicioPeriodo = fechaInicio;
            fechaFinPeriodo = fechaFin;
        }

        public Llamada actual()
        {
            Llamada actual = this.listaLlamadas[posicionActual];
            return (this.cumpleFiltros(actual)) ? actual : null;

        }

        public bool cumpleFiltros(Llamada actual)
        {
            return (actual.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo) && actual.existenRespuestas());
        }

        public bool haTerminado()
        {
            return (posicionActual < this.listaLlamadas.Count);
        }

        public void primero()
        {
            this.posicionActual = 0;
        }

        public void siguiente()
        {
            this.posicionActual += 1;
        }
    }
}
