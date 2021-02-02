using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Datos
    {
        public List<int> datos { get;set; }
        public List<int> indices { get; set; }
        public Datos()
        {
            indices = new List<int>();
            datos = new List<int>();
        }
        public void Agregar(int dt)
        {
            
            indices.Add(dt);
        }
    }
}
