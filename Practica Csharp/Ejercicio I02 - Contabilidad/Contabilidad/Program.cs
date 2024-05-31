using ContabilidadEntidades;

Recibo recibo1 = new Recibo();
Factura factura1 = new Factura(123);
Factura factura2 = new Factura(55);

Contabilidad<Factura,Recibo> contabilidad = new Contabilidad<Factura,Recibo>();

contabilidad += recibo1;
contabilidad += factura1;
contabilidad += factura2;

foreach (Factura item in contabilidad.egresos)
{
    Console.WriteLine(item.Numero);
}