using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularsalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, coshora = 0, salario = 0;
            Console.WriteLine("Calcular el salario a pagar");
            Console.WriteLine("Ingrese la cantidad de horas");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la hora");
            coshora = Convert.ToInt32(Console.ReadLine());
            salario = horas * coshora;
            Console.WriteLine("El total a pagar es: " + salario);
            Console.ReadLine();
        }
    }
}
