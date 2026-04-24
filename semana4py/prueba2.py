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
        area= (radio*radio) * 3.14
        print(f"el resultado es {area}")
    case 2:
        print("eligistes cuadrado")
        print("area del cuadrado= lado")
        lado=int(input("cuantos metros tiene un lado"))
        area=lado*lado
        print(f"el area del cuadrado es {area}")
    case 3:
        print("elegistes triágulo")
        print("Area del triangulo = (base x altura) / 2")
        base=int(input("Cual es la base"))
        altura=int(input("cual es la altura"))
        area=(base*altura) /2
    case 4:
        print("saliendo del programa....")
        exit
    case _:
        print("Opción invalida. Ingresa un número del 1 al 4.")
        


        