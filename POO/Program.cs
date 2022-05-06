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
            int opt = 0;
            Console.WriteLine("(1) Ejercicio 1");
            Console.WriteLine("(2) Ejercicio 2");
            Console.WriteLine("(3) Ejercicio 3");
            Console.WriteLine("(4) Ejercicio 4");
            Console.WriteLine("(5) Ejercicio 5");
            Console.WriteLine("(6) Ejercicio 6");
            Console.WriteLine("(7) Ejercicio 7");
            Console.WriteLine("(8) Ejercicio 8");
            opt = Int32.Parse(Console.ReadLine());
            Console.Clear();
        

           switch (opt)
           {
                 case 1:
                 //Ej1
                 Persona persona1 = cargarPersona();
                 persona1.ToString();

                    break;
                case 2:
                    //Ej2
                    Persona persona2 = new Persona("Juan", 17, 50054502);
                    Persona persona3 = new Persona("Carlitos", 20, 45345426);
                    persona2.mostrar();
                    persona3.mostrar();

                    Console.WriteLine("Es " + persona2.Nombre + " mayor de edad: " + persona2.esMayorDeEdad());
                    Console.WriteLine("Es " + persona3.Nombre + " mayor de edad: " + persona3.esMayorDeEdad());
                    Console.ReadKey();

                    break;
                case 3:
                    Persona persona4 = new Persona("Pepe", 14, 52254502);
                    Cuenta cuenta = new Cuenta(persona4,10000);
                    CuentaJoven joven = new CuentaJoven(persona4, 500);

                    cuenta.mostrar();
                    Console.ReadKey();
                    cuenta.ingresar(5000.20);
                    cuenta.retirar(4000.10);

                    cuenta.mostrar();
                    Console.ReadKey();

                    joven.mostrar();
                    Console.ReadKey();
                    break;
                case 4:
                    Persona persona5 = new Persona("Agustin", 10, 5800000); 
                    Persona persona6 = new Persona("Jose", 20, 4550000);

                    CuentaJoven joven1 = new CuentaJoven(persona5,0);
                    CuentaJoven joven2 = new CuentaJoven(persona6,50000);

                    bool validez =joven1.esTitularValido();
                    Console.WriteLine("El titular es valido: " + validez);
                    Console.ReadKey();
                    validez = joven2.esTitularValido();
                    Console.WriteLine("El titular es valido: " + validez);
                    Console.ReadKey();

                    joven1.retirar(1000);
                    joven2.retirar(1000);

                    joven2.mostrar();
                    Console.ReadKey();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    Eiffel eiffel = new Eiffel();
                    eiffel.insercion(1);
                    eiffel.insercion(5);
                    eiffel.insercion(7);
                    eiffel.insercion(2);
                    Console.WriteLine("Mostrar: ");
                    eiffel.mostrar();
                    Console.ReadKey();
                    Console.WriteLine("Elemento: ");
                    Console.WriteLine(eiffel.elemento(2));
                    Console.ReadKey();
                    Console.WriteLine("Elementos: ");
                    int a = eiffel.elementos();
                    Console.WriteLine(a);
                    Console.ReadKey();
                    Console.WriteLine("Poda: ");
                    eiffel.poda();
                    eiffel.mostrar();
                    Console.ReadKey();
                    break;
                case 8:
                    AlbumFotos album = new AlbumFotos();
                    AlbumFotos album24 = new AlbumFotos(24);
                    SuperAlbumFotos superAlbum = new SuperAlbumFotos();

                    album.mostrar();
                    album24.mostrar();
                    superAlbum.mostrar();
                    Console.ReadKey();

                    break;
           }
     
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
