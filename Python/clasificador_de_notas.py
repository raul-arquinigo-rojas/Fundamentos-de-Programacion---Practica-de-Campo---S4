print('Ingrese la nota del estudiante: ')
nota = float(input())
if nota >= 11:
    if nota == 20:
        print('Excelente')
    else:
        print('Aprobado')
else:
    print('Desaprobado')