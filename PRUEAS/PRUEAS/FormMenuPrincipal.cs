namespace PRUEAS
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.BackgroundImage = SuizaSystem.Properties.Resources.suiza;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
            FormVerMateria materia = new FormVerMateria();
            materia.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVerDivisiones divisiones = new FormVerDivisiones();
            divisiones.Show();
            this.Close();
        }

        private void ConfigurarBotonesEstaticos()
        {
            // Configura los botones para que no respondan a los cambios de tamaño
            button1.Anchor = AnchorStyles.None;
            button2.Anchor = AnchorStyles.None;
            button3.Anchor = AnchorStyles.None;
            button4.Anchor = AnchorStyles.None;
            button6.Anchor = AnchorStyles.None;
            label1.Anchor = AnchorStyles.None;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Width = 1200; // Ancho deseado
            this.Height = 800; // Alto deseado

            // Configura los botones y el Label para mantener su posición y tamaño
            ConfigurarBotonesEstaticos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormVerEvaluaciones formVerEvaluaciones = new FormVerEvaluaciones();
            formVerEvaluaciones.Show();
            this.Close();
        }


    }
}
