using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Grafo
    {
        //PREVIAS
        public int[,] matriz;
        public Vertice primer_Vertice_Lista = null;

        public Grafo(int n)
        {
            matriz = new int[n, n];
            char caracter = 'A';
            for (int i = 1; i <= n; i++)
            {
                insertar(caracter);
                caracter++;
            }
        }
        //METODOS PARA LISTA
        public void insertar(char elemento)
        {
            //1. CREAR EL Vertice
            Vertice nuevo = new Vertice();
            nuevo.caja = elemento;
            //2. ENLAZAR
            if (primer_Vertice_Lista == null)
            {
                primer_Vertice_Lista = nuevo;
            }
            else
            {
                Vertice temporal = primer_Vertice_Lista;
                while (temporal.sig != null)
                {
                    temporal = temporal.sig;
                }
                temporal.sig = nuevo;
            }
        }
        //mostrar
        //public void mostrarVertices()
        //{
        //    Vertice temporal = primer_Vertice_Lista;
        //    while (temporal != null)
        //    {
        //        Console.Write("    " + temporal.caja);
        //        temporal = temporal.sig;
        //    }
        //    Console.WriteLine();
        //}
        //METODO PARA matrizTRIZ
        //llenar matriztiz
        public void llenarmatriz()
        {
            //i= filas
            //j= colm
            Vertice vertice_origen = primer_Vertice_Lista;//A
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Vertice vertice_destino = primer_Vertice_Lista;//A
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //[i,j]
                    //Solo tener todos los caminos conectados de ida, ninguno se cruza
                    matriz[0, 1] = 1;
                    matriz[1, 2] = 1;
                    matriz[2, 3] = 1;
                    matriz[3, 4] = 1;
                    matriz[4, 5] = 1;
                    //el resto deberá ser ceros para evitar las conexiones innecesarias
                    Console.Write("matriz [" + (vertice_origen.caja) + "-" + (vertice_destino.caja) + "]: ");
                    int val = int.Parse(Console.ReadLine());//1
                    matriz[i, j] = val;
                    vertice_destino = vertice_destino.sig;
                }
                vertice_origen = vertice_origen.sig;
            }
        }
        //mostrarlo
        //public void mostrarmatriz()
        //{
        //    mostrarVertices();
        //    Vertice vertice_origen = primer_Vertice_Lista;
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        Console.Write(vertice_origen.caja + "   ");
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            Console.Write(matriz[i, j] + "    ");
        //        }
        //        Console.WriteLine();
        //        vertice_origen = vertice_origen.sig;
        //    }
        //}
        //METODO PARA GRAFOS
        //crear grafo
        public void crearGrafo()
        {

            Vertice vertice_origen = primer_Vertice_Lista;//A
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Vertice vertice_destino = primer_Vertice_Lista;//A
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //interseccion de origen con el destino = 1 (arista)
                    if (matriz[i, j] == 1)
                    {
                        Arista nuevo = new Arista();
                        nuevo.destino = vertice_destino;//C
                        Console.Write("ingrese el costo para ir desde {0} hasta {1}: ", vertice_origen.caja, vertice_destino.caja);
                        nuevo.costo = int.Parse(Console.ReadLine());//20
                        if (vertice_origen.lista_Aristas == null)
                        {
                            vertice_origen.lista_Aristas = nuevo;
                        }
                        else
                        {
                            Arista temp = vertice_origen.lista_Aristas;
                            while (temp.sig_Arista != null)
                            {
                                temp = temp.sig_Arista;
                            }
                            temp.sig_Arista = nuevo;
                        }
                    }
                    vertice_destino = vertice_destino.sig;
                }
                vertice_origen = vertice_origen.sig;
            }
        }
        public void mostrarArista(Vertice v)
        {
            Arista temp = v.lista_Aristas;
            int cont = 1;//2
            while (temp != null)
            {
                Console.WriteLine(cont + ". ->[" + temp.destino.caja + "/" + temp.costo + "]");
                cont++;
                temp = temp.sig_Arista;
            }
        }
        public void RecorrerGrafo(Vertice v)
        {
            Console.Clear();
            Console.WriteLine("VERTICE ACTUAL: " + v.caja);
            Console.WriteLine("vertices adyacentes: ");
            mostrarArista(v);
            Console.WriteLine("0. salir");
            int op;
            Console.Write("ingrese una opcion");
            op = int.Parse(Console.ReadLine());

            Arista temp = v.lista_Aristas;
            for (int i = 1; i < op; i++)
            {
                temp = temp.sig_Arista;
            }
            if (op == 0)
            {
                Console.WriteLine("saliendo..");
            }
            else
            {
                RecorrerGrafo(temp.destino);
            }
            Console.ReadKey();

        }
    }
}
