//Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
//Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
//El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

int numero;
int sum = 0;
string mensaje;
bool esValido;

string buffer;
bool estado;

do
{
    Console.WriteLine("Ingrese un numero: ");
    buffer = Console.ReadLine();
    estado = int.TryParse(buffer, out numero);

    sum += numero;

    Console.WriteLine("Desea continuar? (S/N)");
    mensaje = Console.ReadLine();

} while (esValido = Validador.Validador.ValidarRespuesta(mensaje));

Console.WriteLine($"La suma de los numeros ingresados es de {sum}");