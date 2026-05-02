// Algoritmo reto_integrador	
//DECLARACION DE VARIABLES
double suma = 0;
int contador = 0;
int cat1 = 0;
int cat2 = 0;
int cat3 = 0;
int cat4 = 0;
double nota;
double promedio = 0;
double mayor = 0, menor = 0;

// Solicitando notas al usuario
do
{
    Console.WriteLine("Ingrese la nota del estudiante de 0 al 20 o (-1 paran Terminar)");
    nota = double.Parse(Console.ReadLine());
    // Validando que las notas esten dentro del rango solicitado		
    if (nota >= 0 && nota <= 20)
    {
        suma = suma + nota;
        contador = contador + 1;
        promedio = suma / contador;
        // Obtencion del cantidad de notas por categoria
        // Desaprobado
        if (nota >= 0 && nota <= 10)
        {
            cat1 = cat1 + 1;
        }
        else
        {
            // Aprobado
            if (nota >= 11 && nota <= 13)
            {
                cat2 = cat2 + 1;
            }
            else
            {
                // Bueno
                if (nota >= 14 && nota <= 16)
                {
                    cat3 = cat3 + 1;
                }
                else
                {
                    // Excelente
                    cat4 = cat4 + 1;
                }
            }
        }
        // Obtencion de la nota mas alta y mas baja
        if (contador == 1)
        {
            mayor = nota;
            menor = nota;
        }
        else
        {
            if (nota > mayor)
            {
                mayor = nota;
            }
            if (nota < menor)
            {
                menor = nota;
            }
        }
    }
    else
    {
        // Mensaje de error cuando la nota es invalida
        if (nota != -1)
        {
            Console.WriteLine("ERROR: INGRESE UNA NOTA VALIDA");
        }
    }
} while (nota != -1);



Console.WriteLine("---------------------");
Console.WriteLine("RESULTADOS");
Console.WriteLine("---------------------");
Console.WriteLine("Total de Notas: " + contador);
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("---------------------");
Console.WriteLine("Nota mas alta: " + mayor);
Console.WriteLine("Mota mas baja: " + menor);
Console.WriteLine("---------------------");
Console.WriteLine("Desaprobado (0-10): " + cat1);
Console.WriteLine("Aprobado (11-13): " + cat2);
Console.WriteLine("Bueno (14-16): " + cat3);
Console.WriteLine("Excelente (17-20): " + cat4);
