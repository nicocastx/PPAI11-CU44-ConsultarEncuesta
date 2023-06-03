using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System.Collections.Generic;

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

        public static List<Llamada> Llamada()
        {
            List<Llamada> listaLlamadas = new List<Llamada>();

            //Listas de cambios de estado
            List<CambioEstado> cambioEstados1 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados2 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados3 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados4 = new List<CambioEstado>();

            //Cambios de estado para llamada 1

            //Cambios de estado para llamada 2

            //Cambios de estado para llamada 3

            //Cambios de estado para llamada 4


            return listaLlamadas;
            
        }

        public static List<List<CambioEstado>>
    }
}
