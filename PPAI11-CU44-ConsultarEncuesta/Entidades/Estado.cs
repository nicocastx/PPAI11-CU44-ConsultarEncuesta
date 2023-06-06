namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class Estado
    {
        public string nombre { get; set; }

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        //verifica si el nombre es iniciada, devuelve un bool
        public bool esIniciada()
        {
            if (this.nombre == "Inicializada")
            {
                return true;
            }
            return false;
        }

        //verifica si el nombre es finalizada, devuelve un bool
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
