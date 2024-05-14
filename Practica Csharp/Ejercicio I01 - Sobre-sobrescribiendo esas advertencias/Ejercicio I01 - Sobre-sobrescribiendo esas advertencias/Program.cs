//Crear un proyecto de consola que contenga la clase Sobrescrito.
//Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
//Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la misma clase),
//false caso contrario.
//Sobrescribir el método GetHashCode para que retorne el número 1142510181.
//Agregar en el método Main el siguiente código:

using Ejercicio_I01___Sobre_sobrescribiendo_esas_advertencias;

Console.Title = "Ejercicio Sobre-Sobrescrito";
Sobrescrito objetoSobrescrito = new Sobrescrito();

Console.WriteLine(objetoSobrescrito.ToString());

string objeto = "¡Este es mi método ToString sobrescrito!";

Console.WriteLine("----------------------------------------------");
Console.Write("Comparación Sobrecargas con String: ");
Console.WriteLine(objetoSobrescrito.Equals(objeto));

Console.WriteLine("----------------------------------------------");
Console.WriteLine(objetoSobrescrito.GetHashCode());

Console.ReadKey();