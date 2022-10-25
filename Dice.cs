using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Dice
    {
        public int valor { get; set; }



      public void Tirar()
        {

            Random rnd = new Random();
            int tirado = rnd.Next(1, 7);


            Console.WriteLine(tirado);

        }
    }



}
