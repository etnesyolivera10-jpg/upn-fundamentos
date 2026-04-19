monto = float(input("Ingrese el monto de la compra s/"))
descuento = 0

if monto >=100:
    descuento= monto*0.10

total= monto - descuento

print(f"el descunto aplicado {round(descuento,2)}")
print(f"total a pagar: s/. {round(total,2)}")