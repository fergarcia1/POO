using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class CuentaJoven : Cuenta
    {
        private int bonificacion;

        public CuentaJoven(int bonificacion)
        {
            this.Bonificacion = bonificacion;
        }

        public int Bonificacion { get => bonificacion; set => bonificacion = value; }

        public bool esTitularValido()
        {
            if (this.Titular.Edad >= 18 && this.Titular.Edad <= 25)
                return true;
            else return false;
        }
        public void retirarJoven(double retiro)
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
        public override void mostrar()
        {
            Console.WriteLine("*****Cuenta Joven*****");
            Titular.mostrar();
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Bonificacion: " + Bonificacion);
        }
    }
}
