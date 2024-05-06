//Esta aplicación servirá de control de llamadas realizadas en una central telefónica.
//Crear en una solución llamada CentralTelefonica un proyecto de tipo biblioteca de clases nombrado como Centralita que
//contenga la siguiente jerarquía de clases:
//Llamada
//Tendrá todos sus atributos con el modificador protected. Crear las propiedades de sólo lectura para exponer estos atributos.
//OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
//Mostrar es un método de instancia que deberá retornar todos los datos de la llamada como texto. Utilizar StringBuilder.
//Local
//Hereda de Llamada.
//Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada. Utilizar StringBuilder.
//CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
//La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
//Provincial
//Hereda de Llamada.
//Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada y la franja horaria. Utilizar StringBuilder.
//CalcularCosto será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán:
//Franja_1: 0.99
//Franja_2: 1.25
//Franja_3: 0.66
//Centralita
//CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
//El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
//La lista sólo se inicializará en el constructor por defecto Centralita.
//Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio de lo facturado según el criterio (llamada local, provincial o todas). Dichos valores se calcularán en el método CalcularGanancia.
//Generar un nuevo proyecto de consola llamado Test. El namespace también deberá llamarse Test.
//Agregar el siguiente código en el método Main para probar la centralita:
