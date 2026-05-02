// Algoritmo n_num_con_mientras
// ENTRADA 
// obtener datos de cantidad de numeros que el usaurio desear sumar
Console.WriteLine("Ingrese la cantidad de numeros que desea sumar");
int n = int.Parse(Console.ReadLine());
int contador = 1;
double suma = 0;
double mayor = 0, menor = 0;

// PROCESO 
// Validacion de cantidad de numeros a sumar
if (n > 0)
{
    while (contador <= n)
    {
        // Entrada de numeros para la suma
        Console.WriteLine("Ingrese el numero");
        double numero = double.Parse(Console.ReadLine());
        // Calculo de la suma
        suma = suma + numero;
        // Validacion si el numero es mayor o menor
        if (contador == 1)
        {
            mayor = numero;
            menor = numero;
        }
        else
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
        }
        // Actualizacion del contador
        contador = contador + 1;
    }
    // Calculo de promedio
    double promedio = suma / n;
    // SALIDA
    // Mostrando los resultados obtenidos	
    Console.WriteLine("Cantidad de numeros: " + n);
    Console.WriteLine("Suma Total: " + suma);
    Console.WriteLine("Promedio: " + promedio);
    Console.WriteLine("Numero Mayor: " + mayor);
    Console.WriteLine("Numero Menor: " + menor);
}
else
{
    Console.WriteLine("ERROR: La cantidad de numero debe ser mayor que 0");
}
