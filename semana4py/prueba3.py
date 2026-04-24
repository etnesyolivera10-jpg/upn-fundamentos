peso=float(input("ingrese el peso en kg: "))
estatura= float(input("ingrese la estatura en metros: "))
imc= peso / (estatura ** 2)
imc_red = round(imc,2)
print(f"IMC:{imc_red}")
if imc < 18.5:
    print("bajo peso")
elif imc <25:
    print("normal")
elif imc <30:
    print("sobrepeso ")
else:
    print("obesidad")

