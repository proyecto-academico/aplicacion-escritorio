namespace PRUEAS
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVerPersonas Alumno_BaseDeDatos = new FormVerPersonas();
            Alumno_BaseDeDatos.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVerClaseMateria formVerClaseMateria = new FormVerClaseMateria();
            formVerClaseMateria.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
