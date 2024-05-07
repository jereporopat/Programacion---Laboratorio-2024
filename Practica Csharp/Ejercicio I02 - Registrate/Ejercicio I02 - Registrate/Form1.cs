using Entidades;

namespace Ejercicio_I02___Registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string genero = string.Empty;
            string nombre = txt_Nombre.Text;
            decimal edad = nup_Edad.Value;
            string direccion = txt_direccion.Text;
            List<string> cursos = new List<string>();
            string pais = string.Empty;

            foreach (Control item in gpb_Genero.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    genero = item.Text;
                }
            }

            foreach (Control item in gpb_Cursos.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    cursos.Add(item.Text);
                }
            }
            if (lstb_Paises.SelectedIndex != -1)
            {
                pais = lstb_Paises.SelectedItem.ToString();
                Ingresante ingresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);
                MessageBox.Show(ingresante.Mostrar());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstb_Paises.Items.Add("Argentina");
            lstb_Paises.Items.Add("Chile");
            lstb_Paises.Items.Add("Uruguay");
        }
    }
}