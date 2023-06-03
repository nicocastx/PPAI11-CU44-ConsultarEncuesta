using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Pregunta
    {
        public string descripcion { get; set; }

        public List<RespuestaPosible> respuesta { get; set; }

        //Constructor 
        public Pregunta(string descripcion, List<RespuestaPosible> respuestaPosible)
        {
            this.descripcion = descripcion;
            this.respuesta = respuestaPosible;
        }

        internal string getDescripcion()
        {
            return this.descripcion;
        }
    }
}
