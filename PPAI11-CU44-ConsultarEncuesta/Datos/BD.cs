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
        static string descripcionRP15 = "Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.";
        static string descripcionRP12 = "Ingrese el 1 para marcar 'Sí' o ingrese el 2 para marcar 'No'.";

        /*Objetos Cliente*/
        public static List<Cliente> ListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente clienteUno = new Cliente(43881554, "Fransico Ahumada", 352659835);
            Cliente clienteDos = new Cliente(42114678, "Ernesto Ducart", 351657866);
            Cliente clienteTres = new Cliente(4177953, "Agustin Ortega", 351597243);
            Cliente clienteCuatro = new Cliente(43881554, "Agostina Beletti", 351237966);
            Cliente clienteCinco = new Cliente(43224678, "Leandro Colmenares", 351457292);

            clientes.Add(clienteUno);
            clientes.Add(clienteDos);
            clientes.Add(clienteTres);
            clientes.Add(clienteCuatro);
            clientes.Add(clienteCinco);

            return clientes;
        }
    }
}
