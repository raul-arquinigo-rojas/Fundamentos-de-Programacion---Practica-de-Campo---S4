// Algoritmo menu_int_hacer_mientras
int opcion;
double numero1 = 0, numero2 = 0;
do
{
    // Mostrar menu
    Console.WriteLine("Selecciones una de las opciones");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Multiplicacion");
    Console.WriteLine("4-Division");
    Console.WriteLine("5-Salir");
    // Leer opcion
    opcion = int.Parse(Console.ReadLine());
    // Validacion de la opcion elejida y obtencion de numeros
    if (opcion >= 1 && opcion <= 4)
    {
        Console.WriteLine("Ingrese el primer numero");
        numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        numero2 = double.Parse(Console.ReadLine());
    }
    // Validacion de opcion elejida y desarrollo de las respectivas operaciones
    switch (opcion)
    {
        case 1:
            double suma = numero1 + numero2;
            Console.WriteLine("Suma: " + suma);
            break;
        case 2:
            double resta = numero1 - numero2;
            Console.WriteLine("Resta: " + resta);
            break;
        case 3:
            double producto = numero1 * numero2;
            Console.WriteLine("Multiplicacion: " + producto);
            break;
        case 4:
            double division = numero1 / numero2;
            Console.WriteLine("Division: " + division);
            break;
        case 5:
            Console.WriteLine("Adiós");
            break;
        default:
            Console.WriteLine("ERROR: Igrese una opcion valida");
            break;
    }
} while (!(opcion >= 1 && opcion <= 5));
