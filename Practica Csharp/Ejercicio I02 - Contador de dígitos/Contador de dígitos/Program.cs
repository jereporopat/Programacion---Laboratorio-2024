using Contador_de_dígitos;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    string aux = Console.ReadLine();
    if(long.TryParse(aux, out var numero))
    {
        Console.WriteLine($"Cantidad de digitos {numero.ContarCantidadDeDigitos()}");
    }
}