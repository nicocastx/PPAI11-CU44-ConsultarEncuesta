using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{

    public class RespuestaDeCliente
    {
        public DateTime fechaEncuesta { get; set; }
        public RespuestaPosible respuestaSeleccionada { get; set; }

        public RespuestaDeCliente(RespuestaPosible respuestaSeleccionada, DateTime fechaEncuesta)
        {
            this.respuestaSeleccionada = respuestaSeleccionada;
            this.fechaEncuesta = fechaEncuesta;
        }

        public string getDescripcionRta()
        {
            return respuestaSeleccionada.getDescripcionRta();
        }
    }
}
