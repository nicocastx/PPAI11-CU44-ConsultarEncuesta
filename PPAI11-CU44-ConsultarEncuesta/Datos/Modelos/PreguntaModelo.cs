using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class PreguntaModelo
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "Pregunta";
        private RespuestaPosibleModelo repoRP = new RespuestaPosibleModelo();

        public List<Pregunta> preguntasDeEncuesta(int idEncuesta)
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();

            DataTable dt = repo.Ejecutar($"SELECT * FROM {tabla} WHERE id = {idEncuesta}");

            foreach (DataRow dr in dt.Rows)
            {
                List<RespuestaPosible> listaRP = repoRP.respuestasDePregunta(dr.Field<int>("id"));
                Pregunta pregunta = new Pregunta(dr.Field<String>("pregunta"), listaRP);
                listaPreguntas.Add(pregunta);
            }
            return listaPreguntas;
        }
    }
}
