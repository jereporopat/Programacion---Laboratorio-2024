namespace Notepad
{
    public partial class Form1 : Form
    {
        private string ultimoArchivo;
        public Form1()
        {
            InitializeComponent();

            // Configurar el StatusStrip y agregar el ToolStripStatusLabel
            statusStrip1.Items.Add(new ToolStripStatusLabel("Listo"));

            // Suscribirse al evento TextChanged del RichTextBox
            richTextBox1.TextChanged += richTextBox1_TextChanged;

            // Actualizar el ToolStripStatusLabel con la cantidad de caracteres actualizada
            ((ToolStripStatusLabel)statusStrip1.Items[0]).Text = $"Caracteres: {richTextBox1.TextLength}";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Actualizar el ToolStripStatusLabel con la cantidad de caracteres actualizada
            ((ToolStripStatusLabel)statusStrip1.Items[0]).Text = $"Caracteres: {richTextBox1.TextLength}";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Leer el contenido del archivo seleccionado
                        string contenido = File.ReadAllText(openFileDialog.FileName);

                        // Mostrar el contenido en el RichTextBox
                        richTextBox1.Text = contenido;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivo de texto|*.txt";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el contenido del RichTextBox en el archivo seleccionado
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ultimoArchivo))
            {
                GuardarContenidoEnArchivo(ultimoArchivo);
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
        private void GuardarContenidoEnArchivo(string nombreArchivo)
        {
            try
            {
                File.WriteAllText(nombreArchivo, richTextBox1.Text);
                ultimoArchivo = nombreArchivo; // Actualizar el último archivo guardado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}