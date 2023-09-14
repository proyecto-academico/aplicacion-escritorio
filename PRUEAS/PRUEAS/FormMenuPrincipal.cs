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
            FormVerMateria formVerMateria = new FormVerMateria();
            formVerMateria.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVerDivisiones formVerDivisiones = new FormVerDivisiones();
            formVerDivisiones.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormVerEvaluaciones formVerEvaluciones = new FormVerEvaluaciones();
            formVerEvaluciones.Show();
            this.Close();

        }
    }
}
