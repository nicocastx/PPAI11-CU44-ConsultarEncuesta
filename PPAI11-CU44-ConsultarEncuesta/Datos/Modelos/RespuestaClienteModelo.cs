using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class RespuestaClienteModelo
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "RespuestaCliente";
        private RespuestaPosibleModelo repoRP = new RespuestaPosibleModelo();

        public List<RespuestaDeCliente> listaRespuestasClienteLlamada(int idLlamada)
        {
            List<RespuestaDeCliente> respuestaDeClientes = new List<RespuestaDeCliente>();

            DataTable dt = repo.Ejecutar($"SELECT * FROM {tabla} WHERE idLlamada = {idLlamada}");

            foreach ( DataRow dr in dt.Rows)
            {
                RespuestaPosible rpElegida = repoRP.traerRespuestaPosible(dr.Field<int>("idRespuestaPosible"));
                RespuestaDeCliente rpCliente = new RespuestaDeCliente(rpElegida, dr.Field<DateTime>("fechaEncuesta"));

                respuestaDeClientes.Add(rpCliente);
            }

            return respuestaDeClientes;
        }

    }
}
