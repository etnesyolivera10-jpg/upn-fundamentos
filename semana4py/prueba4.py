cat = input("categoria (A/B/C): "). upper()
horas = float(input("horas:"))
anios = float(input("años de servicio :"))

if cat == "A": tarifa =33.50
elif cat == "B": tarifa = 29.80
elif cat == "C": tarifa =25.70
else: print("categoria invalida") ;exit()

if anios <=3: bono = 0.00
elif anios <= 10: bono =0.10
elif anios <=17: bono = 0.20
else: bono = 0.30
print(f"sueldo: s/. {tarifa * horas*(1+bono):.2f}")