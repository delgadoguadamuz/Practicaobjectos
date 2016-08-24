using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Alumno
    {

        private string nombre;
        private int edad;


        private Alumno() { }

        public Alumno(string pnombre, int pedad)
        {
            this.nombre = pnombre;
            this.edad = pedad;
            
        }

        public string Imprimir()
        {

            return "Nombre:   " + nombre + "  edad:  " + edad;

        }

        public string CalculoMayorEdad()
        {



            if (edad >= 18) 
            {

                return "El Alumno es mayor de edad";           

            }
            else
            {

                return "El Aumno es menor de edad";

            }

        }



    }
}
