// Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos)
// di
//Mostrar la colección tal como fue cargada.
//Luego mostrar los positivos ordenados en forma decreciente.
//Por último, mostrar los negativos ordenados en forma creciente.


List<int> lista = new List<int>();
Stack<int> pila = new Stack<int>();
Queue<int> cola = new Queue<int>();
Random rand = new Random();

for (int i = 0; i < 20; i++)
{
    int num = rand.Next(-100, 101);
    while (num == 0 || lista.Contains(num))
    {
        num = rand.Next(-100, 101);
    }
    lista.Add(num);
    pila.Push(num);
    cola.Enqueue(num);
}
Console.WriteLine("Lista:");
foreach (var item in lista)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine();

Console.WriteLine("Pila:");
foreach (var item in pila)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine();

Console.WriteLine("Cola:");
foreach (var item in cola)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine();

Console.WriteLine("Numeros positivos ordenados de forma decreciente:");
lista.Sort(PositivoOrdenDecreciente);
foreach (var item in lista)
{
    if (item > 0)
    {
        Console.WriteLine(item + " ");
    }   
}
Console.WriteLine();

Console.WriteLine("Numeros negativos ordenados de forma creciente:");
lista.Sort(NegativosOrdenCreciente);
foreach (var item in lista)
{
    if (item < 0)
    {
        Console.WriteLine(item + " ");
    }
}

static int PositivoOrdenDecreciente(int a, int b)
{
    return b - a;
}
static int NegativosOrdenCreciente (int a, int b)
{
    return a - b;
}
