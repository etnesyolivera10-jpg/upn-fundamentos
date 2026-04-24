parcial=int(input("ingrese examen parcial  "))
final=int(input("ingrese el examen final " ))
p1=int(input("ingrese practica 1 "))
p2=int(input("ingrese practica 2 "))
p3=int(input("ingrese practica 3 "))

prom_prac=(p1+p2+p3 - min(p1,p2,p3))/2
prom_final=(parcial+final+prom_prac)/3

print(f"promedio de practicas :{prom_prac}")
print(f"promedio final: {prom_final}")

if(prom_final >=18):
    print("excelente")
elif(prom_final>=14):
    print("bueno")
elif(prom_final>=10):
    print("regular")
else:
    print("deficiente")
