Algoritmo menu_int_hacer_mientras
	Repetir
		//Mostrar menu
		Escribir "Selecciones una de las opciones"
		Escribir "1-Suma"
		Escribir "2-Resta"
		Escribir "3-Multiplicacion"
		Escribir "4-Division"
		Escribir "5-Salir"
		//Leer opcion
		Leer opcion	
		//Validacion de la opcion elejida y obtencion de numeros
		Si opcion >= 1 Y opcion <= 4
			Escribir "Ingrese el primer numero"
			Leer numero1
			Escribir "Ingrese el segundo numero"
			Leer numero2
		FinSi
		//Validacion de opcion elejida y desarrollo de las respectivas operaciones
		Segun opcion			
			1:	
				suma = numero1 + numero2
				Escribir "Suma: ", suma
			2:
				resta = numero1 - numero2
				Escribir "Resta: ", resta
			3:
				producto = numero1 * numero2
				Escribir "Multiplicacion: ", producto				
			4: 
				division = numero1 / numero2
				Escribir "Division: ", division
			5:
				Escribir "Adiós"
			Otro: 
				Escribir "ERROR: Igrese una opcion valida"				
		FinSegun
	Hasta Que (opcion>=1 Y opcion<=5)	
FinAlgoritmo
