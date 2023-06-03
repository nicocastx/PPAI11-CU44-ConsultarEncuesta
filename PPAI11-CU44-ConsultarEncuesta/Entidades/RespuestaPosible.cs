namespace PPAI11_CU44_ConsultarEncuesta.Entidades
{
    public class RespuestaPosible
    {
        public string descripcion { get; set; }
        public int valor { get; set; }

        public RespuestaPosible(string descripcion, int valor)
        {
            this.valor = valor;
            this.descripcion = descripcion;
        }

        public string getDescripcionRta()
        {
            return this.descripcion;
        }
    }
}
