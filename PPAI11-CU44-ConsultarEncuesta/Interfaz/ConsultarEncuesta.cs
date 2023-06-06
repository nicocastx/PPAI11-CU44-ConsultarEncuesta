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

namespace PPAI11_CU44_ConsultarEncuesta.Interfaz
{
    public partial class ConsultarEncuesta : Form
    {
        public List<String> LlamadaSeleccionada { get; set; }

        public ConsultarEncuesta()
        {
            InitializeComponent();
            this.LlamadaSeleccionada = new List<String>();
        }

        public static GestorConsultarEncuesta gestorCE = new GestorConsultarEncuesta(BD.ListaLlamadas(), BD.ListaEncuestas());

        private void ConsultarEncuesta_Load(object sender, EventArgs e)
        {

            DGV.AutoGenerateColumns = false;
            // Configurar el modo de ajuste automático para las columnas
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar el ancho de las columnas existentes
            DGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

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
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            gestorCE.finCU();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {            
            gestorCE.finCU();
        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            gestorCE.generarArchivoCSV(LlamadaSeleccionada);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DGV.DataSource = gestorCE.consultarEncuesta(fechaInicio.Value, fechaFin.Value);

            // Configurar el valor del nombre del cliente en la columna "Cliente"
            foreach (DataGridViewRow fila in DGV.Rows)
            {
                Llamada llamada = fila.DataBoundItem as Llamada;
                fila.Cells["Cliente"].Value = llamada.cliente.NombreCompleto;
            }
        }

        //solicitar Opcion Llamada
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = DGV.Rows[e.RowIndex];

                // Obtener el estado de la llamada

                // Obtener la llamada seleccionada
                //Llamada llamadaSeleccionada = filaSeleccionada.DataBoundItem as Llamada;

                gestorCE.tomarOpcionLlamada(filaSeleccionada.DataBoundItem as Llamada);

                gestorCE.mostrarDatosLlamada(LlamadaSeleccionada);

                mostrarDatosLlamadaSeleccionada();
            }
        }

        //metodo mostrarDatosLlamadaSeleccionada: muestra
        public void mostrarDatosLlamadaSeleccionada()
        {
            // Acceder a los datos de la llamada seleccionada
            string nombreCliente = LlamadaSeleccionada[0];
            string estadoLlamada = LlamadaSeleccionada[1];
            string duracionLlamada = LlamadaSeleccionada[2];

            // Actualizar los controles en tu formulario con los datos obtenidos
            LblClienteDato.Text = nombreCliente;
            LblEstadoDato.Text = estadoLlamada;
            LblDuracionDato.Text = duracionLlamada + " Minutos";
            LblPreguntasDatos.Text = "";
            for (int i = 3; i < LlamadaSeleccionada.Count; i++)
            {
                LblPreguntasDatos.Text += $"{LlamadaSeleccionada[i]}\n";
            }
        }

        int m, mx, my;
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

    }
}
