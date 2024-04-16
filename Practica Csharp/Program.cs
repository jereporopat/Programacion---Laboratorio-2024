//I01) Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

//int numero;
//string buffer;
//bool estado;
//int contador = 0;
//int minIngresado = int.MaxValue;
//int maxIngresado = int.MinValue;
//int acumulador = 0;

//do
//{
//    Console.WriteLine("Ingrese un numnero");
//    buffer = Console.ReadLine();
//    estado = int.TryParse(buffer, out numero);
//    contador ++;
//    acumulador += numero;

//    if (numero > maxIngresado)
//    {
//        maxIngresado = numero;
//    }
//    if (numero < minIngresado)
//    {
//        minIngresado = numero;
//    }

//} while (contador < 5);
//float promedio = acumulador / contador;

//Console.WriteLine($"El mayor numero ingresador es: {maxIngresado}. El menor numero ingresado es: {minIngresado}. El promedio es de: {promedio}");

//I02) Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso
//    contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

//int numero;
//string buffer;
//bool estado;
//double cuadrado;
//double cubo;

//do
//{
//    Console.WriteLine("Ingrese un numero");
//    buffer = Console.ReadLine();
//    estado = int.TryParse(buffer, out numero);
//    if (numero < 0)
//    {
//        Console.WriteLine("ERROR. ¡Reingresar número!");
//    }
//} while (numero < 0);

//cuadrado = Math.Pow(numero, 2);
//cubo = Math.Pow(numero, 3);

//Console.WriteLine($"El cuadrado del numero es: {cuadrado}. El cubo del numero es: {cubo}");

//I03) Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
//Validar que el dato ingresado por el usuario sea un número.
//Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
//Si ingresa "salir", cerrar la consola.
//Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

//static bool EsPrimo(int numero)
//{
//    if (numero <= 1)
//        return false;

//    // Iteramos hasta la mitad del número
//    for (int i = 2; i <= numero / 2; i++)
//    {
//        if (numero % i == 0)
//            return false;
//    }

//    return true;
//}

//int numeroIngresado;
//string buffer;
//bool estado;


//Console.WriteLine("Ingrese numero: ");
//buffer = Console.ReadLine();
//if (buffer == "salir")
//{
//    Environment.Exit(0);
//}
//estado = int.TryParse(buffer, out numeroIngresado);

//Console.WriteLine("Los números primos a partir del número ingresado son:");
//for (int i = 0; i <= numeroIngresado ; i++)
//{
//    if (EsPrimo(i))
//        Console.WriteLine(i);
//}

//I04)Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
//El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
//Escribir una aplicación que encuentre los 4 primeros números perfectos.

//int numeroPerfecto = 0;
//int dividendo = 1;

//while (numeroPerfecto != 4)
//{
//    int acumulador = 0;

//    for (int i = 1; i < dividendo; i++)
//    {
//        if (dividendo % i == 0)
//        {
//            acumulador+=i;
//        }
//    }
//    if (acumulador == dividendo)
//    {
//        numeroPerfecto++;
//        Console.WriteLine(dividendo);
//    }
//    dividendo++;
//}

//I05)Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
//El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15. 
//El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
//Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

//Console.Write("Ingrese un número: ");
//int numeroIngresado = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Los centros numéricos hasta el número ingresado son:");
//for (int i = 1; i <= numeroIngresado; i++)
//{
//    if (EsCentroNumerico(i))
//    {
//        Console.WriteLine(i);
//    }
//}

//    static bool EsCentroNumerico(int numero)
//{
//    int sumaAnteriores = 0;
//    int sumaPosteriores = 0;

//    // Calcular la suma de los números anteriores
//    for (int i = 1; i < numero; i++)
//    {
//        sumaAnteriores += i;
//    }

//    // Calcular la suma de los números posteriores
//    for (int i = numero + 1; ; i++)
//    {
//        sumaPosteriores += i;
//        if (sumaPosteriores >= sumaAnteriores)
//        {
//            break;
//        }
//    }

