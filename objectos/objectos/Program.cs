using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectos
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante estudiante = new Estudiante("Juan",4 ,84.4M);
           
            Console.WriteLine(estudiante.Imprimir());    
            Console.ReadKey();
            
        }
    }
}
