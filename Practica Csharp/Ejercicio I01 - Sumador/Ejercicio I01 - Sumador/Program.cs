//Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.
//Crear dos constructores:
//Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
//Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
//El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
//En el caso de Sumar(long, long) sumará los valores numéricos
//En el de Sumar(string, string) concatenará las cadenas de texto.
//Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.
//Seguido:
//Generar una conversión explícita que retorne cantidadSumas.
//Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de 
//la suma del atributo cantidadSumas de cada argumento.
//Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor
//en el atributo cantidadSumaAgregar un segundo objeto del tipo Sumador en el método Main y probar el código.Crear dos constructores:
//Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
//Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
//El método Sumar incrementará cantidadSumas en 1  y adicionará sus parámetros con la siguiente lógica:
//En el caso de Sumar(long, long) sumará los valores numéricos
//En el de Sumar(string, string) concatenará las cadenas de texto.
//Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.
//Seguido:
//Generar una conversión explícita que retorne cantidadSumas.
//Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
//Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
//Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.

using Clases;

Sumador sumador1 = new Sumador();
Sumador sumador2 = new Sumador(5);

sumador1.Sumar(10, 20);
sumador1.Sumar("Hola ", "mundo");

Console.WriteLine("Cantidad de sumas en sumador1: " + (int)sumador1);
Console.WriteLine("Cantidad de sumas en sumador2: " + (int)sumador2);

Console.WriteLine("Resultado de la suma de sumador1 y sumador2: " + (sumador1 + sumador2));

if (sumador1 | sumador2)
{
    Console.WriteLine("Ambos sumadores tienen la misma cantidad de sumas.");
}
else
{
    Console.WriteLine("Los sumadores tienen distinta cantidad de sumas.");
}