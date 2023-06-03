using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string NombreCompleto { get; set; }
        public int NroCelular { get; set; }

        public Cliente() { }
        public Cliente(int Dni, string NombreCompleto, int NroCelular)
        {
            this.Dni = Dni;
            this.NombreCompleto = NombreCompleto;
            this.NroCelular = NroCelular;
        }
    }
}
