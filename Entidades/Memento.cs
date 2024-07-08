using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Memento
    {
        public string Contenido { get; }

        public Memento(string contenido)
        {
            Contenido = contenido;  
        }
    }
}
