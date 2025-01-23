using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE_LAB_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nombre;
            double SalarioInicial, SalarioFinal;

            Console.WriteLine("\n\t Hola Mundo");

            Console.WriteLine("\n\t Ingrese su Nombre");
            Nombre= Console.ReadLine();



            Console.WriteLine("\n\tSalario: $");
            SalarioInicial = double.Parse(Console.ReadLine());


            //Haciendo Proceso (Cálculo)

            SalarioFinal = SalarioInicial - (SalarioInicial * 0.1);
            Console.WriteLine("\n\t Estimad@; " + Nombre + " Su Salario Final es: " + SalarioFinal);



        }
    }
}
