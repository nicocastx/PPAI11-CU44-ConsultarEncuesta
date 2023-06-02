using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class RespuestaPosible
    {
        public string Descripcion { get; set; }
        public int Valor { get; set;}

        public string getDescripcionRta()
        {
            return this.Descripcion;
        }
    }
}
