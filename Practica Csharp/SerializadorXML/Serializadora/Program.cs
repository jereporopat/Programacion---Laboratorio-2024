using EntidadesSerializadorXML;

try
{
    Personaje pj1 = new Personaje("Cavani", 9);

    //Serializadora.Escribir(pj1);

    Console.WriteLine(Serializadora.Leer().ToString());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}