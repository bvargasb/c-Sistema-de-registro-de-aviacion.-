using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2023
{
    class RegistroCliente
    {

       public string identificacion { get; set; }

        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public DateTime FechaNacimineto { get; set; }

        public char genero { get; set; }

        RegistroCliente[] RegistroClientes = new RegistroCliente[20]; //arreglo de 20 posiciones

        public override string ToString()
        {
            return "\tClientes{ \nIdentificacion: " + this.identificacion + "\nNombre: " + this.Nombre + "\nPrimero Apellido: " + this.PrimerApellido + "\nSegundo Apellido: " + this.SegundoApellido + "\nFecha Nacimiento: " + this.FechaNacimineto + "\nGenero: " + this.genero + "}";
        }

    }
}
