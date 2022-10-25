using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace clases
{

    //Confeccionar una clase Persona que tenga como atributos el nombre y la edad(definir las
    //propiedades para poder acceder a dichos atributos). Definir también un método para
    //imprimir.Plantear una segunda clase Empleado que herede de la clase Persona. Añadir un
    //atributo sueldo (y su propiedad) y el método para imprimir su sueldo.Definir un objeto de
    //la clase Persona y llamar a sus métodos y propiedades.También crear un objeto de la
    //clase Empleado y llamar a sus métodos y propiedades.



    internal class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public Persona(int edad, string nombre)
        {
            Edad = edad;
            Nombre = nombre;

        }

        public void Imprimir()
        {
            Console.WriteLine($"edad es {Edad} y nombre es {Edad}");
        }

    }
}
