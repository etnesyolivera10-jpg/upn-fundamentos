promedio= int(input("pon el promedio del estudiante"))
if(promedio <=5):
    print(f"su promedio fue de {promedio} tuvo la clasificacion de deficiente")
elif(promedio<=10):
    print(f"su promedio fue de {promedio} tuvo la clasificacion de regular")
elif(promedio <=14):
    print(f"su promedio fue de {promedio} tuvo la clasificacion de bueno")
elif(promedio <=20):
    print(f"su promedio fue de {promedio}tuvo la clasificacion de excelente")
else:
    print("valor invalido")
