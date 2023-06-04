﻿namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Estado
    {
        public string nombre { get; set; }

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        public bool esIniciada()
        {
            if (this.nombre == "Inicializada")
            {
                return true;
            }
            return false;
        }

        public bool esFinalizada()
        {
            if (this.nombre == "Finalizada")
            {
                return true;
            }
            return false;
        }
    }
}
