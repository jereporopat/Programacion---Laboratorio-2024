// Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria
// utilizando la clase Random.
//Mostrar el vector tal como fue ingresado.
//Luego mostrar los positivos ordenados en forma decreciente.
//Por último, mostrar los negativos ordenados en forma creciente.

const int cantidadNumeros = 20;
int[] numeros = new int[cantidadNumeros];
Random rnd = new Random();

// Cargar números aleatorios
for (int i = 0; i < cantidadNumeros; i++)
{
    numeros[i] = rnd.Next(-100, 101); // Genera números aleatorios entre -100 y 100
    while (numeros[i] == 0) // Asegura que no se generen ceros
    {
        numeros[i] = rnd.Next(-100, 101);
    }
}

// Mostrar el vector tal como fue ingresado
Console.WriteLine("Vector ingresado:");
MostrarVector(numeros);

// Ordenar positivos en forma decreciente
Array.Sort(numeros, (x, y) => y.CompareTo(x));
int[] positivos = Array.FindAll(numeros, x => x > 0);

// Mostrar positivos ordenados en forma decreciente
Console.WriteLine("\nPositivos ordenados en forma decreciente:");
MostrarVector(positivos);

// Ordenar negativos en forma creciente
Array.Sort(numeros);
int[] negativos = Array.FindAll(numeros, x => x < 0);

// Mostrar negativos ordenados en forma creciente
Console.WriteLine("\nNegativos ordenados en forma creciente:");
MostrarVector(negativos);

    // Método para mostrar un vector
    static void MostrarVector(int[] vector)
{
    foreach (int num in vector)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}