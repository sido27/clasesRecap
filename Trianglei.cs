using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Trianglei
    {
        public int Longitud { get; set; } 
        public int LongitudLado { get; set; }
        public int Altura { get; set; }





        public Trianglei(int longitud, int longitudLado, int altura)
        {
            Longitud = longitud;
            LongitudLado = longitudLado;
            Altura = altura;
        }





        public void perimetro( )
        {

            int perimeter = (Longitud * 2) + LongitudLado; 

  
            Console.WriteLine(perimeter);

        }


        public void area()
        {

            var area = (0.5) * Longitud * Altura;


            Console.WriteLine(area);

        }

    }


    
}
