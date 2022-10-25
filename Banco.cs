using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Banco
    {
        public Cleinte[] atributo { get; set; } = new Cleinte[3];

        public void Operar(string dni)
        {

            Cleinte c = new Cleinte(dni);

            //b. Banco: tiene un atributo que será un array de tamaño 3 de objetos de tipo Cliente.
            //Tendrá un método Operar, que permitirá llamar a los métodos Ingresar y Extraer
            //de los clientes. Para ello nos solicitará el cliente sobre el DNI sobre el que
            //queremos operar, la operación a realizar y la cantidad. También banco debe tener
            //otro método que “al final del día” calcule la cantidad de dinero que hay
            //depositada

            int number = -1;

            while (number != 1 && number != 2)
            {
                Console.WriteLine("enter number 1 for withdrawal or 2 for deposit");
                var input = Console.ReadLine();
                int.TryParse(input, out number);

                if (number == 1)
                {
                    c.Ingresas(200); // o cualquer otra cantidad pasada por parametro sis queremos
                    Console.WriteLine(c.Cantidad);
                }

                else
                {
                    c.Extraer(50); // o cualquer otra cantidad pasada por parametro sis queremos
                    Console.WriteLine(c.Cantidad);
                }

            }

        }

        public void FinalDia(string dni)
        {
            Cleinte c = new Cleinte(dni);

            Console.WriteLine($"cantidad de dinero que hay depositada es {c.Cantidad}");

        }
    }
}
