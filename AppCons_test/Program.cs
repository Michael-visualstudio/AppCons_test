using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCons_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo c#");

            //ejemplo de los pilares de la programacion estructurada
            //secuencias
            int a;
            a = 10;
            int b = 20;
            Console.WriteLine("la multiplicacion de {0} x {1}", a, b, (a * b));

            //condicionales
            if (a > b)
                Console.WriteLine(" {0} es mayor", a);
            else
                Console.WriteLine(" {0} es mayor", b);

            

            //bucle while
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("{0} Bienvenidos a GIT ", j);
                j++;
            }

            //bucle for
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hola {0}", i);
            }
            
            //bucle foreach
            string nombre = "bucleforeach";
            foreach (char letra in nombre)
            {
                Console.WriteLine(" " + letra + " ");
            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            //desde repositorio remoto, buscar como compartir su proyecto
            //kleberposligua@hotmail.com
        }
    }
}
