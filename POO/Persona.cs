using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Persona
    {
        private string nombre;
        private int edad;
        private int dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dni { get => dni; set => dni = value; }

        public Persona()
        {   
        }
        public Persona(string nombre, int edad, int dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Dni = dni;
        }

        public void mostrar()
        {
            Console.WriteLine("Nombre: " + Nombre);

            Console.WriteLine("Edad: " + Edad);

            Console.WriteLine("Dni: " + Dni);
        }
        public bool esMayorDeEdad()
        {
            if (this.Edad >= 18)
            {
                return true;
            }
            else return false;
            
        }

        override public string ToString()
        {
            return String.Format("Nombre: " + Nombre);
        }
    }
}
