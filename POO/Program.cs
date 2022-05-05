using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ej1
            Persona persona1 = cargarPersona();
            persona1.ToString();
            persona1.ToString();
            persona1.ToString();

            //Ej2
            persona1.Dni = 5000000;
            persona1.Edad = 20;
            Persona persona2 = new Persona("Juan", 17, 50054502);
            Persona persona3 = new Persona("Carlitos", 20, 45345426);
            persona1.mostrar();
            persona2.mostrar();
            persona3.mostrar();

            Console.WriteLine("Es " + persona2.Nombre + " mayor de edad: " + persona2.esMayorDeEdad());
            Console.WriteLine("Es " + persona3.Nombre + " mayor de edad: " + persona3.esMayorDeEdad());
            Console.ReadKey();

            CuentaJoven joven = new CuentaJoven(5);

        }


        //Ej1
        static Persona cargarPersona()
        {
            Persona p = new Persona();
            Console.WriteLine("Nombre de la persona: ");
            p.Nombre = Console.ReadLine();

            return p;
        }
    }
}
