using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();
        private Documento doc;

        public CareTaker(Documento doc)
        {
            this.doc = doc;
        }   

        public void SaveState()
        {
            mementos.Add(doc.SaveText());
        }

        private void RestoreState()
        {
            if(mementos.Count > 0)
            {
                var index = mementos.Count - 2;
                Memento memento = mementos[index];
                mementos.Remove(mementos[mementos.Count - 1]);
                doc.RestaurarTexto(memento);
            }
        }

        public void Action(string action)
        {
            switch (action)
            {
                case "agregar":
                    Console.WriteLine("Ingrese el texto que desea agregar al contenido del documento");
                    var read = Console.ReadLine();  
                    doc.AddTexto(read);
                    SaveState();
                    break;
                case "eliminar":
                    Console.WriteLine("Ingrese la cantidad de caracteres que desea eliminar del contenido");
                    var cant = Console.ReadLine();
                    doc.EliminarTexto(Convert.ToInt32(cant));
                    SaveState();
                    break;
                case "reemplazar":
                    Console.WriteLine("Ingrese el texto para reemplazar el contenido del documento");
                    var text = Console.ReadLine();
                    doc.ReemplazarTexto(text);
                    SaveState();
                    break;
                case "rehacer":
                    RestoreState();
                    break;
            }
                
        }
    }
}
