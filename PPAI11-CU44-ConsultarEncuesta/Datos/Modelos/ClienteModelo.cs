using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class ClienteModelo
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String tabla = "Cliente";

        public Cliente getClienteDni(int dniBuscar)
        {
            DataTable dt = repo.Ejecutar($"SELECT * FROM {tabla} where dni = {dniBuscar}");
            DataRow dr = dt.Rows[0];

            Cliente cli = new Cliente(dr.Field<int>("dni"), dr.Field<String>("nombreCompleto"), dr.Field<int>("nroCelular")); ;
            return cli;
        }
    }
}
