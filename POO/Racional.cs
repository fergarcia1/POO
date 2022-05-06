using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Racional
    {
        public float valor1 { get => valor1; set => valor1 = value; }
        public float valor2 { get => valor2; set => valor2 = value; }
        public float respuesta { get => valor2; set => valor2 = value; }

        public Racional(float valor1, float valor2, float respuesta)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.respuesta = respuesta;
        }

        public float suma()
        {
            return valor1 + valor2;
        }

        public float resta()
        {
            return valor1 - valor2;
        }

        public float opuesto()
        {
            respuesta = valor1 + valor2;
            respuesta = respuesta - (respuesta * 2);
            return respuesta;
        } 



    }
}
