using Entidades;

namespace FormAvisameSiCambia
{
    public partial class Form1 : Form
    {
        // Atributo privado de tipo Persona
        private Persona persona;
        public Form1()
        {
            InitializeComponent();
        }
        public static void NotificarCambio (string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona
                {
                    apellido = txb_Apellido.Text,
                    nombre = txb_Nombre.Text
                };
                // Cambiar el texto del botón a "Actualizar"
                btn_Crear.Text = "Actualizar";
            }
            else
            {
                persona.apellido = txb_Apellido.Text;
                persona.nombre = txb_Nombre.Text;
            }
            // Mostrar el nombre completo en el label
            lbl_NombreCompleto.Text = persona.Mostrar();

            // Notificar el cambio
            NotificarCambio($"Datos de la persona actualizados: {persona.Mostrar()}");
        }
    }
}