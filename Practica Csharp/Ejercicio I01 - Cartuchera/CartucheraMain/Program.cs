using Cartuchera;

ConsoleColor colorOriginal = Console.ForegroundColor;

Lapiz miLapiz = new Lapiz(100);
Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

EscrituraWrapper eLapiz = (((IAcciones)miLapiz).Escribir("hola"));
Console.ForegroundColor = eLapiz.color;
Console.WriteLine(eLapiz.texto);
Console.ForegroundColor = colorOriginal;
Console.WriteLine(miLapiz);

EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
Console.ForegroundColor = eBoligrafo.color;
Console.WriteLine(eBoligrafo.texto);
Console.ForegroundColor = colorOriginal;
Console.WriteLine(miBoligrafo);

Console.ReadKey();