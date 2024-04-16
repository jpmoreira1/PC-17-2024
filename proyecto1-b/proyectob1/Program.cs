using System;

/*
Proyecto 1-b
Pablo Moreira 1063124
*/
class Program
{
    static void Main(string[] args)
    {
        string tipoCuenta;
        string nombre;
        string dpi = ""; 
        string direccion;
        string telefono;
        double saldo = 2500.00;
        bool dpiValido = false;

        Console.WriteLine("Ingrese la información de la cuenta bancaria:");
        Console.Write("Tipo de cuenta (monetaria quetzales, monetaria dólares, ahorro quetzales, ahorro dólares): ");
        tipoCuenta = Console.ReadLine();
        Console.Write("Nombre: ");
        nombre = Console.ReadLine();

        while (!dpiValido)
        {
            Console.Write("Por favor ingresa tu DPI (5 dígitos): ");
            dpi = Console.ReadLine();

            if (dpi.Length == 5 && int.TryParse(dpi, out _))
            {
                dpiValido = true;
            }
            else
            {
                Console.WriteLine("El DPI debe contener exactamente 5 dígitos numéricos. Por favor intenta de nuevo.");
            }
        }

        Console.Write("Dirección: ");
        direccion = Console.ReadLine();
        Console.Write("Número de teléfono: ");
        telefono = Console.ReadLine();

        int opcion;
        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Ver información de la cuenta");
            Console.WriteLine("2. Comprar producto financiero");
            Console.WriteLine("3. Vender producto financiero");
            Console.WriteLine("4. Abonar a cuenta");
            Console.WriteLine("5. Simular paso del tiempo");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nInformación de la cuenta:");
                    Console.WriteLine($"Tipo de cuenta: {tipoCuenta}");
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"DPI: {dpi}"); 
                    Console.WriteLine($"Dirección: {direccion}");
                    Console.WriteLine($"Teléfono: {telefono}");
                    Console.WriteLine($"Saldo actual: Q {saldo}");
                    break;
                case 2:
                    saldo -= saldo * 0.10;
                    Console.WriteLine($"\nProducto financiero comprado. Saldo actual: Q {saldo}");
                    break;
                case 3:
                    if (saldo > 500)
                    {
                        saldo += saldo * 0.11;
                        Console.WriteLine($"\nProducto financiero vendido. Saldo actual: Q {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("\nNo es posible vender el producto financiero debido al saldo actual.");
                    }
                    break;
                case 4:
                    if (saldo < 500)
                    {
                        saldo *= 2;
                        Console.WriteLine($"\nAbono realizado. Saldo actual: Q {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("\nNo es posible abonar a la cuenta debido al saldo actual.");
                    }
                    break;
                case 5:
                    Console.Write("\nSeleccione el periodo de capitalización (1 para una vez al mes, 2 para dos veces al mes): ");
                    int periodo;
                    if (!int.TryParse(Console.ReadLine(), out periodo))
                    {
                        Console.WriteLine("Error: Por favor ingrese un número válido.");
                        break;
                    }
                    int dias = periodo * 30;
                    double interes = saldo * 0.02 * dias / 360;
                    saldo += interes;
                    Console.WriteLine($"Simulación del paso del tiempo realizada. Saldo actual: Q {saldo}");
                    break;
                case 6:
                    Console.WriteLine("\n¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 6);
    }
}
