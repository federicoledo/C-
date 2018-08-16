using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string name;
        public string surname;
        public int dni;
        public int age;

        public Persona()
        {
            this.name = "No";
            this.surname = "Name";
            this.dni = 5555555;
            this.age = 0;
        }

        public Persona(string n, string s, int d, int a)
        {
            this.name = n;
            this.surname = s;
            this.dni = d;
            this.age = a;
        }

        public Persona createPersona(string n, string s, int d, int a)
        {
            this.name = n;
            this.surname = s;
            this.dni = d;
            this.age = a;
            return this;
        }
        public static List<Persona> createPersona(List<Persona> pp)
        {
            string xName, xSurname;
            int xAge, xDNI;
            Persona xPP = new Persona();
            pp.Add(xPP);
            Console.Write("Ingrese el nombre: ");
            xName = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            xSurname = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            int.TryParse(Console.ReadLine(), out xAge);
            Console.Write("Ingrese el DNI: ");
            int.TryParse(Console.ReadLine(), out xDNI);
            xPP.createPersona(xName, xSurname, xAge, xDNI);
            return pp;
        }

        public static List<Persona> deletePersona(List<Persona> pp)
        {
            int xvalue;
            int xCont = 0;
            Console.WriteLine("Ingrese el numero del que desea eliminar");
            foreach (Persona xPersona in pp)
            {
                Console.Write("{0}:", xCont + 1);
                Console.WriteLine("{0}, {1}", pp[xCont].surname, pp[xCont].name);
                xCont++;
            }
            int.TryParse(Console.ReadLine(), out xvalue);
            pp.Remove(pp[xvalue - 1]);
            return pp;
        }

        public static List<Persona> showPersona(List<Persona> pp)
        {
            int xCont = 0;
            foreach (Persona xPersona in pp)
            {
                Console.WriteLine("{0}:", xCont + 1);
                Console.WriteLine("Name: {0}", pp[xCont].name);
                Console.WriteLine("Surname: {0}", pp[xCont].surname);
                Console.WriteLine("Age: {0}", pp[xCont].age);
                Console.WriteLine("DNI: {0}", pp[xCont].dni);
                Console.WriteLine("-------------------------------------------------------");
                xCont++;
            }
            Console.ReadKey();
            return pp;
        }
    }
}
