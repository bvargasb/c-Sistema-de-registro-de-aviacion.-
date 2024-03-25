using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2023
{
    class RegistroAerolinea
    {
       public int ID { get; set; }

        public string Nombre { get; set;}

        public string telefono { get; set; }

        public bool estado { get; set; }

        // arreglo
        RegistroAerolinea[] RegistroAerolineas = new RegistroAerolinea[20];

        //constructor
        public RegistroAerolinea()
        {

        }
       public RegistroAerolinea(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "\tAerolineas\nId: "+this.ID+"\nNombre: "+this.Nombre+"\nTelefono: "+this.telefono;
        }

        public string devolverEstado()
        {
            if (this.estado == true)
            {
                return "\nestado: Activo\n";
            }
            else
            {
                return "\nestado: Inactivo\n";
            }

        }
    }



    
}
