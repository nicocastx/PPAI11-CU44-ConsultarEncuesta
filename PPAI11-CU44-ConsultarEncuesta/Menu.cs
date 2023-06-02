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
            consultarencuesta.Show();
        }
    }
}
