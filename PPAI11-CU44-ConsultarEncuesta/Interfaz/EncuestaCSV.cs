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
    public partial class EncuestaCSV : Form
    {
        public List<String> LlamadaSeleccionada { get; set; }
        public static GestorConsultarEncuesta gestorCE = new GestorConsultarEncuesta(BD.ListaLlamadas(), BD.ListaEncuestas());

        public EncuestaCSV()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        public void generarArchivo()
        {
            // Acceder a los datos de la llamada seleccionada
            string nombreCliente = LlamadaSeleccionada[0];
            string estadoLlamada = LlamadaSeleccionada[1];
            string duracionLlamada = LlamadaSeleccionada[2];

            // Actualizar los controles en tu formulario con los datos obtenidos
            LblDato.Text = nombreCliente+ ", " + estadoLlamada +", " + duracionLlamada + " Minutos";
            LblPreguntasDatos.Text = "";
            for (int i = 3; i < LlamadaSeleccionada.Count; i++)
            {
                LblPreguntasDatos.Text += $"{LlamadaSeleccionada[i]}\n";
            }
        }


        private void EncuestaCSV_Load(object sender, EventArgs e)
        {
            generarArchivo();
            // Calcular el tamaño necesario para mostrar completamente el control LblPreguntasDatos
            int padding = 10; // Espacio adicional para un mejor aspecto visual
            int eWidth = LblPreguntasDatos.Right + padding;
            int eHeight = LblPreguntasDatos.Bottom + padding;

            // Establecer el tamaño del formulario
            this.ClientSize = new Size(eWidth, eHeight);
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
