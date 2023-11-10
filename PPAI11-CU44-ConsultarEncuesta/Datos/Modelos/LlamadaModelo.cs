using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class LlamadaModelo
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "Llamada";
        private RespuestaClienteModelo repoRC = new RespuestaClienteModelo();
        private CambioEstadoModel repoCE = new CambioEstadoModel();
        private ClienteModelo repoCli = new ClienteModelo();

        public List<Llamada> mostrarLlamadas()
        {
            List<Llamada> listaLlamadas = new List<Llamada>();

            DataTable dt = repo.Ejecutar($"SELECT * FROM {tabla}");

            foreach(DataRow dr in dt.Rows)
            {
                List<RespuestaDeCliente> respuestaDeClientes = repoRC.listaRespuestasClienteLlamada(dr.Field<int>("id"));
                List<CambioEstado> cambioEstados = repoCE.traerCambioEstadoLlamada(dr.Field<int>("id"));
                Cliente cli = repoCli.getClienteDni(dr.Field<int>("dniCliente"));
                Llamada llamada = new Llamada(dr.Field<String>("descripcionOperador"), dr.Field<String>("detalleAccionRequerida"),
                    dr.Field<bool>("encuestaEnviada"), dr.Field<String>("observacionAuditor"), respuestaDeClientes, cambioEstados, cli) ;
                listaLlamadas.Add(llamada);
            }

            return listaLlamadas;
        }
    }
}
