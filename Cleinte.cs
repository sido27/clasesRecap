using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Crea un programa con las siguientes clases:
//a.Cliente: esta clase tendrá los siguientes atributos DNI, nombre y cantidad
//ahorrada y los métodos Ingresar (aumentará la cantidad ahorrada con el dinero
//indicado), Extraer(restará a la cantidad ahorrada lo que se indique) y Consultar
//Saldo, que mostrará la cantidad ahorrada en cada momento.



namespace clases
{
    internal class Cleinte
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }


        public Cleinte(string dni )
        {
            DNI = dni;
     
        }


        public void Extraer(decimal retirado)
        {
            Cantidad = Cantidad - retirado;

        }


        public void Ingresas(decimal ingresado)
        {
            Cantidad = Cantidad + ingresado;

        }


        public void Consultar()
        {
            Console.WriteLine($"usted ha quedado {Cantidad}€ en su cuenta");
        }






    }
}
