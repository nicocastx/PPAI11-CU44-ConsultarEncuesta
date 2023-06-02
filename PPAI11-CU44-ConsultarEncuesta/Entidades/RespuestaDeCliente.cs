using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{

    public class RespuestaDeCliente
    {
        public readonly RespuestaPosible respuestaPosible;
        public DateTime FechaEncuesta { get; set; }

        public string getDescripcionRta()
        {
            return respuestaPosible.getDescripcionRta();
        }
    }
}
