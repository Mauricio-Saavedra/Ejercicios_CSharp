# Aplicación de consola para el manejo de mascotas en adopción

En este sencillo ejercicio se crea una aplicación de terminal para la gestión de mascotas que esperan a encontrar un hogar.

En la aplicación se tienen 8 opciones en un menú principal.

```shell
Bienvenido a FindPets, elige una opción de nuestro menú principal:

 1. Lista todos los animales con su información.
 2. Añade un candidato a mascora a nuestra matriz.
 3. Corrobora que la edad y el estado físico de nuestros candidatos este completo.
 4. Corrobora que sus motes y personalidad esten completos.
 5. Edita la edad de un candidato.
 6. Edita la personalidad de un candidato.
 7. Muestra todos los gatos con una caracteristica espeifica.
 8. Muestra todos los perros con una caracteristica espeifica.

Ingresa el número de tu selección (o escribe 'exit' para salir).)
```

Al presionar un número de 1 al 8 se accede a la opción señalada, si el usuario escribe 'exit' el programa termina.

## Funcionamiento por opciones

1. Esta opción hace un listado de los animales que ya se encuentran bajo nuestro cuidado, se han puesto 4 animales en stock, 2 perros y 2 gatos, y uno de pestos últimos con datos faltantes para que pueda servir de ejemplo en futuras opciones.
2. Ésta opción te deja añadir un nuevo candidato preguntandote si es 'dog' o 'cat' (para abreviar), su edad, la cual de no saberse puede ser '?', su descripción física, su caracter y su mote; muchos datos pueden no saberse al momento de ingresar un candidato, por ello pueden ser valores nulos.
    - Hay un maximo de 8 espacios, una vez superado ese límite ya no permite ingresar más.
3. Te muestra en pantalla que candidatos referidos por su ID estan faltos de edad y estado físico.
4. Te muestra en pantalla que candidatos referidos por su ID estan faltos de mote y personalidad/caracter.
5. Permite editar la edad de un candidato ingresando su ID, también te muestra el nombre del mismo apra evitar el error de editar alguien por error, ya que solemos identificar más por nombre que por código.
6. Permite editar la personalidad/caracter de un candidato ingresando su ID, también te muestra el nombre del mismo apra evitar el error de editar alguien por error, ya que solemos identificar más por nombre que por código.
7. Permite realizar una busqueda por un rasgo, si hay un gato con 'x' caracteristica te dirá cual la tiene, si no, solo pregunta si quieres hacer otra busqueda.
8. Permite realizar una busqueda por un rasgo, si hay un perro con 'x' caracteristica te dirá cual la tiene, si no, solo pregunta si quieres hacer otra busqueda.
