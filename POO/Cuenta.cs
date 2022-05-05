using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Cuenta
    {
        private Persona titular;
        private double cantidad = 0;

        internal Persona Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public Cuenta(Persona titular, double cantidad)
        {
            this.Titular = titular;
            this.Cantidad = cantidad;
        }
        public Cuenta()
        {

        }

        public void mostrar()
        {
            titular.mostrar();
            Console.WriteLine("Cantidad: " + cantidad);
        }

        public void ingresar(double ingreso)
        {
            if(ingreso > 0)
            {
                cantidad = cantidad + ingreso;
            } 
        }
        public void retirar(double retiro)
        {
            if(cantidad - retiro > -100001) cantidad = cantidad - retiro;
            if (cantidad < 0) Console.WriteLine("La cuenta esta en numeros rojos");
        }
    }
}
