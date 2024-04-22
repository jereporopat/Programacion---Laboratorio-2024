using Clases;
//Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.
//Deberá tener los atributos:
//nombre
//fechaDeNacimiento
//dni
//Deberá tener un constructor que inicialice todos los atributos.
//Construir los siguientes métodos para la clase:
//Setter y getter para cada uno de los atributos.
//CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
//Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
//EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
//Instanciar 3 objetos de tipo Persona en el método Main.
//Mostrar quiénes son mayores de edad y quiénes no.

Persona persona1 = new Persona("Pepe", new DateTime(2000, 5, 15), "11458987");
Persona persona2 = new Persona("Juan", new DateTime(2017, 6, 23), "87523641");
Persona persona3 = new Persona("Lucio", new DateTime(1999, 1, 2), "45896235");

Console.WriteLine("Las personas son: ");
Console.WriteLine(Persona.Mostrar(persona1));
Console.WriteLine(Persona.Mostrar(persona2));
Console.WriteLine(Persona.Mostrar(persona3));

