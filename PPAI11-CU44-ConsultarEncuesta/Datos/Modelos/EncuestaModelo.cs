using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class EncuestaModelo
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "Encuesta";
        private PreguntaModelo preguntaModelo = new PreguntaModelo();

        public List<Encuesta> TraerEncuestas()
        {
            List<Encuesta> listaEncuestas = new List<Encuesta>();

            DataTable dt = repo.Ejecutar($"SELECT * FROM {tabla}");

            foreach(DataRow dr in dt.Rows)
            {
                List<Pregunta> preguntas = preguntaModelo.preguntasDeEncuesta(dr.Field<int>("id"));
                Encuesta encuesta = new Encuesta(dr.Field<String>("descripcion"), dr.Field<DateTime>("fechaFinVigencia"), preguntas);
                listaEncuestas.Add(encuesta);
            }

            return listaEncuestas;
        }
    }
}
