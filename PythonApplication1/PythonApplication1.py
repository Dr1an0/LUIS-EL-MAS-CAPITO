tipo_pago = ""
tipo_tarjeta = ""
recargo = 0.0
descuento = 0.0
dia = ""
monto_inicial = 0.0
precio = 0.0
cantidad = 0
monto_final = 0.0

cantidad = int(input("Ingrese la cantidad de productos: "))
precio = float(input("Ingrese el precio unitario: "))
tipo_pago = input("Ingrese el tipo de pago (EFECTIVO / TARJETA / BILLETERA DIGITAL): ").upper()

monto_inicial = cantidad * precio

if tipo_pago == "EFECTIVO":
    if cantidad > 3:
        descuento = monto_inicial * 0.10
elif tipo_pago == "TARJETA":
    tipo_tarjeta = input("Ingrese el tipo de tarjeta (CRÉDITO/DÉBITO): ").upper()

