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
        private int tanque;
        private string resultado;
                 

        
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

        public int Tanque
        {
            get { return tanque; }
            set { tanque = value; }
        }

        public string tengoGasolina()
        {
            
             if (tanque > 0)
            {
                if (tanque <= 10)
                    {

                    return"Esta en reserva";

                    }
                else
                {
                    return  "Tiene mas de medio tanque de gasolina";
                }
      
            }

            return  "Valla a la gasolinera";
        }

        

        




    }
}
