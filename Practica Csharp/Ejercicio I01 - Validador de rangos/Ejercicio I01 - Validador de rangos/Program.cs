//Realizar una clase llamada validador que posea un método estático llamado validar, valor: dato a validar.
//min: mínimo valor incluido.
//max: máximo valor incluido.
//pedir al usuario que ingrese 10 números enteros. validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
//terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

int numero;
string buffer;
bool estado;
int minIngreso = -100;
int maxIngreso = 100;
int acum = 0;
float prom;

int menor = int.MaxValue;
int maximo = int.MinValue;



for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese numero dentro del rango -100 y 100: ");
    buffer = Console.ReadLine();
    estado = int.TryParse(buffer, out numero);

    bool esValido = Ejercicio_I01___Validador_de_rangos.Validador.Validar(numero, minIngreso, maxIngreso);

    if (esValido)
    {
        Console.WriteLine($"El valor {numero} esta dentro del rango {minIngreso} y {maxIngreso}");
        acum += numero;
        if (numero < menor)
        {
            menor = numero;
        }
        if (numero > maximo)
        {
            maximo = numero;
        }
    }
    else
    {
        Console.WriteLine($"El valor {numero} esta fuera del rango {minIngreso} y {maxIngreso}");
        i--;
    }
}
prom = acum / 10;
Console.WriteLine($"El menor numero ingresado es {menor} el mayor numero ingresado es {maximo}");
Console.WriteLine($"El promedio es de {prom}");