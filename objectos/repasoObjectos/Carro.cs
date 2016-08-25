using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoObjectos
{
    class Carro
    {

        private string color;
        private int kilometraje;
        private string modelo;
        private int ano;
        private string marca;       

        
        public Carro(string pModelo, int pAnno, string pMarca)
        {
            this.modelo = pModelo;
            this.ano = pAnno;
            this.marca = pMarca;

        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }




    }
}
