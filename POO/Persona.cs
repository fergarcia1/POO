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

        public Persona()
        {   
        }
        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dni { get => dni; set => dni = value; }

        public void mostrar()
        {
            Console.WriteLine("Nombre: " + nombre);

            Console.WriteLine("Edad: " + edad);

            Console.WriteLine("Dni: " + dni);
        }
        public bool esMayorDeEdad()
        {
            if (this.edad >= 18)
            {
                return true;
            }
            else return false;
            
        }

        public override string ToString()
        {
            return "Nombre: " + nombre;
        }
    }
}
