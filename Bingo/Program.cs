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

        static void Main(string[] args)
        {
            Jugadores jugadores = new Jugadores();
            Datos dt= new Datos();
            Procedimientos pc = new Procedimientos();
            bool validarO = false;
            bool validarJ = false;
            string res1="",res2="";
           pc.Elegir(dt.datos);

            Console.WriteLine("Jugador");
            pc.Numeros(jugadores.jugador);
            Console.WriteLine("Ordenador");
            pc.Numeros(jugadores.Ordenador);
            foreach (int item in dt.datos)
            {
               
                if (validarO != true || validarJ != true)
                {
                    
                    Console.WriteLine("Numero: "+item);
                    Thread.Sleep(1000);
                    Console.WriteLine("jugador");
                    pc.Marcar( jugadores.jugador, item);
                    Console.WriteLine("ordenador");
                    pc.Marcar( jugadores.Ordenador, item);
                    pc.Valida(jugadores.jugador,ref validarJ);
                    pc.Valida(jugadores.Ordenador,ref validarO);
                }
                else
                {
                    break;
                }

                
            }
            pc.Resultado(jugadores.jugador, ref res1);
            pc.Resultado(jugadores.Ordenador,ref res2);
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
       
    }
}
