Console.WriteLine("Ingrese su peso en kg: ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su altura en metros: ");
float altura = float.Parse(Console.ReadLine());

if (peso >= 5 && peso <= 400)
{
    if (altura >= 0.5 && altura <= 2.5)
    {
    float imc = peso / (altura * altura);
    Console.WriteLine("Su IMC es: " + imc);
    if (imc < 18.5)
    {
        Console.WriteLine("Bajo peso");
    }
    else if (imc >= 18.5 && imc < 25)
    {
        Console.WriteLine("Peso normal");
    }
    else if (imc >= 25 && imc < 30)
    {
        Console.WriteLine("Sobrepeso");
    }
    else
    {
        Console.WriteLine("Obesidad");
    }
    }
    else
    {
        Console.WriteLine("Altura Invalida");
    }
}
else
{
    Console.WriteLine("Altura Invalidao");
}