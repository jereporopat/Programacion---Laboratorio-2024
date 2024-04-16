//Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
//El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.
//El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

int numeroD;
string numeroB;

string buffer;
bool estado;

Console.WriteLine("Ingrese un numero entero del sistema decimal para convertir en binario: ");
buffer = Console.ReadLine();
estado = int.TryParse(buffer, out numeroD);
string binario = Conversor.Conversor.ConvertirDecimalABinario(numeroD);
Console.WriteLine($"El numnero {numeroD} en binario es: {binario}");

Console.WriteLine("Ingrese un numero entero del sistema binario para converitr a decimal: ");
numeroB = Console.ReadLine();
int dec = Conversor.Conversor.ConvertirBinarioADecimal(numeroB);
Console.WriteLine($"El numero {numeroB} en decimal es: {dec}");