#RETO INTERGRADOR
#Declaración de variables
suma = 0
contador = 0
cat1 = 0
cat2 = 0    
cat3 = 0
cat4 = 0
#Solicitando notas al usuario
while True:
    nota = int(input("Ingrese la nota del estudiante de 0 al 20 o (-1 paran Terminar): "))
    #Validando que las notas esten dentro del rango solicitado	
    if nota >= 0 and nota <= 20:
        suma = suma + nota
        contador = contador + 1
        promedio = suma / contador
        #Obtencion de cantidad de notas por categoria
        if nota >= 0 and nota <= 10:
            cat1 = cat1 + 1
        elif nota >= 11 and nota <= 13:
            cat2 = cat2 + 1
        elif nota >= 14 and nota <= 16:
            cat3 = cat3 + 1
        else:
            cat4 = cat4 + 1
        #Obtencion de la nota mas alta y mas baja
        if contador == 1:
            mayor = nota
            menor = nota
        else:
            if nota > mayor:
                mayor = nota
            if nota < menor:
                menor = nota
    elif nota != -1:
        print("ERROR: INGRESE UNA NOTA VALIDA")       
    if nota == -1:
        break
            
#Resultados
print("----------------")
print("RESULTADOS")
print("----------------")
print("Total de notas: ", contador)
print("Promedio: ", promedio)
print("----------------")
print("Nota más alta: ", mayor)
print("Nota más baja: ", menor)
print("----------------")
print("Desaprobado (0-10): ", cat1)
print("Aprobado (11-13): ", cat2)
print("Bueno (14-16): ", cat3)
print("Exlente (17-20): ", cat4)
