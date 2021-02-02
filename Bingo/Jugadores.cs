using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Jugadores
    {
      public  List<int> jugador { get; set; }
      public  List<int> Ordenador { get; set; }
    public Jugadores()
        {
            jugador = new List<int>();
            Ordenador = new List<int>();
        }

    }
}
