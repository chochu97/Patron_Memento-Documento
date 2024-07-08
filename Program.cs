using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MementoDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento doc = new Documento("Hello");
            CareTaker careTaker1 = new CareTaker(doc);
            careTaker1.SaveState(); 

            int resp = 1;
            do
            {
                Console.WriteLine("Contenido Actual del Documento: " + doc.Contenido);
                Console.WriteLine("Que desea hacer? Agregar texto (agregar)/ Eliminar caracteres (eliminar)/ Reemplazar el contenido (reemplazar)/ Restaurar al contenido anterior (rehacer)");
                var ans = Console.ReadLine();
                careTaker1.Action(ans);
                Console.WriteLine("Contenido Actual del Documento: " + doc.Contenido);
                Console.WriteLine("Desea seguir modificando sobre el documento?");
                var asn2 = Console.ReadLine();

                if(asn2 == "no")
                {
                    resp = 2;
                }

            } while (resp == 1);
        }
    }
}
