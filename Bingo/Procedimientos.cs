using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Procedimientos
    {
        Random random = new Random();
        public Procedimientos()
        {

        }
        Datos datos1 = new Datos();
        internal List<int> Elegir(List<int> datos)
        {
           
            
            int i = 0, j, indiceseleccionado;
            bool repetido;
            while (i < 10)
            {
                indiceseleccionado = random.Next(1, 50);
                repetido = false;
                j = 0;
                while (j < i && !repetido)
                {
                    if (datos1.indices[j] == indiceseleccionado)
                    {
                        repetido = true;
                    }
                    j++;
                }
                if (!repetido)
                {
                    datos1.Agregar(indiceseleccionado);
                    datos.Add(indiceseleccionado);
                    i++;
                }
            }
            return datos;
        }
        internal void Numeros(List<int> vs)
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

        internal void Marcar(List<int> vs, int item)
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
        internal bool Valida(List<int> vs, ref bool v)
        {

            foreach (int item in vs)
            {
                if (item != 0)
                {
                    v = false;
                }
                else
                {
                    v = true;
                }
            }
            return v;
        }
        internal string Resultado(List<int> vs, ref string v)
        {
            foreach (int item in vs)
            {
                v += item.ToString();
            }
            return v;
        }
    }
}
    
