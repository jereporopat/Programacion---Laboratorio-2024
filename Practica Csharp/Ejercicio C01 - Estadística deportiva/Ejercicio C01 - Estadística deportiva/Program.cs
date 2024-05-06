using Ejercicio_C01___Estadística_deportiva;
// Crear un proyecto de biblioteca de clases que contenga las clases Jugador y Equipo:
//Clase Jugador
//Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
//El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
//MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
//Dos jugadores serán iguales si tienen el mismo DNI.
//Clase Equipo
//La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
//La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún en el equipo y la cantidad de 
//    jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
//Crear un proyecto de consola y generar las invocaciones necesarias en el método Main para probar el código.

Equipo equipo = new Equipo(2, "hola");
Jugador j1 = new Jugador(123, "juan", 1, 20);
Jugador j2 = new Jugador(485, "pepe", 7, 15);
Jugador j3 = new Jugador(123, "carlos", 5, 3);
Jugador j4 = new Jugador(789, "louis", 3, 5);

if (equipo + j1)
    Console.WriteLine(j1.MostrarDatos());

if (equipo + j2)
    Console.WriteLine(j2.MostrarDatos());

if (equipo + j3)
    Console.WriteLine(j3.MostrarDatos());
else
    Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

if (equipo + j4)
    Console.WriteLine(j4.MostrarDatos());

else
    Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());