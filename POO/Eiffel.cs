using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Eiffel
    {
        public List<int> lista = new List<int>();
        private bool flag = true;

        public void insercion(int dato)
        {
            if(flag == true)
            {
                lista.Insert(0,dato);
                this.flag = false;
            }
            else
            {
                lista.Add(dato);
                this.flag = true;
            }
        }
        public int elemento(int dato)
        {
            return lista.ElementAt<int>(dato);
        }

        public int elementos()
        {
         
            return lista.Count;
                
        }

        public void poda()
        {
            lista.RemoveAt(0);
        }
        public void mostrar()
        {
            lista.ForEach(Console.WriteLine);
        }


    }
}
