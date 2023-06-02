using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class Pregunta
    {
        public string descripcion { get; set; }

        //Constructor
        public Pregunta(string descripcion)
        {
            this.descripcion = descripcion;
        }

        internal string getDescripcion()
        {
            return this.descripcion;
        }
    }
}
