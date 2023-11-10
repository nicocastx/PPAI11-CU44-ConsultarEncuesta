using System.Collections.Generic;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Pregunta
    {
        public string pregunta { get; set; }

        public List<RespuestaPosible> respuesta { get; set; }

        //Constructor tito gato
        public Pregunta(string descripcion, List<RespuestaPosible> respuestaPosible)
        {
            this.pregunta = descripcion;
            this.respuesta = respuestaPosible;
        }

        public string getPregunta()
        {
            return this.pregunta;
        }

        public List<RespuestaPosible> getRespuestasPosibles()
        {
            return this.respuesta;
        }

    }
}
