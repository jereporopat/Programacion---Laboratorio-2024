using VeterinariaBibliotecaClases;
//El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar
//la lista de clientes y sus mascotas.
//De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar
//una o más mascotas.
//De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación.
//Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y se podrá
//ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.
//Consigna
//Crear una aplicación de consola.
//Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
//Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
//Instanciar los siguientes objetos:
//Un cliente con un perro sin vacunar.
//Un cliente con un gato con la vacuna "Triple Felina".
//Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
//Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.

// Instanciación de objetos
Cliente cliente1 = new Cliente("Juan", "Perez", "Calle 123", "555-123456", 1);
cliente1.Mascotas[0] = new Mascota("Perro", "Rocky", new DateTime(2019, 5, 10), 0);

Cliente cliente2 = new Cliente("Maria", "Gomez", "Av. Libertador 456", "555-789012", 1);
Mascota gato1 = new Mascota("Gato", "Minino", new DateTime(2020, 8, 15), 1);
gato1.AgregarVacuna("Triple Felina");
cliente2.Mascotas[0] = gato1;

Cliente cliente3 = new Cliente("Carlos", "Rodriguez", "Calle Principal 789", "555-345678", 2);
cliente3.Mascotas[0] = new Mascota("Gato", "Pelusa", new DateTime(2018, 3, 20), 0);
Mascota perro2 = new Mascota("Perro", "Toby", new DateTime(2017, 10, 5), 1);
perro2.AgregarVacuna("Rabia");
cliente3.Mascotas[1] = perro2;

// Mostrar por consola todos los datos de los clientes y sus mascotas
Console.WriteLine("Datos de los clientes y sus mascotas:");
Console.WriteLine("-------------------------------------");
Console.WriteLine(cliente1);
Console.WriteLine("-------------------------------------");
Console.WriteLine(cliente2);
Console.WriteLine("-------------------------------------");
Console.WriteLine(cliente3);
Console.WriteLine("-------------------------------------");