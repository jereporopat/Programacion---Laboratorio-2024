namespace Entidades
{
    public class Persona
    {
        public string apellido;
        public string nombre;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string Mostrar()
        {
            return nombre + apellido;
        }
        // Delegado DelegadoString
        public delegate void DelegadoString(string mensaje);


    }
}