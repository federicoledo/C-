using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ABM_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            int xReturn;
            List<Persona> pp = new List<Persona>();

            do
            {
                Console.Clear();
                Console.WriteLine("Que operacion desea realizar?\n1.Crear Persona\n2.Borrar Persona\n3.Mostrar Personas\n\n\nEn caso de querer salir, presione any key");
                int.TryParse(Console.ReadLine(), out xReturn);
                xReturn = Program.Response(xReturn, pp);
                Console.WriteLine("\n\nPresione una tecla para continuar...");
            }while (xReturn == 1 || xReturn == 2 || xReturn == 3);
        }

        public static int Response(int key, List<Persona> pp)
        {
            int strResult = 0;
            switch (key)
            {
                case 1:
                    strResult = 1;
                    Entidades.Persona.createPersona(pp);
                    break;
                case 2:
                    strResult = 2;
                    Entidades.Persona.deletePersona(pp);
                    break;
                case 3:
                    strResult = 3;
                    Entidades.Persona.showPersona(pp);
                    break;
                default:
                    Console.WriteLine("Gracias!");
                    strResult = 0;
                    break;
            }
            return strResult;
        }
    }
}