//    // Comprobar si las sumas son iguales
//    return sumaAnteriores == sumaPosteriores;
//}

//I06)Escribir un programa que determine si un año es bisiesto.
//Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
//Por ejemplo: el año 2000 es bisiesto pero 1900 no.
//Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

//int añoInicio;
//int añoFinal;
//bool estado;
//string buffer;

//Console.WriteLine("Ingrese año de inicio: ");
//buffer = Console.ReadLine();
//estado = int.TryParse(buffer, out añoInicio);

//Console.WriteLine("Ingese año de final: ");
//buffer = Console.ReadLine();
//estado = int.TryParse(buffer, out añoFinal);

//Console.WriteLine("Los años bisiestos son: ");
//for(int i = añoInicio; i <= añoFinal; i++)
//{
//    if (i % 4 == 0){
//        Console.WriteLine(i);
//    }
//}
//I07)Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas
//en el mes de N cantidad de empleados de una fábrica. Se pide calcular el importe a cobrar teniendo en cuenta que el total
//(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas)
//hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
//Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos
//los empleados ingresados.

//int valorHora;
//string nombre;
//int antiguedad;
//int horasTrabajadas;
//float importeACobrarBruto;
//float importeACobrarNeto;
//int cantidadDeEmpleados;
//bool estado;
//string buffer;

//Console.WriteLine("Ingrese la cantidad de empleados: ");
//buffer = Console.ReadLine();
//estado = int.TryParse(buffer, out cantidadDeEmpleados);

//for (int i = 0; i < cantidadDeEmpleados; i++)
//{
//    Console.WriteLine("Ingrese el valor hora: ");
//    buffer = Console.ReadLine();
//    estado = int.TryParse(buffer, out valorHora);

//    Console.WriteLine("Ingrese el nombre: ");
//    nombre = Console.ReadLine();

//    Console.WriteLine("Ingrese la antiguedad: ");
//    buffer = Console.ReadLine();
//    estado = int.TryParse(buffer, out antiguedad);

//    Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
//    buffer = Console.ReadLine();
//    estado = int.TryParse(buffer, out horasTrabajadas);

//    importeACobrarBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);
//    importeACobrarNeto = importeACobrarBruto * 0.13F;

//    Console.WriteLine("------------------------------------------------------");
//    Console.WriteLine($"Nombre: {nombre}");
//    Console.WriteLine($"Antiguedad: {antiguedad}");
//    Console.WriteLine($"Valor hora: {valorHora}");
//    Console.WriteLine($"Total a cobrar en bruto: {importeACobrarBruto}");
//    Console.WriteLine($"Total a cobrar neto: {importeACobrarNeto}");
//    Console.WriteLine("------------------------------------------------------");
//}

//I08)Escribir un programa que imprima por consola un triángulo.El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo
//int altura;

//string buffer;
//bool estado;

//Console.WriteLine("Ingrese altura del triangulo: ");
//buffer = Console.ReadLine();
//estado = int.TryParse(buffer, out altura);

//for (int i = 0; i < altura; i++)
//{
//    string asteriscos = "*";
//    for (int j = 0; j < i; j++)
//    {
//        asteriscos += "**";
//    }
//    Console.WriteLine(asteriscos);
//}
//I09)Escribir un programa que imprima por consola un triángulo.El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.

//int altura;

//Console.WriteLine("Ingrese altura del triángulo: ");
//do
//{
//    string buffer = Console.ReadLine();
//    if (!int.TryParse(buffer, out altura) || altura < 1)
//    {
//        Console.WriteLine("ERROR. Por favor, ingrese un número entero positivo mayor que cero.");
//    }
//} while (altura < 1);

//for (int i = 1; i <= altura; i++)
//{
//    // Imprimir espacios
//    for (int j = 0; j < altura - i; j++)
//    {
//        Console.Write(" ");
//    }

//    // Imprimir asteriscos
//    for (int j = 0; j < 2 * i - 1; j++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine(); // Salto de línea para la próxima fila
//}
