using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_Pilas_Consola
{
    class MiPilaConsola
    {
        public NodoPilaConsola _tope;
        public NodoPilaConsola Tope
        {
            get { return _tope; }
            set { _tope = value; }
        }
        public MiPilaConsola()
        {
            _tope = null;
        }
        public void Push(NodoPilaConsola unNodo)
        {
            if (_tope == null)
            {
                _tope = unNodo;
                return;
            }
            unNodo.siguiente = _tope;
            _tope = unNodo;
        }
        public void Pop()
        {
            if (_tope != null)
            {
                _tope = _tope.Siguiente;
            }
        }
        public void Guardar(string nombreArchivo)
        {

            NodoPilaConsola t =_tope ;

            if (_tope == null)
            {
                return;
            }
            nombreArchivo = "ArchivoPilaConsola";
            string path = @"c:\Pilas\" + nombreArchivo + ".txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                do
                {
                    sw.WriteLine(t.Numero + "-" + t.Nombre);
                    t = t.siguiente;
                } while (t != null);
                return;
            }
        }
        public void Cargar(string nombreArchivo)
        {
            nombreArchivo = "ArchivoPilaConsola";
            string buscar = @"C:\Pilas\ArchivoPilaConsola.txt";
            if (File.Exists(buscar))
            {
                string[] lineas = File.ReadAllLines(@"C:\Pilas\" + nombreArchivo + ".txt");
                foreach (var linea in lineas)
                {
                    if (linea.Length == 0)
                    {
                        continue;
                    }
                    string[] datos = linea.Split('-');
                    int numero = int.Parse(datos[0]);
                    string nombre = datos[1];
                    NodoPilaConsola n = new NodoPilaConsola(numero, nombre);
                    Push(n);
                }
            }
            else
            {
                return;
            }
        }
        public override string ToString()
        {
            string lista = "" +
                " Nodo: ";
            NodoPilaConsola t = _tope;
            if(_tope==null)
            {
                return lista;
            }
            if (_tope!= null)
            {
                lista += t.Numero + " - " + t.Nombre + "\n ";
                
            }
            return lista;
        }
    }
}
