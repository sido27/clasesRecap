using System;
using System.Collections.Generic;
using System.Linq;
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

    internal class Empleado : Persona
    {

        public decimal Sueldo { get; set; }

        public Empleado(int edad, string nombre, decimal sueldo) : base(edad, nombre)
        {
            this.Sueldo = sueldo;
        }

        public void ImprimeSueldo()
        {
            Console.WriteLine($"Sueldo es {Sueldo}");
        }

    }

}

