using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
       static Random random = new Random();
        static void Main(string[] args)
        {
            List<int> jugador = new List<int>();
            List<int> Ordenador = new List<int>();
            List<int> datos = new List<int>();
            bool validarO = false;
            bool validarJ = false;
            string res1="",res2="";
            Elegir(ref datos);

                Console.WriteLine("Jugador");
                Numeros(jugador);
                Console.WriteLine("Ordenador");
                Numeros(Ordenador);
            foreach (int item in datos)
            {
               
                if (validarO != true || validarJ != true)
                {
                    
                    Console.WriteLine("Numero: "+item);
                    Thread.Sleep(1000);
                    Console.WriteLine("jugador");
                    Marcar(ref jugador, item);
                    Console.WriteLine("ordenador");
                    Marcar(ref Ordenador, item);
                    Valida(jugador,ref validarJ);
                    Valida(Ordenador,ref validarO);
                }
                else
                {
                    break;
                }

                
            }
            Resultado(jugador, ref res1);
            Resultado(Ordenador,ref res2);
            if (res1=="00000" || res1 == "00000")
            {
                if (res1== "00000")
                {
                    Console.WriteLine("Jugador Gana");
                }else if(res2 == "00000")
                {
                    Console.WriteLine("Jugador Gana");
                }
            }else
            {
                Console.WriteLine("No hubo ganadores");
            }

            Console.ReadKey();
        }
        public static void Numeros(List<int> vs)
        {
            for (int i = 0; i < 5; i++)
            {
                vs.Add(random.Next(1, 50));

            }
           
            for (int j = 0; j < 5; j++)
            {

                Console.Write(vs[j] + " ");
            }
            Console.WriteLine();
        }
        private static List<int>Elegir( ref List<int> datos)
        {
            Random random = new Random();
            List<int> indices = new List<int>();
            int i = 0, j, indiceseleccionado;
            bool repetido;
            while (i < 10)
            {
                indiceseleccionado = random.Next(1, 50);
                repetido = false;
                j = 0;
                while (j < i && !repetido)
                {
                    if (indices[j] == indiceseleccionado)
                    {
                        repetido = true;
                    }
                    j++;
                }
                if (!repetido)
                {
                    indices.Add(indiceseleccionado) ;
                    datos.Add(indiceseleccionado);
                    i++;
                }
            }
            return datos;
        }
        public static void Marcar( ref List<int> vs,int item)
        {
            for (int i = 0; i < vs.Count; i++)
            {
                if (vs[i] == item)
                {
                    vs[i] = 0;
                }
            }

            for (int j = 0; j < 5; j++)
            {

                Console.Write(vs[j] + " ");
            }
            Console.WriteLine();
        }
        public static bool Valida(List<int> vs,ref bool v)
        {

            foreach (int item in vs)
            {
                if (item!=0)
                {
                    v = false;
                }else
                {
                    v=true;
                }
            }
            return v;
        }
        public static string Resultado(List<int> vs, ref string v)
        {
            foreach (int item in vs)
            {
                v += item.ToString();
            }
            return v;
        }
    }
}
