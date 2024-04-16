//Crear una aplicación de consola que permita al usuario ingresar un número entero.
//desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
//se deberá utilizar la clase stringbuilder combinada con strings interpolados para armar el resultado.
//mostrar en la consola el resultado.
//por ejemplo, si se ingresa el número 2 la salida deberá ser:

int numero;
string buffer;
bool estado;

Console.WriteLine("Ingrese numero: ");
buffer = Console.ReadLine();
estado = int.TryParse(buffer, out numero);

string resultado = tabl