namespace PRUEAS
{
    public partial class FormVerDivisiones : Form
    {
        public FormVerDivisiones()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormGuardarDivisiones agregarDivisiones= new FormGuardarDivisiones(persona, false);
            //agregarDivisiones.ShowDialog(this);
        }

        private void FormVerDivisiones_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver2_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
