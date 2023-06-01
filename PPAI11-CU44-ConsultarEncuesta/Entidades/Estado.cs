using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class Estado
    {
        public string Nombre { get; set; }

        public bool esIniciada()
        {
            if(this.Nombre == "Iniciada")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
