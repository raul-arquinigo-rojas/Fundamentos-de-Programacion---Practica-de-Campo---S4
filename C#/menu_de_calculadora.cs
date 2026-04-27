Console.WriteLine("Ingrese el primer numero: ");
float num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
float num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Selecciones un operador (1=Suma, 2=Resta, 3=Multiplicacion, 4=Division): ");
int operador = int.Parse(Console.ReadLine());
float resultado = 0; 
    switch (operador)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es:" + resultado);
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            break;
        case 4:
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la division es: " + resultado);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero");
            }
            break;
        default:
            Console.WriteLine("Operador no valido");
            break;
    }
