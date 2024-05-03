using Ejercicio_A02___La_veterinaria2;

Cliente cliente1 = new Cliente("Alvarez", "jere", "porop", 112233, 1);
cliente1.mascotas[0] = new Mascota("perro", "juan", new DateTime(2020, 8, 15), 0);

Cliente cliente2 = new Cliente("laprida", "Jaime", "Lui", 558899, 1);
Mascota gato1 = new Mascota("gato", "siro", new DateTime(1998, 8, 15), 1);
gato1.historialDeVacunacion[0] = "Triple felina";
cliente2.mascotas[0] = gato1;

Cliente cliente3 = new Cliente("Oliden", "Pepe", "Cumo", 77889944, 2);
cliente3.mascotas[0] = new Mascota("gato", "pepe", DateTime.Now, 0);
Mascota perro2 = new Mascota("perro", "marulo", DateTime.Now, 1);
perro2.historialDeVacunacion[0] = "Antirabia";
cliente3.mascotas[1] = perro2;


Console.WriteLine("Datos: ");
Console.WriteLine(Mostrar.MostrarCliente(cliente1));
Console.WriteLine(Mostrar.MostrarCliente(cliente2));
Console.WriteLine(Mostrar.MostrarCliente(cliente3));
