

class CajeroAutomatico
{

    double saldo = 5000;


    void menu()
    {

        string opciones;
        do
        {
            Console.Clear();
            Console.WriteLine(@"========= Selecciona la operación=================  
1. Consultar saldo actual
2. Depositar
3. Retirar
4. salir ");
            Console.WriteLine("Seleccione una opcion");
            opciones = Console.ReadLine();

            switch (opciones)
            {
                case "1":
                    ConsultarSaldo();
                    break;
                case "2":
                    Depositar();
                    break;
                case "3":
                    Retirar();
                    break;
                case "4":
                    Salir();
                    break;

                default:
                    Console.WriteLine("Opcion invalida, intente nuevamente...");
                    Console.ReadKey();
                    break;
            }
        }
        while (opciones != "4");
    }

            void ConsultarSaldo()
            {
                Console.Clear();
                Console.WriteLine($" su saldo actual es de {saldo}");
                OtraOperacion();
            }

            void Depositar()
            {
                Console.WriteLine("Ingrese la cantidad que desea depositar...");
                Double deposito = Convert.ToDouble(Console.ReadLine());
                if (deposito <= 0)
                {
                    Console.WriteLine("El deposito no puede ser 0...");
                    Depositar();
                }
                else
                {
                    saldo += deposito;
                    Console.WriteLine($" Su saldo actual es de: {saldo}");
                    OtraOperacion();
                }
            }

    void Retirar()
    {
        Console.WriteLine("Ingrese la cantidad que desea retirar");
        Double retirar = Convert.ToDouble(Console.ReadLine());
        if (retirar == 0)
        {
            Console.WriteLine("Ingresa un valor mayor a cero...");
            Retirar();
        }
        if (retirar > saldo)
        {
            Console.WriteLine("Fondos Insuficientes...");
            Retirar();
        }
        else
        {
            saldo -= retirar;
            Console.WriteLine($"Retiro exitoso, nuevo saldo: {saldo}");
            OtraOperacion();
        }
    }
    
    

                void Salir()
                {
                    Console.WriteLine(@"=======================================================
GRACIAS POR USAR NUESTROS SERVICIOS 
==================================");
                    Environment.Exit(0);
                }
            


            void OtraOperacion()
            {
                Console.WriteLine("Desea realizar otra operacion? 1(si)  2(no)");
                int respuesta = Convert.ToInt32(Console.ReadLine());

                if (respuesta == 1)
                {
                    menu();
                }
                else
                {
                  Salir();
                }
            }
        
            static void Main(string[] args)
            {
                CajeroAutomatico cajero = new CajeroAutomatico();
                cajero.menu();

            }
        }
        
    
       





                
        