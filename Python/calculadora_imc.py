#leer datos de entrada
print('Ingrese su peso en kg: ')
peso = float(input())
print('Ingrese su altura en metros: ')
altura = float(input()) 

#validad el peso <= 400 y >=5
if peso>=5 and peso<=400:
    #validar la altura <= 2.5 y >= 0.5
    if altura>=0.5 and altura<=2.5:
        #calcular el imc
        imc = peso / (altura ** 2)
        print('Tu IMC es: ', imc)

        #clasificar el imc
        if imc < 18.5:
            print('Bajo peso')
        elif imc >= 18.5 and imc < 25:
            print('Peso normal')
        elif imc >= 25 and imc < 30:
            print('Sobrepeso')
        elif imc >= 30:
            print('Obesidad')
    else:
        print('Altura Ivalidad')
else:
    print('Peso Ivalidado')