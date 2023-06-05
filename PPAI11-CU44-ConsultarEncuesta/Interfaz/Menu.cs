using PPAI11_CU44_ConsultarEncuesta.Interfaz;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            ConsultarEncuesta consultarencuesta = new ConsultarEncuesta();
            this.Hide();
            consultarencuesta.Show();
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
