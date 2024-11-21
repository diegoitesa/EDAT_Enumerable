using Enumerable.UI.Consola;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("\t   Enumerable");
        Console.WriteLine("==================================");
        Console.WriteLine("\n");
        Console.WriteLine("\tLista     list<T>");
        #region Lista

        var lista = new List<Alumnos>
        {
            
            new Alumnos {Matricula = 1, Nombre = "Juan", Precio = 24.45M},
            new Alumnos {Matricula = 2, Nombre = "José", Precio = 22.30M},
            new Alumnos {Matricula = 3, Nombre = "Luis", Precio = 19.60M},
            new Alumnos {Matricula = 4, Nombre = "Ileny", Precio = 25.50M},
            new Alumnos {Matricula = 5, Nombre = "Karla", Precio = 24.50M},
            new Alumnos {Matricula = 6, Nombre = "Casco", Precio = 24.70M},
            new Alumnos {Matricula = 7, Nombre = "Mitzi", Precio = 23.80M},
            new Alumnos {Matricula = 8, Nombre = "Isabel", Precio = 27.90M},
            new Alumnos {Matricula = 9, Nombre = "Zuri", Precio = 19.10M},
            
            //"Juan",
            //"José",
            //"Luis",
            //"Ileny",
            //"Karla",
            //"Casco",
            //"Mitzi",
            //"Isabel",
            //"Zuri"
        };

        //foreach(string nombre in lista)
        //  Console.WriteLine($"\t{nombre}");

        lista = lista.OrderBy(x => x.Precio).ToList();

        for(int i = 0; i < lista.Count; i++) 
            Console.WriteLine($"\t{lista[i]}");

        #endregion





        Console.ReadKey();

    }
}