from re import match

print('Ingrese el primer numero: ')
num1 = float(input())
print('Ingrese el segundo numero: ')
num2 = float(input())
print('Selecciones un operador (1=Suma, 2=Resta, 3=Multiplicacion, 4=Division): ')
operador = int(input())

match operador:
    case 1:
        resultado = num1 + num2
        print(f'El resultado de la suma es: {resultado}')
    case 2:
        resultado = num1 - num2
        print(f'El resultado de la resta es: {resultado}')
    case 3:
        resultado = num1 * num2
        print(f'El resultado de la multiplicacion es: {resultado}')
    case 4:
        if num2 != 0:
            resultado = num1 / num2
            print(f'El resultado de la division es: {resultado}')
        else:
            print('Error: No se puede dividir por cero')
    case _:
        print('Operador no valido')
