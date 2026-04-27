Algoritmo calculadora_imc
	Escribir 'Ingrese su peso en KG: '
	Leer peso
	Escribir 'Ingrese su altura en metros: '
	Leer altura
	//leer datos de entrada
	//validad el peso <= 400 y >=5
	Si peso <= 400 Y peso >= 0 Entonces
		Si altura <= 2.5 Y peso >= 0.5 Entonces
			imc = peso/altura^2
			Escribir "Tu IMC es: " imc
			Si imc <= 18.5 Entonces
				Escribir "Bajo Peso"
			SiNo
				Si imc >= 18.5 Y  imc < 25 Entonces
					Escribir "Peso normal"
				SiNo
					Si imc >= 25 Y  imc < 30 Entonces
						Escribir "Sobrepeso"
					SiNo
						Si imc >= 30 Entonces
							Escribir "Obesidad"
						FinSi
					FinSi
				FinSi
			FinSi
		SiNo
			Escribir "Altura Invalida"			
		FinSi		
	SiNo
		Escribir "Peso Invalido"		
	FinSi		
FinAlgoritmo