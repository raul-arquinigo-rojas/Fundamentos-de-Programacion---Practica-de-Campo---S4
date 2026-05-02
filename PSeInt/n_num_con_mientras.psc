Algoritmo n_num_con_mientras
	//ENTRADA 
	//obtener datos de cantidad de numeros que el usaurio desear sumar
	Escribir "Ingrese la cantidad de numeros que desea sumar"
	Leer n
	contador = 1
	suma = 0	
	//PROCESO 
	//Validacion de cantidad de numeros a sumar
	Si n > 0 Entonces
		Mientras contador <= n Hacer
			//Entrada de numeros para la suma
			Escribir "Ingrese el numero"
			Leer numero
			// Calculo de la suma
			suma = suma + numero
			//Validacion si el numero es mayor o menor
			Si contador == 1 Entonces			
				mayor = numero
				menor = numero
			SiNo
				Si numero > mayor Entonces
					mayor = numero
				FinSi
				Si numero < menor Entonces
					menor = numero 
				FinSi
			FinSi
			//Actualizacion del contador
			contador = contador + 1		
		FinMientras
		//Calculo de promedio
		promedio = suma/n
		//SALIDA
		//Mostrando los resultados obtenidos	
		Escribir "Cantidad de numeros: ", n
		Escribir "Suma Total: ", suma
		Escribir "Promedio: ", promedio
		Escribir "Numero Mayor: ", mayor
		Escribir "Numero Menor: ", menor
	SiNo
		Escribir "ERROR: La cantidad de numero debe ser mayor que 0"		
	FinSi		
FinAlgoritmo
