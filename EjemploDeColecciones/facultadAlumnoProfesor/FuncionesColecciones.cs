using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facultadAlumnoProfesor
{
    class FuncionesColecciones
    {


        #region Colecciones No Generics

        public static void MostrarColeccionesNoGenerics()
        {
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*****Pilas No Genéricas*******");
            Console.WriteLine("******************************");
            Console.ReadLine();

            //DECLARO E INSTANCIO UNA COLECCION DE TIPO LIFO
            System.Collections.Stack pila = new System.Collections.Stack();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);

            Console.WriteLine("Agrego elementos a la pila...");
            Console.WriteLine("Utilizo pila.Push()");
            Console.WriteLine("Orden de los elementos: 1 - 2 - 3 - 4");
            Console.ReadLine();

            Console.WriteLine("Muestro el primer elemento de la pila...");
            Console.WriteLine("Utilizo pila.Peek()");
            Console.ReadLine();

            Console.WriteLine(pila.Peek());
            Console.ReadLine();

            Console.WriteLine("Muestro todos los elementos de la pila...");
            Console.WriteLine("Recorro con un foreach. No saco los elementos de la pila.");
            Console.ReadLine();

            foreach (int elemento in pila)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();

            Console.WriteLine("Desapilo todos los elementos de la pila...");
            Console.WriteLine("Utilizo pila.Pop(). Recorro con un for");
            Console.ReadLine();

            int cantidad = pila.Count;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Elemento {0} = {1}", i, pila.Pop());
            }

            Console.ReadLine();

            Console.WriteLine("Cantidad de elementos en la pila = {0}", pila.Count);
            Console.ReadLine();


            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("****Colas No Genéricas********");
            Console.WriteLine("******************************");
            Console.ReadLine();

            System.Collections.Queue cola = new System.Collections.Queue();

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(4);

            Console.WriteLine("Agrego elementos a la cola...");
            Console.WriteLine("Utilizo pila.Enqueue()");
            Console.WriteLine("Orden de los elementos: 1 - 2 - 3 - 4");
            Console.ReadLine();

            Console.WriteLine("Muestro el primer elemento de la cola...");
            Console.WriteLine("Utilizo cola.Peek()");
            Console.ReadLine();

            Console.WriteLine(cola.Peek());
            Console.ReadLine();

            Console.WriteLine("Muestro todos los elementos de la cola...");
            Console.WriteLine("Recorro con un foreach");
            Console.ReadLine();

            foreach (int elemento in cola)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();

            Console.WriteLine("Saco todos los elementos de la cola...");
            Console.WriteLine("Utilizo cola.Dequeue(). Recorro con un for");
            Console.ReadLine();

            cantidad = cola.Count;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Elemento {0} = {1}", i, cola.Dequeue());
            }

            Console.ReadLine();

            Console.WriteLine("Cantidad de elementos en la cola = {0}", cola.Count);
            Console.ReadLine();



            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******Listas Dinamicas********");
            Console.WriteLine("******************************");
            Console.ReadLine();

            System.Collections.ArrayList vec = new System.Collections.ArrayList();

            vec.Add(1);
            vec.Add(4);
            vec.Add(3);
            vec.Add(2);

            Console.WriteLine("Agrego elementos al ArrayList...");
            Console.WriteLine("Utilizo vec.Add()");
            Console.WriteLine("Orden de los elementos: 1 - 4 - 3 - 2");
            Console.ReadLine();

            Console.WriteLine("Muestro todos los elementos del ArrayList...");
            Console.WriteLine("Recorro con un foreach");
            Console.ReadLine();

            foreach (int elemento in vec)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();

            Console.WriteLine("Ordeno los elementos del ArrayList...");
            Console.WriteLine("Utilizo vec.Sort(). Recorro con un for");
            Console.ReadLine();

            vec.Sort();

            cantidad = vec.Count;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Elemento {0} = {1}", i, vec[i]);
            }

            Console.ReadLine();

            Console.WriteLine("Ordeno los elementos del ArrayList...");
            Console.WriteLine("Utilizo vec.Reverse(). Recorro con un for");
            Console.ReadLine();

            vec.Reverse();

            cantidad = vec.Count;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Elemento {0} = {1}", i, vec[i]);
            }

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*********HashTable************");
            Console.WriteLine("******************************");
            Console.ReadLine();

            System.Collections.Hashtable ht = new System.Collections.Hashtable();

            ht.Add(1, "valor 1");
            ht.Add(4, "valor 4");
            ht.Add(3, "valor 3");
            ht.Add(2, "valor 2");

            Console.WriteLine("Agrego elementos al HashTable...");
            Console.WriteLine("Utilizo vec.Add()");
            Console.WriteLine("Orden de los elementos: 1 - 4 - 3 - 2");
            Console.ReadLine();

            Console.WriteLine("Muestro todos los elementos del HashTable...");
            Console.WriteLine("Recorro con un for");
            Console.ReadLine();

            cantidad = ht.Count;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Elemento {0} = {1}", i, ht[i]);
            }

            Console.ReadLine();

        }

        #endregion




        #region Colecciones Generics

        public static void MostrarColeccionesGenerics()
        {
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("**********Generis*************");
            Console.WriteLine("******************************");
            Console.ReadLine();


            Console.WriteLine("******************************");
            Console.WriteLine("*********Dictionary***********");
            Console.WriteLine("******************************");
            Console.ReadLine();

            //DECLARO UNA COLECCION GENERICA DE TIPO CLAVE-VALOR
            Dictionary<int, Persona> diccionario = new Dictionary<int, Persona>();

            Console.WriteLine("Creo mi diccionario con los tipos...");
            Console.WriteLine("Dictionary<int, Persona> diccionario");

            Console.ReadLine();
            Console.Clear();

            //DECLARO E INSTANCIO UNA PERSONA
            Persona personita = new Persona("Roberto",22);

            diccionario.Add(1, new Persona("Juan", 88));
            diccionario.Add(2, personita);
            diccionario.Add(3, new Persona("Rosa",44));
            diccionario.Add(4, new Persona("Elvira",22));

            Console.WriteLine("Agrego con diccionario.Add()");
            Console.WriteLine("Recorro la colección con un for.");
            Console.ReadLine();

            Console.WriteLine("Cantidad de elementos en la colección {0}.",
                                diccionario.Count);

            Console.ReadLine();

            for (int i = 1; i <= diccionario.Count; i++)
            {
                diccionario[i].MostrarPersona();
            }


            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******Listas Genéricas********");
            Console.WriteLine("******************************");
            Console.ReadLine();

            //DECLARO E INSTANCIO UNA LISTA GENERICA DE PERSONA
            List<Persona> lista = new List<Persona>();

            Console.WriteLine("Creo mi lista de tipo...");
            Console.WriteLine("List<Persona> lista ");

            Console.ReadLine();
            Console.Clear();

            lista.Add(new Persona("Juan",88));
            lista.Add(personita);
            lista.Add(new Persona("Rosa",44));

            Console.WriteLine("Agrego con lista.Add()");
            Console.WriteLine("Recorro la colección con un for each.");
            Console.ReadLine();

            Console.WriteLine("Cantidad de elementos en la colección {0}.",
                                lista.Count);

            Console.ReadLine();

            foreach (Persona elemento in lista)
            {
                elemento.MostrarPersona();
            }


            Console.ReadLine();

        }
        #endregion
    }
}
