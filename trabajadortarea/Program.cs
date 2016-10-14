using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajadortarea
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            string linea;
            ClassTrabajador empleado = new ClassTrabajador();
            
            Console.WriteLine("Ingresa nombre: ");
            empleado.Nombre = Console.ReadLine();
         
            Console.WriteLine("Ingresa Edad: ");
            linea = Console.ReadLine();
            empleado.Edad = int.Parse(linea);
      
            Console.WriteLine("Ingresa Salario: ");
            linea = Console.ReadLine();
            empleado.Salario = double.Parse(linea);

            if (empleado.Salario >= 10000)
            {
                empleado.iva = 0.20 * empleado.Salario;
                total = empleado.Salario - empleado.iva;
                Console.WriteLine("tu salario es de : ");
                Console.WriteLine(total);
            }
            else
            {
                empleado.iva = 0.16 * empleado.Salario;
                total = empleado.Salario - empleado.iva;
                Console.WriteLine("tu salario es de : {1}", total);
                Console.WriteLine(total);
            }

            Console.ReadKey();
        }
    }
}
