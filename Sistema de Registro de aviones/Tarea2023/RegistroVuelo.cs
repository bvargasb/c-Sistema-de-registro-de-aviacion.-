using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2023
{
     class RegistroVuelo
    {

        public int Numero { get; set; }

        public RegistroAerolinea Aerolinea { get; set; }

        public RegistroAeropuerto Aeropuerto { get; set; }

        public RegistroAeropuerto Destino { get; set; }

        public TimeSpan Duracion { get; set; }

        public int Capacidad { get; set; }

        RegistroVuelo[] RegistroVuelos = new RegistroVuelo[20];

        // constructor 
        public RegistroVuelo(RegistroAerolinea aerolinea)
        {
            Aerolinea = aerolinea;
        }

        public RegistroVuelo(RegistroAeropuerto aeropuerto)
        {
            Aeropuerto = aeropuerto;
        }

        public RegistroVuelo()
        {

        }

        public override string ToString()
        {
            return "\tVuelos\nNumero de vuelo: " + Numero + "\nNombre Aerolinea: " + Aerolinea.Nombre + "\nPais Origen: " + this.Aeropuerto.pais + "\nCiudad Origen: " + this.Aeropuerto.ciudad +
                "\nPais Destino: " + this.Destino.pais + "\nCiudad Destino: " + this.Destino.ciudad + "\nDuracion: " + this.Duracion + "\nCapacidad: " + this.Capacidad;
        }


    }
}
