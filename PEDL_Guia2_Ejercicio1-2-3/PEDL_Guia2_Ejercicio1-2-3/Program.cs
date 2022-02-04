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

            ConsoleKeyInfo op; //Variable que capta cuando se presiona una tecla en especifico
            do
            {


                //Creamos el menú

                Console.Title = "Ejercicios 1, 2 y 3";

                Console.WriteLine(" ");
                Console.WriteLine("\t-------------------------------------------------");
                Console.WriteLine("\t--------------------- Menú ----------------------");
                Console.WriteLine("\t-                                               -");
                Console.WriteLine("\t-         Seleccione la opción que desee        -");
                Console.WriteLine("\t-                                               -");
                Console.WriteLine("\t-     [A] Inserta al frente                     -");
                Console.WriteLine("\t-     [B] Inserta al final                      -");
                Console.WriteLine("\t-     [C] Inserta en un posición especifica     -");
                Console.WriteLine("\t-     [D] Eliminar al frente                    -");
                Console.WriteLine("\t-     [E] Eliminar al final                     -");
                Console.WriteLine("\t-     [F] Mostrar lista                         -");
                Console.WriteLine("\t-     [G] Salir del programa                    -");
                Console.WriteLine("\t-                                               -");
                Console.WriteLine("\t-------------------------------------------------");
                Console.WriteLine("\t-------------------------------------------------");
                Console.WriteLine(" ");

                //Creamos una variable de tipo ConsoleKeyInfo
                op = Console.ReadKey(true); //No mostrará la tecla seleccionada
                int newdata;
                int pos;

                switch (op.Key)
                {
                    case ConsoleKey.A: //En caso que quiera insertar al frente


                        Console.WriteLine("\tInsertar al frente");
                        Console.WriteLine("");
                        Console.WriteLine("\tColoque el numero que quiera añadir a la lista: ");
                        Console.Write("\t");
                        newdata = int.Parse(Console.ReadLine());
                        newlist.InsertarI(newdata);
                        Console.WriteLine("\tAcción realizada con éxito");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.B://En caso que quiera insertar al final


                        Console.WriteLine("\tInsertar al frente");
                        Console.WriteLine("");
                        Console.WriteLine("\tColoque el numero que quiera añadir a la lista: ");
                        Console.Write("\t");
                        newdata = int.Parse(Console.ReadLine());
                        newlist.InsertarF(newdata);
                        Console.WriteLine("\tAcción realizada con éxito");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.C: //Caso donde quiere insertar en una posición especifica

                        Console.WriteLine("\tInsertar en una posición especifica");
                        Console.WriteLine("");
                        Console.WriteLine("\tColoque el numero que quiera añadir a la lista: ");
                        Console.Write("\t");
                        newdata = int.Parse(Console.ReadLine());
                        Console.WriteLine("\tColoque la posición donde quiera que se añada a la lista: ");
                        Console.Write("\t");
                        pos = int.Parse(Console.ReadLine());
                        newlist.InsertarP(newdata, pos);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.D: //Caso eliminar al frente

                        
                        Console.WriteLine("\tEliminar al frente");
                        Console.WriteLine("");
                        newlist.EliminarI();
                        Console.WriteLine("\tSe ha eliminado el primer numero de la lista");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.E: //Caso donde eliminamos la primero posición

                        Console.WriteLine("\tEliminar al final");
                        Console.WriteLine("");
                        newlist.EliminarF();
                        Console.WriteLine("\tSe ha eliminado el último numero de la lista");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case ConsoleKey.F: //Caso donde mostramos la lista

                        Console.WriteLine("\tMostrando lista... ");
                        Console.WriteLine("");
                        Console.Write("\t");
                        newlist.mostrar();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:

                        Console.WriteLine("\tEjila una opción correcta ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


            } while (op.Key != ConsoleKey.G);
            {
                
            }
            

        }
    }
}
