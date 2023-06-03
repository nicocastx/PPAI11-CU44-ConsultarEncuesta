using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Encuesta
    {
        public string descripcion { get; set; }

        public DateTime fechaFinVigencia { get; set; }

        public List<Pregunta> pregunta { get; set; }

        //Constructor
        public Encuesta(string descripcion, DateTime fechaFinVigencia, List<Pregunta> pregunta)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.pregunta = pregunta;
        }

        internal string getDescripcionEncuesta()
        {
            return this.descripcion;
        }
    }
}
