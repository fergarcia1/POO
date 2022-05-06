using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Cuenta
    {
        private double cantidad;
        private Persona titular;

        public double Cantidad { get => cantidad; set => cantidad = value; }
        internal Persona Titular { get => titular; set => titular = value; }

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
            Console.WriteLine("*****Cuenta*****");
            Titular.mostrar();
            Console.WriteLine("Cantidad: " + Cantidad);
        }

        public void ingresar(double ingreso)
        {
            if(ingreso > 0)
            {
                Cantidad = Cantidad + ingreso;
            } 
        }
        public void retirar(double retiro)
        {
            if(Cantidad - retiro > -100001) Cantidad = Cantidad - retiro;
            if (Cantidad < 0) Console.WriteLine("La cuenta esta en numeros rojos");
        }
    }
}
