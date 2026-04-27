Algoritmo menu_de_calculadora
	// Ingresar Datos
	Escribir "Ingrese el primer número:"
	Leer num1
	Escribir "Ingrese el segundo número:"
	Leer num2		
	// Menú de operaciones
	Escribir "Seleccione una operación (1=Suma, 2=Resta, 3=Multiplicación, 4=División):"
	Leer operador		
	// Estructura Según para procesar la operación
	Segun operador Hacer
		1:
			resultado <- num1 + num2
			Escribir "El resultado de la suma es: ", resultado
		2:
			resultado <- num1 - num2
			Escribir "El resultado de la resta es: ", resultado
		3:
			resultado <- num1 * num2
			Escribir "El resultado de la multiplicación es: ", resultado
		4:
			// Validacion del divisor de 0
			Si num2 <> 0 Entonces
				resultado <- num1 / num2
				Escribir "El resultado de la división es: ", resultado
			Sino
				Escribir "Error: No se puede dividir entre cero."
			FinSi
		De Otro Modo:
			Escribir "Operación no válida."
	FinSegun
FinAlgoritmo
