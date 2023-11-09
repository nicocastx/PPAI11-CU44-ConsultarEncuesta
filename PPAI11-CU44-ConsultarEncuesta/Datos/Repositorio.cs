using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PPAI11_CU44_ConsultarEncuesta.Datos
{
    public class RepositorioBD
    {
        private static RepositorioBD instance;
        private SqlConnection conn;
        private SqlCommand comando;
        private SqlTransaction dbTransaction;
        private String cadenaConexion;

        public RepositorioBD()
        {
            //con este metodo, se abre la conexion a la BD, modificar de manera local
            this.cadenaConexion = "Data Source=KEVINCASTILLOPC;Initial Catalog=PPAI11CU44DSI2023;Integrated Security=True";
            this.conn = new SqlConnection(this.cadenaConexion);
        }

        public void BeginTransaction()
        {
            if (conn.State == ConnectionState.Open)
            {
                dbTransaction = conn.BeginTransaction();
            }
        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }
        public void Open()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        public static RepositorioBD ObtenerInstancia()
        {
            if (instance == null)
                instance = new RepositorioBD();

            return instance;
        }

        public DataTable Ejecutar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conn.ConnectionString = this.cadenaConexion;
            conn.Open();
            comando.Connection = conn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            conn.Close();
            return tabla;
        }

        public void Actualizar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conn.ConnectionString = this.cadenaConexion;
            conn.Open();
            comando.Connection = conn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            conn.Close();
        }

        public int Transaccion(string consultaSQL)
        {
            int resultado = 0;

            try
            {
                comando.Connection = conn;
                comando.Transaction = dbTransaction;
                comando.CommandType = CommandType.Text;

                // Instrucción a Ejecutar
                comando.CommandText = consultaSQL;

                resultado = comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }


        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }



    }
}
