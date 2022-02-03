using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDL_Guia2_Ejercicio1_2_3
{
    class lista
    {
        public nodo inicio; //Cabeza de la lista

        //Constructor por defecto
        public lista()
        { inicio = null; }

        //Método para insertar al fianl de la lista, como lo hace ArrayList
        public void InsertarF(int item)
        {
            nodo aux = new nodo(); //Nodo temporal que todavía no pertence a la lista
            aux.dato = item; //Almacena en el atributo dato el valor recibido en el parámetro
            aux.siguiente = null; //Hace que el apuntado señale a null

            if (inicio == null) //Verifica si la lista está vacia
            {
                inicio = aux; //Hacemos que nodo sea parte de la lista, lo hacemos la cabeza
            }
            else
            {
                nodo puntero; //Utilizamos este nodo para recorrer la lista, así no se mueve la cabeza
                puntero = inicio; //Situamos a puntero señalando al mismo nodo que inicio
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //Se desplaza por todos los nodos de la lista
                }
                puntero.siguiente = aux; //Hacemos que el ultimo nodo ahora señale al auxiliar
            }
        }

        //Metodo insertar al incio (insertar en la cabeza)
        public void InsertarI(int item)
        {
            nodo aux = new nodo(); //Nodo temporal que despues se agrega a la lista

            aux.dato = item; //Almacena valor en el atributo dato
            aux.siguiente = null; //Hacemos que puntero siguiente señale a null

            if (inicio == null)
            {
                inicio = aux; //Al estar vacia la cola lo hacemos la cabeza
            }
            else
            {
                nodo puntero; //Para recorrer la lista;
                puntero = inicio; //Dos apuntadores señalando al mismo nodo
                inicio = aux; //Asignamos como cabeza al nodo auxiliar
                aux.siguiente = puntero;
                /*El puntero de aux que ahora es cabeza se enlaza con el nodo que era antes la baeza
                y que tiene apuntador "puntero"*/
            }
        }

        //Metodo para eliminar nodo que está a la cabeza de la lista
        public void EliminarI()
        {
            if (inicio == null) //Cuando la lista está vacía 
            { Console.WriteLine("Lista vacía, no se puede eliminar elemneto"); }

            else
            { inicio = inicio.siguiente; /*A quien estab señalando "inicio" será nuevo "inicio"*/ }
        }

        //Metodo para eliminar nodo al final de la lista
        public void EliminarF()
        {
            if (inicio == null) //Cuando la lista está vacía
            {
                Console.WriteLine("Lista vacía, no se puede eliminar elemento");
            }
            else
            {
                nodo punteroant, punteropos; //Requiero dos puntero para mover porque no declaré la cola
                punteroant = inicio; //Inicializa ambos en la cabeza de la lista
                punteropos = inicio;

                while (punteropos.siguiente != null) //Mientras punteros posterior no señale a null
                {
                    punteroant = punteropos; //Mientras puntero posterior no señale a null
                    punteropos = punteropos.siguiente; //Puntero post será a quien señalaba antes el posterior
                }
                punteroant.siguiente = null;
               /* Con esto sacamos el que estab al final de la lista, el ultimo nodo era el que 
                  estaba señalando el punteropos pero ahora el ultimo será en donde se quedó "punteroant"
               */
            }
        }

        //Metodo para insertar en una posición especifica de la lista
        public void InsertarP(int item, int pos)
        {
            nodo aux = new nodo(); //Definimoc de nuevo nodo con sus atributos
            aux.dato = item;
            aux.siguiente = null;

            if (inicio == null) //Si la lista está vacía 
            {
                Console.WriteLine("La lista está vacía, por lo tanto se va a insertar en al 1a posicion");
                inicio = aux; //Inserto el nodo;
            }
            else
            {
                nodo puntero;
                puntero = inicio; //Para recorrer la lista

                if (pos == 1) //Si la posicion que pidieron es la 1 sen inserta en la cabeza
                {
                    inicio = aux;
                    aux.siguiente = puntero;
                }
                else //Si la posición solicitada no es la 1
                {
                    for (int i = 1; i < pos; i++)
                    {
                        puntero = puntero.siguiente;

                        if (puntero.siguiente == null) //Si llegamos al final de la lista
                        {
                            break;
                        }

                        nodo punteronext; //Apuntador de ayuda
                        punteronext = puntero.siguiente; //A quien señalaba el puntor, ahí se ubicará el aux
                        puntero.siguiente = aux; //Ahora el apuntado "puntero2 señalará a el nodo aux (El nuevo)
                        aux.siguiente = punteronext; //El nodo recien ingresado señalará a "punteronext" 
                        
                        //Con estas cuatro líneas anteriores es como se corta momentaneamente la lista
                        //Y luego se une de nuevo
                    }
                }
            }
        }

        //Metodo que muestra el contenido de la lista
        public void mostrar()
        {
            if (inicio == null) //Si la lista está vacía 
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                nodo puntero;
                puntero = inicio; //Inicializamos a puntero en el mismo nodo que la cabeza;
                Console.Write("{0} -> \t", puntero.dato); //Imprimir valor de nodo. Write y no WriteLine
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //avanzamos un nodo en la lista
                    Console.Write("{0} -> \t", puntero.dato); //Usar Write para que no salte de linea
                }
            }
            Console.WriteLine();
        }
    }
    //Fin de la clase lista
}
