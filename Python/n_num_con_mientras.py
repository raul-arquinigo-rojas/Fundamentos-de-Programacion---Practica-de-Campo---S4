# Algoritmo n_num_con_mientras
# ENTRADA
# obtener datos de cantidad de numeros que el usaurio desear sumar
print("Ingrese la cantidad de numeros que desea sumar")
n = int(input())
contador = 1
suma = 0
# PROCESO
# Validacion de cantidad de numeros a sumar
if n > 0:
    while contador <= n:
        # Entrada de numeros para la suma
        print("Ingrese el numero")
        numero = float(input())
        # Calculo de la suma
        suma = suma + numero
        # Validacion si el numero es mayor o menor
        if contador == 1:
            mayor = numero
            menor = numero
        else:
            if numero > mayor:
                mayor = numero
            if numero < menor:
                menor = numero
        # Actualizacion del contador
        contador = contador + 1
    # Calculo de promedio
    promedio = suma / n
    # SALIDA
    # Mostrando los resultados obtenidos
    print("Cantidad de numeros: ", n)
    print("Suma Total: ", suma)
    print("Promedio: ", promedio)
    print("Numero Mayor: ", mayor)
    print("Numero Menor: ", menor)
else:
    print("ERROR: La cantidad de numero debe ser mayor que 0")
