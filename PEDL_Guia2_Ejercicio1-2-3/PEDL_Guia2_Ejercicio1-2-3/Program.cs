using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDL_Guia2_Ejercicio1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creamos un instancia de la clase lista para que podamos utiliza los metodos
            lista newlist = new lista();

            //Le agregamos cuatro nodos a la lista
            newlist.InsertarI(40);
            newlist.InsertarI(30);
            newlist.InsertarI(20);
            newlist.InsertarI(10);

            //Mostramos que hay dentro de la lista
            newlist.mostrar();

            //Insertando en posicion
            newlist.InsertarP(220, 3);
            newlist.mostrar();

            Console.ReadKey();

        }
    }
}
