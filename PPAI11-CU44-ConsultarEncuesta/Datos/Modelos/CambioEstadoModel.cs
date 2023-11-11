using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    public class CambioEstadoModel
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "CambioEstado";
        private EstadoModel modeloEstados = new EstadoModel();

        /*public List<CambioEstado> listaEstados()
        {
            List<CambioEstado> cambioEstados = new List<CambioEstado>();

            DataTable listaData = repo.Ejecutar($"SELECT * from CambioEstado");

            foreach(DataRow dr in listaData.Rows)
            {
                Estado estadoCE = estadoModel.traerEstado();
                CambioEstado ce = new CambioEstado();
            }
        }*/

        public CambioEstado traerCambioEstadoPorId(int id)
        {
            DataTable dt = repo.Ejecutar($"SELECT * from CambioEstado WHERE id = {id}");
            Estado estadoAdjunto = modeloEstados.traerEstado(dt.Rows[0].Field<int>("idEstado"));
            return new CambioEstado(dt.Rows[0].Field<DateTime>("fechaHoraInicio"), estadoAdjunto);
        }

        public List<CambioEstado> traerCambioEstadoLlamada(int idLlamada)
        {
            List<CambioEstado> listaCELlamada = new List<CambioEstado>();
            DataTable dt = repo.Ejecutar($"SELECT * from CambioEstado WHERE idLlamada = {idLlamada}");

            foreach(DataRow dr in dt.Rows)
            {
                Estado estadoAdjunto = modeloEstados.traerEstado(dr.Field<int>("idEstado"));
                CambioEstado ceLlamada = new CambioEstado(dr.Field<DateTime>("fechaHoraInicio"), estadoAdjunto);
                listaCELlamada.Add(ceLlamada);
            }

            return listaCELlamada;
        }
    }
}
