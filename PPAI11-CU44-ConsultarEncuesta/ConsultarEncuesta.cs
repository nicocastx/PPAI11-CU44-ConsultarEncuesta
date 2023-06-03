using PPAI11_CU44_ConsultarEncuesta.Entidades;
using PPAI11_CU44_ConsultarEncuesta.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI11_CU44_ConsultarEncuesta
{
    public partial class ConsultarEncuesta : Form
    {

        /*public GestorConsultarEncuesta()
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
        public ConsultarEncuesta()
        {
            InitializeComponent();
        }

        public static GestorConsultarEncuesta gestorCE = new GestorConsultarEncuesta();

        private void ConsultarEncuesta_Load(object sender, EventArgs e)
        {
            gestorCE.consultarEncuesta();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            EncuestaCSV encuestaCSV = new EncuestaCSV();
            encuestaCSV.Show();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
