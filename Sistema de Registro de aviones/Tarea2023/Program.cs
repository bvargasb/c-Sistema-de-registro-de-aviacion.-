using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2023
{
    internal class Program
    {
        int indice = 0; // para recorrer arreglos
        //arreglos de objetos
        RegistroCliente[] RegistroClientes = new RegistroCliente[20];
        RegistroAeropuerto[] registroAeropuertos = new RegistroAeropuerto[20];
        RegistroAerolinea[] registroAerolineas = new RegistroAerolinea[20];
        RegistroVuelo[] registroVuelos = new RegistroVuelo[20];


        string idCliente;
        string nomcliente;
        string PrimerApellido1;
        string SegundoApellido1;
        DateTime FechaNacimiento1;
        char genero1;
        RegistroCliente AlmacenarCliente;


        string Codigo_;
        string Nombre_;
        string pais_;
        string ciudad_;
        string telefono_;
        bool estado_;
        RegistroAeropuerto AlmacenarAeropuerto;

        int ID_;
        string _Nombre_;
        string _telefono_;
        bool _estado_;
        RegistroAerolinea AlmacenarAerolinea;

        int Numero_1;
        RegistroAerolinea ObjetoAerolinea;
        RegistroAeropuerto ObjetoOrigen;
        RegistroAeropuerto ObjetoDestino;
        TimeSpan Duracion_;
        int Capacidad_;
        RegistroVuelo AlmacenarVuelo;

        string NomAerolinea_;
        string Origen;
        string Destino;

        string seguir = "s"; //variable usada para continuar

        public void menu()
        {
            Console.WriteLine("Digite la opcion que desea consultar.");
            Console.WriteLine("1• Registrar Clientes.");
            Console.WriteLine("2• Registrar Aeropuertos.");
            Console.WriteLine("3• Registrar Aerolinea.");
            Console.WriteLine("4• Registrar Vuelo.");
            Console.WriteLine("    Consulta.");
            Console.WriteLine("5• Consultar Clientes.");
            Console.WriteLine("6• Consultar Aeropuertos.");
            Console.WriteLine("7• Consultar Aerolinea.");
            Console.WriteLine("8• Consultar Vuelo.");
            Console.WriteLine("9• Salir, Digite N");
        }

        public void RegistrarClienteFuncion()
        {
            do
            {
                try
                {
                    Console.WriteLine("Digite la identificacion");

                    idCliente = Console.ReadLine();

                    RegistroCliente valorverif = RegistroClientes.FirstOrDefault(cd => cd?.identificacion == idCliente);
                    //LINQ // no explicado en la tutoria ni en los capitulos del libro
                    //me permite acceder a la variable del objeto que sea igual al digitado para luego verificarlo. 

                    if (valorverif != null)
                    { // verifica si se encuentra en el arreglo. 

                        Console.WriteLine("La identificacion ya se encuentra registrada. ");
                        Console.WriteLine("Vuelva a ingresar la identificacion de la sucursal");
                        Console.WriteLine("Desea ingresar otro cliente? S/N");
                        seguir = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {

                        Console.WriteLine("Digite el nombre");
                        nomcliente = Console.ReadLine();

                        Console.WriteLine("Digite el primer apellido");
                        PrimerApellido1 = Console.ReadLine();

                        Console.WriteLine("Digite el segundo apellido");
                        SegundoApellido1 = Console.ReadLine();

                        Console.WriteLine("Digite la Fecha de nacimiento DD/M/YYYY");
                        FechaNacimiento1 = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite el genero, M = Masculino, F = Femenino, N= No especifica");
                        genero1 = Convert.ToChar(Console.ReadLine());

                        AlmacenarCliente = new RegistroCliente { identificacion = idCliente, Nombre = nomcliente, PrimerApellido = PrimerApellido1, SegundoApellido = SegundoApellido1, FechaNacimineto = FechaNacimiento1, genero = genero1 };
                        RegistroClientes[indice] = AlmacenarCliente;
                        indice++;
                        Console.WriteLine("Desea ingresar otro cliente? S/N");
                        seguir = Console.ReadLine();
                        Console.Clear();

                    }

                }
                catch (Exception e) //Desarrollaré las excepciones con mayor precision cuando use la interfaz gráfica. 
                {
                    Console.Clear();
                    Console.WriteLine("{0} Error al digitar el dato, vuelva a introducirlo.", e);
                    Console.WriteLine("Desea ingresar los datos de nuevo? S/N");
                    seguir = Console.ReadLine();
                    Console.Clear();

                }

            } while (seguir.ToLower().Equals("s"));

        }


        public void RegistrarAeropuertoFuncion()
        {
            do
            {
                try
                {

                    Console.WriteLine("Digite el codigo");
                    
                    
                        Codigo_ = Console.ReadLine();
                        
                    if(Codigo_.Length>4 || Codigo_.Length < 4)
                    {
                        Console.WriteLine("El codigo debe ser de cuatro digitos o palabras o ambos, no menos, ni mas");
                        Console.WriteLine("Vuelva a ingresar el codigo");
                        Console.WriteLine("Desea ingresar otro codigo? S/N");
                        seguir = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        RegistroAeropuerto valorverif = registroAeropuertos.FirstOrDefault(cd => cd?.codigo == Codigo_);
                        //LINQ // no explicado en la tutoria ni en los capitulos del libro
                        //me permite acceder a la variable del objeto que sea igual al digitado para luego verificarlo. 

                        if (valorverif != null)
                        { // verifica si se encuentra en el arreglo. 

                            Console.WriteLine("El codigo ya se encuentra registrado. ");
                            Console.WriteLine("Vuelva a ingresar el codigo");
                            Console.WriteLine("Desea ingresar otro codigo? S/N");
                            seguir = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {

                            Console.WriteLine("Digite el nombre");
                            Nombre_ = Console.ReadLine();

                            Console.WriteLine("Digite el pais");
                            pais_ = Console.ReadLine();

                            Console.WriteLine("Digite la ciudad ");
                            ciudad_ = Console.ReadLine();

                            Console.WriteLine("Digite el telefono");
                            telefono_ = Console.ReadLine();

                            Console.WriteLine("Estado, Digite una A = Activo, y para I= Inactivo");
                            string A = Console.ReadLine();

                           
                                if (A.ToLower().Equals("a"))
                                {
                                estado_  = true;
                                }
                                else
                                {

                                estado_ = false;


                                }
                            


                            AlmacenarAeropuerto = new RegistroAeropuerto { codigo = Codigo_, Nombre = Nombre_, pais = pais_, ciudad = ciudad_, telefono = telefono_, estado = estado_ };
                            registroAeropuertos[indice] = AlmacenarAeropuerto;
                            indice++;
                            Console.WriteLine("Desea ingresar otro aeropuerto? S/N");
                            seguir = Console.ReadLine();
                            Console.Clear();

                        }
                    }
                 

                }
                catch (Exception e) //Desarrollaré las excepciones con mayor precision cuando use la interfaz gráfica. 
                {
                    Console.Clear();
                    Console.WriteLine("{0} Error al digitar el dato, vuelva a introducirlo.", e);
                    Console.WriteLine("Desea ingresar los datos de nuevo? S/N");
                    seguir = Console.ReadLine();
                    Console.Clear();

                }

            } while (seguir.ToLower().Equals("s"));

        }

        public void RegistroAerolineaFuncion()
        {
            do
            {
                try
                {
                    Console.WriteLine("Digite la identificacion");

                    ID_ = Convert.ToInt32(Console.ReadLine());

                    RegistroAerolinea valorverif = registroAerolineas.FirstOrDefault(cd => cd?.ID == ID_);
                    //LINQ // no explicado en la tutoria ni en los capitulos del libro
                    //me permite acceder a la variable del objeto que sea igual al digitado para luego verificarlo. 

                    if (valorverif != null)
                    { // verifica si se encuentra en el arreglo. 

                        Console.WriteLine("La Identificacion ya se encuentra registrado. ");
                        Console.WriteLine("Vuelva a ingresar la identificacion");
                        Console.WriteLine("Desea ingresar otra identificacion? S/N");
                        seguir = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    { 

                        Console.WriteLine("Digite el nombre");
                        _Nombre_ = Console.ReadLine();

                        Console.WriteLine("Digite el telefono");
                        _telefono_ = Console.ReadLine();

                        Console.WriteLine("Estado, Digite una A = Activo, y para I= Inactivo");
                        string A = Console.ReadLine();

                        if (A.ToLower().Equals("a"))
                        {
                            _estado_ = true;
                        }
                        else
                        {
                            _estado_ = false;
                        }

                        AlmacenarAerolinea = new RegistroAerolinea { ID = ID_, Nombre = _Nombre_, telefono = _telefono_, estado = _estado_ };
                        registroAerolineas[indice] = AlmacenarAerolinea;
                        indice++;
                        Console.WriteLine("Desea ingresar otra aerolinea? S/N");
                        seguir = Console.ReadLine();
                        Console.Clear();

                    }

                }
                catch (Exception e) //Desarrollaré las excepciones con mayor precision cuando use la interfaz gráfica. 
                {
                    Console.Clear();
                    Console.WriteLine("{0} Error al digitar el dato, vuelva a introducirlo.", e);
                    Console.WriteLine("Desea ingresar los datos de nuevo? S/N");
                    seguir = Console.ReadLine();
                    Console.Clear();

                }

            } while (seguir.ToLower().Equals("s"));
        }

        public void RegistroVueloFuncion()
        {
            do
            {
                try
                {
                    Console.WriteLine("Digite el numero");

                    Numero_1 = Convert.ToInt32(Console.ReadLine());

                    RegistroVuelo valorverif = registroVuelos.FirstOrDefault(cd => cd?.Numero == Numero_1);
                    //LINQ // no explicado en la tutoria ni en los capitulos del libro
                    //me permite acceder a la variable del objeto que sea igual al digitado para luego verificarlo. 

                    if (valorverif != null)
                    { // verifica si se encuentra en el arreglo. 

                        Console.WriteLine("El número ya se encuentra registrado.");
                        Console.WriteLine("Vuelva a ingresar el número");
                        Console.WriteLine("Desea ingresar otro número? S/N");
                        seguir = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {


                        Console.WriteLine("Digite el nombre de la aerolinea");
                        NomAerolinea_ = Console.ReadLine();

                        RegistroAerolinea valorverif1 = registroAerolineas.FirstOrDefault(cd => cd?.Nombre == NomAerolinea_);

                        if(valorverif1 == null)
                        {
                            Console.WriteLine("El nombre de la aerolinea no se encuentra registrado.");
                            Console.WriteLine("Vuelva a ingresar la aerolinea");
                            Console.WriteLine("Desea ingresar otra aerolinea? S/N");
                            seguir = Console.ReadLine();
                            Console.Clear();

                        }
                        else
                        {
                            ObjetoAerolinea = new RegistroAerolinea (NomAerolinea_); // guarda la variable objeto para luego asignarla en el arreglo

                            Console.WriteLine("Digite el codigo del aeropuerto de Origen");
                            Origen = Console.ReadLine();

                            RegistroAeropuerto valorverif2 = registroAeropuertos.FirstOrDefault(cd => cd?.codigo == Origen);

                            if(valorverif2 != null)
                            {
                                Console.WriteLine("Digite el pais de Origen");
                                string pais = Console.ReadLine();

                                Console.WriteLine("Digite la ciudad de Origen");
                                string ciudad = Console.ReadLine();

                                ObjetoOrigen = new RegistroAeropuerto(pais, ciudad);
                                

                                Console.WriteLine("Digite el codigo del aeropuerto de Destino");
                                Destino = Console.ReadLine();

                                RegistroAeropuerto valorverif3 = registroAeropuertos.FirstOrDefault(cd => cd?.codigo == Destino);

                                if(valorverif3 != null)
                                {
                                   

                                    if (valorverif2 == valorverif3) // los codigos de aeropuerto de origen y destino
                                    {

                                        Console.WriteLine("El codigo del aeropuerto de destino es igual al de origen.");
                                        Console.WriteLine("Vuelva a ingresar los codigos del aeropuerto");
                                        Console.WriteLine("Desea ingresar otro codigo? S/N");
                                        seguir = Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {

                                        Console.WriteLine("Digite el pais de destino");
                                        string _pais_ = Console.ReadLine();

                                        Console.WriteLine("Digite la ciudad de Destino");
                                        string _ciudad_ = Console.ReadLine();

                                        ObjetoDestino = new RegistroAeropuerto(_pais_,_ciudad_);

                                      
                                        Console.WriteLine("Digite las horas");
                                        int horas = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Digite los minutos");
                                        int minutos = Convert.ToInt32(Console.ReadLine());
                                         
                                        Duracion_ = new TimeSpan(horas, minutos, 00);

                                        Console.WriteLine("Digite la capacidad");
                                        Capacidad_ = Convert.ToInt32(Console.ReadLine());

                                        AlmacenarVuelo = new RegistroVuelo { Numero = Numero_1, Aerolinea = ObjetoAerolinea, Aeropuerto = ObjetoOrigen, Destino = ObjetoDestino, Duracion = Duracion_, Capacidad = Capacidad_ };
                                        registroVuelos[indice] = AlmacenarVuelo;
                                        indice++;
                                        Console.WriteLine("Desea ingresar otra vuelo? S/N");
                                        seguir = Console.ReadLine();
                                        Console.Clear();
                                    }

                                 
                                }else
                                {
                                    Console.WriteLine("El destino no se encuentra registrado en los aeropuertos.");
                                    Console.WriteLine("Vuelva a ingresar el destino");
                                    Console.WriteLine("Desea ingresar otro destino? S/N");
                                    seguir = Console.ReadLine();
                                    Console.Clear();
                                }


                            }
                            else
                            {
                                Console.WriteLine("El origen no se encuentra registrado en los aeropuertos.");
                                Console.WriteLine("Vuelva a ingresar el origen");
                                Console.WriteLine("Desea ingresar otro destino? S/N");
                                seguir = Console.ReadLine();
                                Console.Clear();
                            }


                        }



                    }

                }
                catch (Exception e) //Desarrollaré las excepciones con mayor precision cuando use la interfaz gráfica. 
                {
                    Console.Clear();
                    Console.WriteLine("{0} Error al digitar el dato, vuelva a introducirlo.", e);
                    Console.WriteLine("Desea ingresar los datos de nuevo? S/N");
                    seguir = Console.ReadLine();
                    Console.Clear();

                }

            } while (seguir.ToLower().Equals("s"));
        }


        //funcionesconsultar
        public void ConsultarAeropuertos()
        {
            try
            {
                for (int i = 0; i < registroAeropuertos.Length; i++)
                {
                    Console.WriteLine(registroAeropuertos[i]?.ToString());
                    //uso de ? para que el resto de valores del vector queden apuntando a null y no se ejecute la excepcion, ya que este metodo 

                    Console.WriteLine(registroAeropuertos[i]?.devolverEstado());

                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void ConsultarAerolineas()
        {
            try
            {
                for (int i = 0; i < registroAerolineas.Length; i++)
                {
                    Console.WriteLine(registroAerolineas[i]?.ToString());
                    //uso de ? para que el resto de valores del vector queden apuntando a null y no se ejecute la excepcion, ya que este metodo 

                    Console.WriteLine(registroAerolineas[i]?.devolverEstado());
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void ConsultarVuelos()
        {
            try
            {
                for(int i = 0; i < registroVuelos.Length; i++)
                {
                    Console.WriteLine(registroVuelos[i]?.ToString());
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public void ConsultarClientes()
        {
            try
            {
                for(int i = 0; i<RegistroClientes.Length; i++)
                {
                    Console.WriteLine(RegistroClientes[i]?.ToString());

                }


            }
            catch (Exception e)
            {
                e.ToString();
            }
  
        }



        public void continuar()
        {

            Console.WriteLine("Desea volver al menu? S/N");
            seguir = Console.ReadLine();
            Console.Clear();
        }


        static void Main(string[] args)
        {


            Program pr = new Program(); // instancia de clase program
            string seguir = "s";
            int opc;


            do
            {

                pr.menu();
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        {

                            pr.RegistrarClienteFuncion();
                        }
                        break;
                    case 2:
                        {

                            pr.RegistrarAeropuertoFuncion();

                        }
                        break;
                    case 3:
                        {
                            pr.RegistroAerolineaFuncion();
                        }
                        break;
                    case 4:
                        {
                            pr.RegistroVueloFuncion();
                        }
                        break;

                    case 5:
                        {
                            pr.ConsultarClientes();
                        }
                        break;
                    case 6:
                        {

                            pr.ConsultarAeropuertos();
                        }
                        break;
                    case 7:
                        {
                            pr.ConsultarAerolineas();

                        }
                        break;
                    case 8:
                        {
                            pr.ConsultarVuelos();


                        }
                        break;
                    default:
                        Console.WriteLine("Se ingreso un valor fuera de rango, debe ingresar de nuevo.");
                        break;

                }


            } while (seguir.ToLower().Equals("s"));
        }
    }
}
