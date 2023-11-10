using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class RespuestaPosibleModelo
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "RespuestaPosible";

        public List<RespuestaPosible> respuestasDePregunta(int idPregunta)
        {
            List<RespuestaPosible> listaRespuestas = new List<RespuestaPosible>();

            DataTable dt = repo.Ejecutar($"SELECT * FROM {tabla} WHERE idPregunta = {idPregunta}");

            foreach (DataRow dr in dt.Rows)
            {
                RespuestaPosible rp = new RespuestaPosible(dr.Field<String>("descripcion"), dr.Field<int>("valor"));
                listaRespuestas.Add(rp);
            }

            return listaRespuestas;
        }
    }
}
