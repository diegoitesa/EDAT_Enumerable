namespace Enumerable.UI.Consola
{
    public class Alumnos
    {

        public int Matricula { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{Matricula,2}\t{Nombre,20}\t{Precio:C2}";
        }

    }
}
