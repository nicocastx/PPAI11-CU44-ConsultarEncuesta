using PPAI11_CU44_ConsultarEncuesta.Datos;
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

        public static BD datos = new BD();
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
            List<Llamada> llamadas = BD.ListaLlamadas();
            DGV.AutoGenerateColumns = false;

            DGV.DataSource = llamadas;

            DataGridViewTextBoxColumn columnaCliente = new DataGridViewTextBoxColumn();
            columnaCliente.HeaderText = "Cliente";
            columnaCliente.Name = "Cliente";
            columnaCliente.ReadOnly = true;
            DGV.Columns.Add(columnaCliente);

            DataGridViewTextBoxColumn columnaDuracion = new DataGridViewTextBoxColumn();
            columnaDuracion.DataPropertyName = "duracion";
            columnaDuracion.HeaderText = "Duración";
            DGV.Columns.Add(columnaDuracion);

            DataGridViewTextBoxColumn columnaAccionRequerida = new DataGridViewTextBoxColumn();
            columnaAccionRequerida.DataPropertyName = "detalleAccionRequerida";
            columnaAccionRequerida.HeaderText = "Acción Requerida";
            DGV.Columns.Add(columnaAccionRequerida);

            // Configurar el valor del nombre del cliente en la columna "Cliente"
            foreach (DataGridViewRow fila in DGV.Rows)
            {
                Llamada llamada = fila.DataBoundItem as Llamada;
                fila.Cells["Cliente"].Value = llamada.cliente.NombreCompleto;
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = DGV.Rows[e.RowIndex];

                // Obtener el estado de la llamada

                // Obtener la llamada seleccionada
                Llamada llamadaSeleccionada = filaSeleccionada.DataBoundItem as Llamada;

                // Acceder a los datos de la llamada seleccionada
                string nombreCliente = llamadaSeleccionada.cliente.NombreCompleto;
                string estadoLlamada = llamadaSeleccionada.cambioEstado[1].Estado.nombre;
                string duracionLlamada = llamadaSeleccionada.duracion.ToString();


                // Actualizar los controles en tu formulario con los datos obtenidos
                LblClienteDato.Text = nombreCliente;
                LblEstadoDato.Text = estadoLlamada;
                LblDuracionDato.Text = duracionLlamada;

            }
        }

    }
}
