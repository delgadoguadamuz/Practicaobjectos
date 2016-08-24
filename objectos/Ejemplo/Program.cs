using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite el nombre:\n");
            string nombre = (Console.ReadLine());
            Console.Write("Digite la edad:\n");
            int edad = int.Parse(Console.ReadLine());

            Alumno nombrePersona = new Alumno(nombre,edad);

            Console.WriteLine(nombrePersona.Imprimir());
            Console.WriteLine(nombrePersona.CalculoMayorEdad());
            Console.ReadKey();

        }
    }
}
