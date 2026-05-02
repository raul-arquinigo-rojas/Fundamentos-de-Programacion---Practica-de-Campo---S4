// Algoritmo descuentos_por_compra
// ENTRADA
// Obteniendo datos del monto de compra
Console.WriteLine("Ingrese el monto de la compra: ");
double monto_compra = double.Parse(Console.ReadLine());
// Obteniendo datos del tipo de cliente
Console.WriteLine("Seleccione el tipo de clinte (1=VIP, 2=Regular): ");
int tipo_cliente = int.Parse(Console.ReadLine());
// PROCESO
// Validacion de tipo de cliente VIP
if (tipo_cliente == 1)
{
    // Calculo de descuento para cliente VIP 
    if (monto_compra <= 100)
    {
        double descuento = monto_compra * 10 / 100;
        double monto_final = monto_compra - descuento;
        // SALIDA
        // Mostrando los resultados obtenidos
        Console.WriteLine("Cliente VIP");
        Console.WriteLine("Descuento Aplicado: s/." + descuento);
        Console.WriteLine("Monto Final a pagas: s/. " + monto_final);
    }
    else
    {
        // Calculo de descuento para cliente VIP
        double descuento = monto_compra * 20 / 100;
        double monto_final = monto_compra - descuento;
        // SALIDA
        // Mostrando los resultados obtenidos
        Console.WriteLine("Cliente VIP");
        Console.WriteLine("Descuento Aplicado: s/." + descuento);
        Console.WriteLine("Monto Final a pagas: s/. " + monto_final);
    }
}
else
{
    // Validacion de tipo de cliente REGULAR
    if (tipo_cliente == 2)
    {
        // Calculo de descuento para cliente Regular
        if (monto_compra <= 200)
        {
            double descuento = monto_compra * 5 / 100;
            double monto_final = monto_compra - descuento;
            // SALIDA
            // Mostrando los resultados obtenidos
            Console.WriteLine("Cliente Regular");
            Console.WriteLine("Descuento Aplicado: s/." + descuento);
            Console.WriteLine("Monto Final a pagas: s/. " + monto_final);
        }
        else
        {
            // Calculo de descuento para cliente Regular
            double descuento = monto_compra * 10 / 100;
            double monto_final = monto_compra - descuento;
            // SALIDA
            // Mostrando los resultados obtenidos
            Console.WriteLine("Cliente Regular");
            Console.WriteLine("Descuento Aplicado: s/." + descuento);
            Console.WriteLine("Monto Final a pagas: s/. " + monto_final);
        }
    }
    else
    {
        // Mensaje en caso que no se elija tipo de cliente admitido
        Console.WriteLine("EROR... !Seleccione un tipo de cliente valido!");
    }
}
