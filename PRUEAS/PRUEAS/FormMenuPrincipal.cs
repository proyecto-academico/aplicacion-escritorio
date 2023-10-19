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

        private void ConfigurarBotonesCentrados()
        {
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Agrega más botones según sea necesario
        }
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Maximiza el formulario al cargar
            ConfigurarBotonesCentrados();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormVerEvaluaciones formVerEvaluaciones = new FormVerEvaluaciones();
            formVerEvaluaciones.Show();
            this.Close();
        }
    }
}
