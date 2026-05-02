Algoritmo reto_integrador	
	//Declaracion de variables
	suma = 0
	contador = 0
	cat1 = 0
	cat2 = 0
	cat3 = 0
	cat4 = 0
	//Solicitando notas al usuario
	Repetir
		Escribir "Ingrese la nota del estudiante de 0 al 20 o (-1 paran Terminar)"
		Leer nota		
		//Validando que las notas esten dentro del rango solicitado		
		Si nota >= 0 Y nota <=20 Entonces
			suma = suma + nota	
			contador = contador + 1
			promedio =  suma/contador
			//Obtencion del cantidad de notas por categoria
			//Desaprobado
			Si nota >=0 Y notA <=10 Entonces
				cat1 = cat1 + 1
			SiNo
				//Aprobado
				Si nota >=11 Y notA <=13 Entonces
					cat2 = cat2 + 1
				SiNo
					//Bueno
					Si nota >=14 Y notA <=16 Entonces
						cat3 = cat3 + 1
					SiNo
						//Excelente
						cat4 = cat4 + 1
					FinSi			
				FinSi		
			FinSi
			//Obtencion de la nota mas alta y mas baja
			Si contador == 1 Entonces
				mayor = nota
				menor = nota
			SiNo
				Si nota > mayor Entonces
					mayor = nota
				FinSi
				Si nota < menor Entonces
					menor = nota
				FinSi
			FinSi
		SiNo
			//Mensaje de error cuando la nota es invalida
			Si nota <> -1 Entonces
				Escribir "ERROR: INGRESE UNA NOTA VALIDA"				
			FinSi						
		FinSi			
	Hasta Que nota == -1	
	
	
	
	Escribir "---------------------"
	Escribir "RESULTADOS"
	Escribir "---------------------"
	Escribir "Total de Notas: ",contador
	Escribir "Promedio: ", promedio
	Escribir "---------------------"
	Escribir "Nota mas alta: ", mayor
	Escribir "Mota mas baja: ", menor
	Escribir "---------------------"
	Escribir "Desaprobado (0-10): " , cat1
	Escribir "Aprobado (11-13): " , cat2
	Escribir "Bueno (14-16): " , cat3
	Escribir "Excelente (17-20): " , cat4
	
	
	
FinAlgoritmo
