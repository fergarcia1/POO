using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class CuentaJoven : Cuenta
    {
        public static int bonificacion = 10;

        public CuentaJoven(Persona titular, double cantidad)
        {
            this.Cantidad = cantidad;
            this.Titular = titular;
        }


        public bool esTitularValido()
        {
            if (this.Titular.Edad >= 18 && this.Titular.Edad < 25)
                return true;
            else return false;
        }
        public new void retirar(double retiro)
        {
            if(esTitularValido() == true)
            {
                if (this.Cantidad - retiro > -100001) Cantidad = Cantidad - retiro;
                if (this.Cantidad < 0) Console.WriteLine("La cuenta esta en numeros rojos");
            }
            else
            {
                Console.WriteLine("El titular no es valido");
            }
        }
        public new void mostrar()
        {
            Console.WriteLine("*****Cuenta Joven*****");
            Titular.mostrar();
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Bonificacion: " + bonificacion);
        }
    }
}
