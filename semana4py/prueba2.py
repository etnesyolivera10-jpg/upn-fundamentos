print("===Menú de operciones===")
print("1. Calcular área de un ciculo")
print("2.Calcular área de un cuadrado")
print("3. Calcular área de un triagulo")
print("4. salir")
opcion= int(input("seleccione una opcion 1-4: "))

match opcion:
    case 1:
        print("elegistes circulo")
        print("Area del circulo= pi* r2")
        radio=int(input("cual es el area"))
        area= (radio*2) * 3.14
        print(f"el resultado es {area}")

        