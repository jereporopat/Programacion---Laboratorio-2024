//Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
//crear una clase llamada calculadora que posea dos métodos estáticos (de clase):
//calcular(público): recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
//El método devolverá el resultado de la operación.
//validar (privado): recibirá como parámetro el segundo operando. este método se debe utilizar sólo cuando la operación elegida
//sea la división. este método devolverá true si el operando es distinto de cero.
//se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
//el usuario decidirá cuándo finalizar el programa.

int numero1;
int numero2;
string operador;
string buffer;
bool estado;
string respuesta;

do
{
    Console.WriteLine("Ingrese numero 1: ");
    buffer = Console.ReadLine();
    estado = int.TryParse(buffer, out numero1);

    Console.WriteLine("Ingrese numero 2: ");
    buffer = Console.ReadLine();
    estado = int.TryParse(buffer, out numero2);

    Console.WriteLine("Ingrese el operador: ");
    operador = Console.ReadLine();

    int resultado = Calculadora.Calculadora.Calcular(numero1, numero2, operador);
    Console.WriteLine($"El resultado de la operacion es de: {resultado}");

    Console.WriteLine("Desea realizar otra operacion? S/N: ");
    respuesta = Console.ReadLine();

} while (respuesta == "S");
