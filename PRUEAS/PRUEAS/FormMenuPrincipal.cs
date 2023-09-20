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
<<<<<<< HEAD
            FormVerMateria materia = new FormVerMateria();
            materia.Show();
            this.Close();

=======
            FormVerMateria formVerMateria = new FormVerMateria();
            formVerMateria.Show();
            this.Close();
>>>>>>> 7d92c16edfd87db4cd448c12586d55176fab09df
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FormVerDivisiones divisiones = new FormVerDivisiones();
            divisiones.Show();
=======
            FormVerDivisiones formVerDivisiones = new FormVerDivisiones();
            formVerDivisiones.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormVerEvaluaciones formVerEvaluciones = new FormVerEvaluaciones();
            formVerEvaluciones.Show();
>>>>>>> 7d92c16edfd87db4cd448c12586d55176fab09df
            this.Close();

        }
    }
}
