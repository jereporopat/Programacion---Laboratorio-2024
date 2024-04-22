//El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros
//positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
//En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.

int numero;
string buffer;
bool estado;

Console.WriteLine("Ingrese numero para calcular factorial: ");
buffer = Console.ReadLine();
estado = int.TryParse(buffer, out numero);

int factorial = Ejercicio_A01___Calcular_un_factorial.CalcularFact.factorial(numero);

Console.WriteLine($"El factoria del numero {numero} es {factorial}");