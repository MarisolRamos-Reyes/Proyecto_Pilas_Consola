using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pilas_Consola
{
    class NodoPilaConsola
    {
        public int numero;
        public string nombre;
        public NodoPilaConsola siguiente;

        public NodoPilaConsola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public NodoPilaConsola()
        {
            numero = 0;
            nombre = "";
            siguiente = null;
        }
        public NodoPilaConsola(int num, string nomb)
        {
            numero = num;
            nombre = nomb;
            siguiente = null;
        }
        public override string ToString()
        {
            return numero+" - "+nombre;
        }
    }
}
