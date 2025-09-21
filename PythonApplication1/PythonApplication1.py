metodoPago=input("Ingrese el Metodo de Pago a realizar (EFECTIVO/TARJETA): ").upper()

if metodoPago == "EFECTIVO":
    print("Ha elegido pagar con efectivo. Se le otorgara un 5% de descuento")

elif metodoPago == "TARJETA":
    tipoTarjeta = input("Ingrese el tipo de tarjeta (CREDITO/DEBITO): ").upper()
    
    if tipoTarjeta == "CREDITO":
        tipoTarjeta = print("Se le otorgara un 7% de descuento")
    elif tipoTarjeta == "DEBITO":
        tipoTarjeta = print("Se le otorgara un 10& de descuento")
    else:
        print ("Tipo de Tarjeta no valido!!!")

else:
    print("Metodo de Pago no Valido!!!")


    