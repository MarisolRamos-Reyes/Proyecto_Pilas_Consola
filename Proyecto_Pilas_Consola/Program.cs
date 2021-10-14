using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pilas_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Libros");
            Console.WriteLine("Push - Agregar");
            int numero = 1;
            string nombre = "Algebra";
            string fecha = DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss");

            MiPilaConsola MP = new MiPilaConsola();
            NodoPilaConsola nuevo = new NodoPilaConsola(numero, nombre + " " + fecha);

            MP.Push(nuevo);
            Console.WriteLine(MP.ToString());

            nuevo = new NodoPilaConsola(7, "Español  " + fecha);
            MP.Push(nuevo);
            Console.WriteLine(MP.ToString());
            Console.WriteLine("Pop - Eliminar");
            MP.Pop();
            Console.WriteLine(MP.ToString());

            MP.Guardar("ArchivoPilaConsola");

            Console.WriteLine("Cargar");
            MP.Cargar("ArchivoPilaConsola");
            Console.WriteLine(MP.ToString());
            Console.ReadKey();
        }
    }
}
