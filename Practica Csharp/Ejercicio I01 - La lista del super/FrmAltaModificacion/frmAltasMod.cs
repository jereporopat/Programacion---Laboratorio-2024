namespace FrmAltaModificacion
{
    public partial class frmAltasMod : Form
    {
        public frmAltasMod(string titulo ,string objeto, string cofirmar)
        {
            InitializeComponent();

            Text = titulo;
            txtObjeto.Text = objeto;
            btnConfirmar.Text = cofirmar;
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObjeto.Text))
            {
                MessageBox.Show("El campo de texto esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 es el código ASCII que representa a ENTER.
            {
                if (string.IsNullOrEmpty(txtObjeto.Text))
                {
                    MessageBox.Show("El campo de texto esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}