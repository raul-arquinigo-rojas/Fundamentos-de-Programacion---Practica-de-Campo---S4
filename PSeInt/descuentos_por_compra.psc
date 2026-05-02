Algoritmo descuentos_por_compra
	//ENTRADA
	//Obteniendo datos del monto de compra
	Escribir "Ingrese el monto de la compra: "
	Leer monto_compra
	//Obteniendo datos del tipo de cliente
	Escribir "Seleccione el tipo de clinte (1=VIP, 2=Regular): "
	Leer tipo_cliente
	//PROCESO
	//Validacion de tipo de cliente VIP
	Si (tipo_cliente = 1) Entonces
		//Calculo de descuento para cliente VIP 
		Si monto_compra <=100 Entonces
			descuento = monto_compra*10/100
			monto_final = monto_compra-descuento
			//SALIDA
			//Mostrando los resultados obtenidos
			Escribir "Cliente VIP"
			Escribir "Descuento Aplicado: s/.", descuento
			Escribir "Monto Final a pagas: s/. ", monto_final
		SiNo
			//Calculo de descuento para cliente VIP
			descuento = monto_compra*20/100
			monto_final = monto_compra-descuento
			//SALIDA
			//Mostrando los resultados obtenidos
			Escribir "Cliente VIP"
			Escribir "Descuento Aplicado: s/.", descuento
			Escribir "Monto Final a pagas: s/. ", monto_final
		FinSi			
	SiNo
		//Validacion de tipo de cliente REGULAR
		Si (tipo_cliente = 2) Entonces
			//Calculo de descuento para cliente Regular
			Si monto_compra <=200 Entonces
				descuento = monto_compra*5/100
				monto_final = monto_compra-descuento
				//SALIDA
				//Mostrando los resultados obtenidos
				Escribir "Cliente Regular"
				Escribir "Descuento Aplicado: s/.", descuento
				Escribir "Monto Final a pagas: s/. ", monto_final
			SiNo
				//Calculo de descuento para cliente Regular
				descuento = monto_compra*10/100
				monto_final = monto_compra-descuento
				//SALIDA
				//Mostrando los resultados obtenidos
				Escribir "Cliente Regular"
				Escribir "Descuento Aplicado: s/.", descuento
				Escribir "Monto Final a pagas: s/. ", monto_final
			FinSi		
		SiNo
			//Mensaje en caso que no se elija tipo de cliente admitido
			Escribir "EROR... !Seleccione un tipo de cliente valido!"
		FinSi				
	FinSi	
FinAlgoritmo
