using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2023
{
     class RegistroAeropuerto
    {

        public string codigo { get; set; }

        public string Nombre { get; set; }

        public string pais { get; set; }

        public string ciudad { get; set; }

        public string telefono { get; set; }

        public bool estado { get; set; }

        RegistroAeropuerto[] RegistrosAeropuertos = new RegistroAeropuerto[20];


        //constructor
         public RegistroAeropuerto(string Codigo)
        {
            codigo = Codigo;
        }
        public RegistroAeropuerto(string Pais, string Ciudad)
        {
            pais = Pais;
            ciudad = Ciudad;
        }
     public RegistroAeropuerto()
        {

        }

        public override string ToString()
        {
            return "\tAeropuertos \nCodigo: " + this.codigo + "\nNombre: " + this.Nombre + "\nPais:" + this.pais+"\nCiudad: "+this.ciudad + "\ntelefono :" + this.telefono;

            
            

        }

        public  string devolverEstado()
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
