//Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
//El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
//Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
//Mostrar el resultado en la consola.

double basee;
double altura;
double longitudHipotenusaAlCuadrado;
double longitudHipotenusa;

Console.WriteLine("Ingrese la base del triangulo: ");
basee = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese altura del triangulo: ");
altura = Convert.ToDouble(Console.ReadLine());

longitudHipotenusaAlCuadrado = Math.Pow(basee,2) + Math.Pow (altura,2);

longitudHipotenusa = Math.Sqrt(longitudHipotenusaAlCuadrado);

Console.WriteLine($"La longitud de la hipotenusa es de: {longitudHipotenusa}");
