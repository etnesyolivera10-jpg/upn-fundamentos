edad=int(input("Ingrese su edad"))
if(edad <18):
    falta=18 -edad
    print("acceso denegado")
    print(f"te faltan {falta} año(s)para registrarte.")
else:
    print("Acceso permitido. Bienvenido.")