using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI11_CU44_ConsultarEncuesta.Datos.Modelos
{
    internal class EstadoModel
    {
        private RepositorioBD repo = RepositorioBD.ObtenerInstancia();
        private String Tabla = "Estado";

        public List <Estado> ListaEstados()
        {
            List < Estado > estados = new List<Estado>();
            DataTable Estados = repo.Ejecutar($"SELECT * FROM {Tabla}");
            foreach(DataRow rowEstado in Estados.Rows)
            {
                estados.Add(new Estado(rowEstado.Field<String>("nombre")));
            }

            return estados;
        }

        public Estado traerEstado(int id)
        {
            DataTable dt = repo.Ejecutar($"SELECT * FROM Estado WHERE id = ${id}");

            return new Estado(dt.Rows[0].Field<String>("nombre"));
        }
    }
}
