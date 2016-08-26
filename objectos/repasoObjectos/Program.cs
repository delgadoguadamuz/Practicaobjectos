using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoObjectos
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro("Montero",2002,"Toyota");
            Console.WriteLine(carro.Marca);
            carro.Tanque = 20;
            Console.WriteLine(carro.tengoGasolina());
            Console.ReadKey();  

        }
    }
}
