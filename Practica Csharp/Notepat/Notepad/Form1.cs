namespace Notepad
{
    public partial class Form1 : Form
    {
        // Variable para contar las palabras y caracteres
        int numPalabras = 0;
        int numCaracteres = 0;
        public Form1()
        {
            InitializeComponent();

            // Suscribirse al evento TextChanged del RichTextBox para actualizar el StatusStrip
            richTextBox1.TextChanged += RichTextBox1_TextChanged;

            // Inicializar el StatusStrip con algunas funciones comunes
            toolStripStatusLabelPosicion.Text = "Línea: 1, Columna: 1";
            toolStripStatusLabelModo.Text = "Insertar";
            toolStripStatusLabelGuardado.Text = "Guardado";
            toolStripStatusLabelCodificacion.Text = "UTF-8";
            toolStripStatusLabelConteo.Text = "Palabras: 0, Caracteres: 0";
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            // Actualizar la posición del cursor en el StatusStrip
            int linea = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            int columna = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(linea - 1) + 1;
            toolStripStatusLabelPosicion.Text = $"Línea: {linea}, Columna: {columna}";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}