using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{




    internal class Coche
    {

      

        public int Velocidad { get; set; } = 0;
        public int Anno { get; set; } = 2020;
        public int VelocidadMaxima { get; init; }
        public string Marca { get; set; }

        public Coche(string marca)
        {

            Marca = marca;
           
        }


        public Coche()
        {

        }


        public void Acelerar(int incremento)
        {

            if (Velocidad + incremento > VelocidadMaxima)
            {
                Console.WriteLine("Superar la velocidad maxima");
            }

            Velocidad += incremento;

        }



        public void Acelerar()
        {

            Acelerar(1);
        }








    }
}
