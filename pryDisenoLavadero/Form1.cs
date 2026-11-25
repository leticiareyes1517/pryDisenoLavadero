namespace pryDisenoLavadero
{
    public partial class formLavado : Form
    {
        public formLavado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtvehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos (0-9) y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
