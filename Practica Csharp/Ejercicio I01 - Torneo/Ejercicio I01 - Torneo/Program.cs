using TorneoEntidades;

Torneo<EquipoFutbol> torneoFtubol = new Torneo<EquipoFutbol>("torneito");

EquipoFutbol e1 = new EquipoFutbol("CAI", DateTime.Now);
EquipoFutbol e2 = new EquipoFutbol("CABJ", DateTime.Now);

_= torneoFtubol + e1;
_= torneoFtubol + e2;

Console.WriteLine(torneoFtubol.Mostrar());
Console.WriteLine(torneoFtubol.JugarPartido);