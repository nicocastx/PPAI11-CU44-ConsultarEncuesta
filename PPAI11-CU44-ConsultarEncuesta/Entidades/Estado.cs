using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class Estado
    {
        public string nombre { get; set; }

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        public bool esIniciada()
        {
            if(this.nombre == "Iniciada")
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
