using System.Collections.Generic;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Pregunta
    {
        public string descripcion { get; set; }

        public List<RespuestaPosible> respuesta { get; set; }

        //Constructor tito gato
        public Pregunta(string descripcion, List<RespuestaPosible> respuestaPosible)
        {
            this.descripcion = descripcion;
            this.respuesta = respuestaPosible;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public List<RespuestaPosible> getRespuestasPosibles()
        {
            return this.respuesta;
        }

    }
}
