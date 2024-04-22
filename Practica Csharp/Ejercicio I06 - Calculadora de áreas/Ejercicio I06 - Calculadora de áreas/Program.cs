// Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen
// el cálculo del área que corresponda
//El ingreso de los datos como la visualización se deberán realizar desde el método Main().
double longitudLadoCuadrado;
double baseTriangulo;
double alturaTriangulo;
double radioCirculo;


Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
longitudLadoCuadrado = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la base del triángulo:");
baseTriangulo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura del triángulo:");
alturaTriangulo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el radio del círculo:");
radioCirculo = Convert.ToDouble(Console.ReadLine());

// Calcular áreas usando los métodos estáticos
double areaCuadrado = Ejercicio_I06___Calculadora_de_áreas.CalculadoraDeArea.CalcularAreaCuadrado(longitudLadoCuadrado);
double areaTriangulo = Ejercicio_I06___Calculadora_de_áreas.CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
double areaCirculo = Ejercicio_I06___Calculadora_de_áreas.CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);

// Mostrar resultados
Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
Console.WriteLine("El área del triángulo es: " + areaTriangulo);
Console.WriteLine("El área del círculo es: " + areaCirculo);

