using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            /*Console.WriteLine("Escriba un numero de 0 a 255");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 1;

            if (b<0)
            {
                Console.WriteLine("El numero es negativo");
                Console.ReadKey();

            }

            else if(b>255)
            {
                Console.WriteLine("El numero excede los limites");
                Console.ReadKey();

            }
            else
            {
                while (c <= 12)
                {
                    Console.WriteLine(c + "*" + b + " = " + c * b);
                    c++;
                }
                Console.ReadKey();

            }*/

            //Ejercicio 2
            /*Console.WriteLine("Escribir numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribir codigo de area: ");
            string d = Console.ReadLine();

            if(d=="DO" || d=="RU" || d=="PE")
            {
               Console.WriteLine(n + (n * 0.18));
               Console.ReadKey();
               
            }

            else if (d == "MEX" || d == "CO")
            {
                Console.WriteLine(n + (n * 0.16));
                Console.ReadKey();

            }

            else if (d == "HO" || d == "NI" || d == "IN")
            {
                Console.WriteLine(n + (n * 0.15));
                Console.ReadKey();

            }*/


            //Ejercicio 3
            
            /*String[] Unidad = { "", "primero", "segundo", "tercero",
            "cuarto", "quinto", "sexto", "septimo", "octavo",
            "noveno" };
            String[] Decena = { "", "decimo", "vigesimo", "trigesimo",
            "cuadragesimo", "quincuagesimo", "sexagesimo",
            "septuagesimo", "octogesimo", "nonagesimo" };
            String[] Centena = {"", "centesimo", "ducentesimo",
            "tricentesimo", "cuadringentesimo", "quingentesimo",
            "sexcentesimo", "septingentesimo", "octingentesimo",
            "noningentesimo"};
            Console.WriteLine("Ingresa numero entre 1 y 999");
            int N = Convert.ToInt32(Console.ReadLine());
            int u = N % 10;
            int de = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Console.WriteLine(Centena[c] +" " +Decena[de] +" "+Unidad[u]);
                Console.ReadKey();

            }
            else
            {
                if (N >= 10)
                {
                    Console.WriteLine(Decena[de] +" "+Unidad[u]);
                }
                else
                {
                    Console.WriteLine(Unidad[N]);
                }
            }
            Console.ReadLine();*/
            




        }
    }
}
