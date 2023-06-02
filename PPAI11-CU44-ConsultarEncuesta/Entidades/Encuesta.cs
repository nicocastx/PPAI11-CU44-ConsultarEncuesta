using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    internal class Encuesta
    {
        public string descripcion { get; set; }

        public DateTime fechaFinVigencia { get; set; }

        //Constructor
        public Encuesta(string descripcion, DateTime fechaFinVigencia)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
        }

        internal string getDescripcionEncuesta()
        {
            return this.descripcion;
        }
    }
}
