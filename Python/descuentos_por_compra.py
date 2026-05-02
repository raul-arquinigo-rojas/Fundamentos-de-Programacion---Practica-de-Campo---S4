# ENTRADA
# Obteniendo datos del monto de compra
print("Ingrese el monto de la compra: ")
monto_compra = float(input())
# Obteniendo datos del tipo de cliente
print("Seleccione el tipo de clinte (1=VIP, 2=Regular): ")
tipo_cliente = int(input())
# PROCESO
# Validacion de tipo de cliente VIP
if tipo_cliente == 1:
    # Calculo de descuento para cliente VIP
    if monto_compra <= 100:
        descuento = monto_compra * 10 / 100
        monto_final = monto_compra - descuento
        # SALIDA
        # Mostrando los resultados obtenidos
        print("Cliente VIP")
        print("Descuento Aplicado: s/.", descuento)
        print("Monto Final a pagas: s/. ", monto_final)
    else:
        # Calculo de descuento para cliente VIP
        descuento = monto_compra * 20 / 100
        monto_final = monto_compra - descuento
        # SALIDA
        # Mostrando los resultados obtenidos
        print("Cliente VIP")
        print("Descuento Aplicado: s/.", descuento)
        print("Monto Final a pagas: s/. ", monto_final)
else:
    # Validacion de tipo de cliente REGULAR
    if tipo_cliente == 2:
        # Calculo de descuento para cliente Regular
        if monto_compra <= 200:
            descuento = monto_compra * 5 / 100
            monto_final = monto_compra - descuento
            # SALIDA
            # Mostrando los resultados obtenidos
            print("Cliente Regular")
            print("Descuento Aplicado: s/.", descuento)
            print("Monto Final a pagas: s/. ", monto_final)
        else:
            # Calculo de descuento para cliente Regular
            descuento = monto_compra * 10 / 100
            monto_final = monto_compra - descuento
            # SALIDA
            # Mostrando los resultados obtenidos
            print("Cliente Regular")
            print("Descuento Aplicado: s/.", descuento)
            print("Monto Final a pagas: s/. ", monto_final)
    else:
        # Mensaje en caso que no se elija tipo de cliente admitido
        print("EROR... !Seleccione un tipo de cliente valido!")
