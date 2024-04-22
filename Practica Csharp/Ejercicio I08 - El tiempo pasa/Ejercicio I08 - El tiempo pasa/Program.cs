// Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual.
// Tener en cuenta los años bisiestos.
//Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona
//hasta la fecha actual utilizando el método desarrollado anteriormente.
//Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.

string inputFecha;
int diasVividos;

Console.WriteLine("Ingrese fecha de nacimiento para calcular diferencia dd/MM/AAAA: ");
inputFecha = Console.ReadLine();

DateTime fechaNacimiento = DateTime.ParseExact(inputFecha, "dd/MM/yyyy", null);

diasVividos = Ejercicio_I08___El_tiempo_pasa.CalcularFecha.CalcularDias(fechaNacimiento);

Console.WriteLine($"La cantidad de dias vividos para esta persona es de {diasVividos}");