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
        public DateTime fechaEncuesta { get; set; }

        public RespuestaDeCliente(RespuestaPosible respuestaPosible, DateTime fechaEncuesta)
        {
            this.respuestaPosible = respuestaPosible;
            this.fechaEncuesta = fechaEncuesta;
        }

        public string getDescripcionRta()
        {
            return respuestaPosible.getDescripcionRta();
        }
    }
}
