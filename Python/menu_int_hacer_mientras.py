# Algoritmo menu_int_hacer_mientras
while True:
    # Mostrar menu
    print("Selecciones una de las opciones")
    print("1-Suma")
    print("2-Resta")
    print("3-Multiplicacion")
    print("4-Division")
    print("5-Salir")
    # Leer opcion
    opcion = int(input())
    # Validacion de la opcion elejida y obtencion de numeros
    if opcion >= 1 and opcion <= 4:
        print("Ingrese el primer numero")
        numero1 = float(input())
        print("Ingrese el segundo numero")
        numero2 = float(input())

    # Validacion de opcion elejida y desarrollo de las respectivas operaciones
    match opcion:
        case 1:
            suma = numero1 + numero2
            print("Suma: ", suma)
        case 2:
            resta = numero1 - numero2
            print("Resta: ", resta)
        case 3:
            producto = numero1 * numero2
            print("Multiplicacion: ", producto)
        case 4:
            division = numero1 / numero2
            print("Division: ", division)
        case 5:
            print("Adiós")
        case _:
            print("ERROR: Igrese una opcion valida")

    if opcion >= 1 and opcion <= 5:
        break

