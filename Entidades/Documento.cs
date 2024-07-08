using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Documento
    {
        public string Contenido {  get; set; }

        public Documento(string contenido)
        {
            Contenido = contenido;
        }

        public Memento SaveText()
        {

            return new Memento(Contenido);
        }

        public void RestaurarTexto(Memento memento)
        {
            Contenido = memento.Contenido;
        }

        public void AddTexto(string text)
        {
            Contenido += text;
        }

        public void EliminarTexto(int n)
        {
            if(n > Contenido.Length)
            {
                Contenido = string.Empty;
            }
            else
            {
                Contenido = Contenido.Substring(0, Contenido.Length - n);
            }
        }

        public void ReemplazarTexto(string text)
        {
            Contenido = text;
        }

    }
}
