namespace Ejercicio_I02___Atrapame_si_puedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los TextBox no estén vacíos
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    throw new ParametrosVacios("Ambos parámetros son requeridos y no pueden estar vacíos.");
                }

                // Convertir los valores a enteros
                int numero1 = int.Parse(textBox1.Text);
                int numero2 = int.Parse(textBox2.Text);

                // Calcular la división
                int resultado = Calculador.Calcular(numero1, numero2);

                // Mostrar el resultado en el RichTextBox
                richTextBox1.Text = $"Resultado: {resultado}";
            }
            catch (ParametrosVacios ex)
            {
                MessageBox.Show(ex.Message, "Error de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los parámetros deben ser números enteros.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error de División", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}