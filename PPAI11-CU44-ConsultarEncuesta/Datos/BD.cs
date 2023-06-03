using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos
{
    public class BD
    {
        public static List<Cliente> ListaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente clienteUno = new Cliente(Dni: 23123133,NombreCompleto: "asd", NroCelular: 231123123);
            Cliente clienteDos = new Cliente(Dni: 23123133, NombreCompleto: "asd", NroCelular: 231123123);
            listaClientes.Add(clienteUno);

            return listaClientes;
        }

        public static List<Cliente> ListaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente clienteUno = new Cliente(Dni: 23123133, NombreCompleto: "asd", NroCelular: 231123123);
            Cliente clienteDos = new Cliente(Dni: 23123133, NombreCompleto: "asd", NroCelular: 231123123);
            listaClientes.Add(clienteUno);

            return listaClientes;
        }
    }
}
