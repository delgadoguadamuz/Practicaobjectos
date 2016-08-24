using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectos
{
    class Estudiante
    {

        //1. Atributos

        private string nombre;
        private int grado;
        private decimal nota;


        // 2. Constructores

        private Estudiante() { }

        public Estudiante(string pnombre, int pgrado, decimal pnota) {

            this.nombre = pnombre;
            this.grado = pgrado;
            this.nota = pnota;

        }

        //3. Propiedades

        public string Nombre
        {

            get { return nombre; }
            set { nombre = value; }
        }


        public int Grado
        {

            get { return grado; }
            set { grado = value; }
        }

        public decimal Nota
        {

            get { return Math.Round(nota); }
            set { nota= value; }
        }

        //Metodos

        public string Imprimir()
        {

            return "Nombre: " + Nombre + "Grado:" + Grado + "Nota: " + Nota; 

        }

    }


}

