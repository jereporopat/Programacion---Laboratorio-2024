using Serializadora;

try
{
    Mascota mascota = new Mascota("Momo", "Calle", 2, true, true, new List<string>() {"pollo", "empanadas", "papas fritas", "galles"});

    SerializadoraJson.Escribir(mascota);

    Console.WriteLine(SerializadoraJson.Leer().ToString());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}