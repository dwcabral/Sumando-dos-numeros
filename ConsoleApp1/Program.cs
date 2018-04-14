using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string Saludo = "Gracias vuelva pronto";
            string Aviso = "Para Salir precione cualquier tecla.";

            Console.WriteLine("******************************************************************");
            Console.WriteLine("Bienvenido al sistema de suma de dos numeros");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Realizado por el Grupo los Monteros");

            Console.WriteLine("Domingo Cabral          08-EISN-1-032");
            Console.WriteLine("Francis Montero         13-EISM-1-021");
            Console.WriteLine("Ysaul Vicente           13-EISM-1-035");
            Console.WriteLine("******************************************************************");


            Console.WriteLine("Escriba el primer numero:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2;

            while (resultado == 2500)
            {
                Console.WriteLine("La suma es :" + resultado);
            }

            for (int i = 0; i < numero1; i++)
            {
                Console.WriteLine("La suma es :" + resultado);
            }
            if (Saludo == "Gracias vuelva pronto")
            {
                Console.WriteLine("Saludo :" + Saludo);
            }
            if (Aviso == "Para Salir precione cualquier tecla.")
            {
                Console.WriteLine("Aviso :" + Aviso);
            }

            Console.ReadKey();
        }
    }
}